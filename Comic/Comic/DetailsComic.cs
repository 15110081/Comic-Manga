using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic
{
    public partial class DetailsComic : Form
    {
        public static string MaStore;
        public string s;
        public DetailsComic()
        {
            InitializeComponent();
        }
        public DetailsComic(string q)
        {
            InitializeComponent();
            labelDetailComic.Text = q;
            MaStore = q;
        }
        private void DetailsComic_Load(object sender, EventArgs e)
        {
            Loadstoredetails();
            initListView();
            LoadStar();
        }
        private void Loadstoredetails()
        {
            string sChuoiTruyVan = "EXEC dbo.ChiTietStore @ma" ;
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan,new object[] { labelDetailComic.Text });
            lblCapNhat.Text = dt.Rows[0]["store_update"].ToString();
            lblLuotXem.Text = dt.Rows[0]["store_view"].ToString();
            lblSoChapter.Text = dt.Rows[0]["chapter_num"].ToString();
            lblTacGia.Text = dt.Rows[0]["store_author"].ToString();
            lblTheLoai.Text = dt.Rows[0]["store_cat"].ToString();
            lblTrangThai.Text = dt.Rows[0]["store_status"].ToString();
            lblName.Text = dt.Rows[0]["store_name"].ToString();
            Bitmap bm = new Bitmap(dt.Rows[0]["img"].ToString());
            picComic.Image = bm;
            txtContent.Text = dt.Rows[0]["store_content"].ToString();
        }
        private void initListView()
        {
            // Add columns
           // lvDetailsComic.Columns.Add("Name", 400, HorizontalAlignment.Left);
            //lvDetailsComic.Columns.Add("Date", 400, HorizontalAlignment.Left);
           // lvDetailsComic.Columns.Add("ID", 0, HorizontalAlignment.Left);
            string sChuoiTruyVan = "select * From [dbo].[chapter] where store_id=" + labelDetailComic.Text;
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) 
            {
                for (int i = 0; i < dt.Rows.Count; i++) 
                {
                    var item1 = new ListViewItem(new[] { dt.Rows[i]["chapter_name"].ToString(),
                    dt.Rows[i]["chapter_date"].ToString(),  dt.Rows[i]["chapter_id"].ToString()});
                    lvDetailsComic.Items.Add(item1);
                }
            }
        }
        private void LoadStar()
        {
            string sChuoiTruyVan = "select star From [dbo].[store] where store_id=" + labelDetailComic.Text;
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sChuoiTruyVan);
           int star=Convert.ToInt32( dt.Rows[0]["star"].ToString());
            Bitmap bm = new Bitmap(Properties.Resources.star__2_1);
            if (star == 1)
                BTN1.Image = bm;
            else if (star == 2) { BTN1.Image = bm; BTN2.Image = bm; }
            else if (star == 3) { BTN1.Image = bm; BTN2.Image = bm; BTN3.Image = bm; }
            else if (star == 4) { BTN1.Image = bm; BTN2.Image = bm; BTN3.Image = bm; BTN4.Image = bm; }
            else if (star == 5) { BTN1.Image = bm; BTN2.Image = bm; BTN3.Image = bm; BTN4.Image = bm;BTN5.Image = bm; }
        }

        private void lvDetailsComic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDetailsComic.SelectedItems.Count > 0)
            {
                ListViewItem lv =lvDetailsComic.SelectedItems[0];
                s = lv.SubItems[2].Text;
                string s1 = labelDetailComic.Text;
                //s = Convert.ToString((sender as ListViewItem.ListViewSubItem).Text);
                //Form1 form = new Form1(s, s1);
                //form.Show();
                ReadComic form1 = new ReadComic(s, s1, lv.SubItems[0].Text);
                form1.Show();
                this.Close();
            }
        }

        private void BTN1_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.star__2_1);
            BTN1.Image = bm;
            Bitmap bm1 = new Bitmap(Properties.Resources.star__3_);
            BTN3.Image = bm1;
            BTN4.Image = bm1;
            BTN5.Image = bm1;
            BTN2.Image = bm1;
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            float num = 1;
            string sChuoiTruyVan = string.Format("EXEC UpdateStar @storeid , @star ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan, new object[] { MaStore, num });
            MessageBox.Show("Thank you for voting");
            LoadStar();
        }

        private void BTN1_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.star__3_);
            BTN1.Image = bm;
        }

        private void BTN2_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.star__2_1);
            BTN2.Image = bm;
            BTN1.Image = bm;
            Bitmap bm1= new Bitmap(Properties.Resources.star__3_);
            BTN3.Image = bm1;
            BTN4.Image = bm1;
            BTN5.Image = bm1;
        }

        private void BTN2_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.star__3_);
            BTN1.Image = bm;
            BTN2.Image = bm;
        }

        private void BTN3_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.star__2_1);
            BTN2.Image = bm;
            BTN1.Image = bm;
            BTN3.Image = bm;
            Bitmap bm1 = new Bitmap(Properties.Resources.star__3_);
            BTN4.Image = bm1;
            BTN5.Image = bm1;
        }

        private void BTN3_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bm1 = new Bitmap(Properties.Resources.star__3_);
            BTN1.Image = bm1;
            BTN2.Image = bm1;
            BTN3.Image = bm1;
        }

        private void BTN4_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.star__2_1);
            BTN2.Image = bm;
            BTN1.Image = bm;
            BTN3.Image = bm;
            BTN4.Image = bm;
            Bitmap bm1 = new Bitmap(Properties.Resources.star__3_);
            BTN5.Image = bm1;

        }

        private void BTN4_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bm1 = new Bitmap(Properties.Resources.star__3_);
            BTN1.Image = bm1;
            BTN2.Image = bm1;
            BTN3.Image = bm1;
            BTN4.Image = bm1;
        }

        private void BTN5_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.star__2_1);
            BTN2.Image = bm;
            BTN1.Image = bm;
            BTN3.Image = bm;
            BTN4.Image = bm;
            BTN5.Image = bm;
           
        }

        private void BTN5_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bm1 = new Bitmap(Properties.Resources.star__3_);
            BTN3.Image = bm1;
            BTN4.Image = bm1;
            BTN5.Image = bm1;
            BTN2.Image = bm1;
            BTN1.Image = bm1;
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            float num = 2;
            string sChuoiTruyVan = string.Format("EXEC UpdateStar @storeid , @star ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan,new object[] { MaStore,num});
            MessageBox.Show("Thank you for voting");
            LoadStar();
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            float num = 3;
            string sChuoiTruyVan = string.Format("EXEC UpdateStar @storeid , @star ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan, new object[] { MaStore, num });
            MessageBox.Show("Thank you for voting");
            LoadStar();
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            float num = 4;
            string sChuoiTruyVan = string.Format("EXEC UpdateStar @storeid , @star ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan, new object[] { MaStore, num });
            MessageBox.Show("Thank you for voting");
            LoadStar();
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            float num = 5;
            string sChuoiTruyVan = string.Format("EXEC UpdateStar @storeid , @star ");
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan, new object[] { MaStore, num });
            MessageBox.Show("Thank you for voting");
            LoadStar();
        }
    }
}
