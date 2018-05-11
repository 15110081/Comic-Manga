using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DAL;
using DTO;
using BUL;
using Comic;
namespace Comic
{
    public partial class Store : UserControl
    {
        string path = "";
        byte[] image = null;
        SqlConnection conn = null;
        public Store()
        {
            InitializeComponent();
        }
        //List<Store_DTO> lstStore;
        int index;
        public Image generate_pp(double pass)
        {
            double dpgg_d = double.Parse(dgbb.Width.ToString());
            double x = 0;
            x = (pass * dpgg_d) / 2000;
            pic.Width = (int)Math.Round(x, 0);
            return PaneltoBitMap(dgbb);
        }
        private static Image PaneltoBitMap(Control pnl)
        {
            var bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }

      



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|All File|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName.ToString();
                pComic.SizeMode = PictureBoxSizeMode.Zoom;

            }
            if (path != "")
            {
                FileStream Streem = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(Streem);
                image = brs.ReadBytes((int)Streem.Length);
                pComic.Image = ByteToImage(image);
            }
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private void Store_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            //Loaddata();
        }
        public void LoadDataGridView()
        {
            try
            {
                if (!this.DesignMode)
                {
                    string sChuoiTruyVan = "EXEC dbo.LayToanBoStore";
                    DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan);
                    if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lệ và có giá trị
                    {
                        for (int i = 0; i < dt.Rows.Count; i++) //Duyệt datatable và đưa vào list đối tượng NHANVIEN_DTO
                        {

                            add_item(dt.Rows[i]["store_id"].ToString(), dt.Rows[i]["store_name"].ToString(), dt.Rows[i]["store_link"].ToString(), dt.Rows[i]["store_author"].ToString(),
                           dt.Rows[i]["store_cat"].ToString(), dt.Rows[i]["chapter_num"].ToString(), dt.Rows[i]["store_status"].ToString(), dt.Rows[i]["store_update"].ToString(),
                           dt.Rows[i]["store_view"].ToString(), dt.Rows[i]["store_content"].ToString(), dt.Rows[i]["star"].ToString(), generate_pp(Convert.ToDouble(dt.Rows[i]["chapter_num"].ToString())), dt.Rows[i]["img"].ToString(),
                           dt.Rows[i]["date_insert"].ToString(), dt.Rows[i]["date_update"].ToString(), dt.Rows[i]["date_delete"].ToString());

                        }
                    }
                }
            }catch(Exception ex) { }
        }
      
        void add_item(string id,string name,string link,string author,string cat,string num,string status,
            string update,string view,string content,string star,Image img,string imagePath,string s1,string s2 ,string s3)
        {
            try
            {
                var index = bunifuCustomDataGrid1.Rows.Add();
                bunifuCustomDataGrid1.Rows[index].Cells[0].Value = id;
                bunifuCustomDataGrid1.Rows[index].Cells[1].Value = name;
                bunifuCustomDataGrid1.Rows[index].Cells[3].Value = link;
                bunifuCustomDataGrid1.Rows[index].Cells[4].Value = author;
                bunifuCustomDataGrid1.Rows[index].Cells[5].Value = cat;
                bunifuCustomDataGrid1.Rows[index].Cells[6].Value = img;
                bunifuCustomDataGrid1.Rows[index].Cells[7].Value = num;
                bunifuCustomDataGrid1.Rows[index].Cells[8].Value = status;
                bunifuCustomDataGrid1.Rows[index].Cells[9].Value = update;
                bunifuCustomDataGrid1.Rows[index].Cells[10].Value = view;
                bunifuCustomDataGrid1.Rows[index].Cells[11].Value = content;
                //panel2.DrawToBitmap(img2, new Rectangle(0, 0, img2.Width, img2.Height));
                //string imagePath = @"F:\hinhcomic\fairytail.jpg";
                Bitmap bitmap = new Bitmap(imagePath);
                bunifuCustomDataGrid1.Rows[index].Cells[2].Value = bitmap;
                bunifuCustomDataGrid1.Rows[index].Cells[12].Value = star;
                bunifuCustomDataGrid1.Rows[index].Cells[13].Value = s1;
                bunifuCustomDataGrid1.Rows[index].Cells[14].Value = s2;
                bunifuCustomDataGrid1.Rows[index].Cells[15].Value = s3;
            }
            catch(Exception ex) { }
       }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sChuoiTruyVan = "EXEC dbo.ChiTietStore @ma";
            
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan, new object[] { lblID.Text });
            Store_DTO storeDTO = new Store_DTO();
            storeDTO.ID = Convert.ToInt32(lblID.Text);
            storeDTO.Author = txtAuthor.Text;
            storeDTO.Category = txtCat.Text;
            storeDTO.Chapter = Convert.ToInt32(txtChapter.Text);
            storeDTO.Content = txtContent.Text;
            storeDTO.Link = txtLink.Text;
            storeDTO.Name = txtName.Text;
            storeDTO.Star = Convert.ToInt32(txtStar.Text);
            storeDTO.View = Convert.ToInt32(txtView.Text);
            storeDTO.Status = txtStatus.Text;
            storeDTO.Date = txtUpdate.Text;
            string duongdan = dt.Rows[0]["img"].ToString();
            if (path == "")
            {
                storeDTO.Image = duongdan;
            }
            else storeDTO.Image = path;

            if (Store_BUL.UpdateStore(storeDTO) == true) //Nó đã thực thi làm thay đổi CSDL 
            {
                bunifuCustomDataGrid1.Rows.Clear();
                LoadDataGridView();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                Reset();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Thông báo");
            }
        }
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (bunifuCustomDataGrid1.SelectedRows != null)
                {
                    index = e.RowIndex;
                    var item0 = bunifuCustomDataGrid1.Rows[index].Cells[0].Value;
                    var item1 = bunifuCustomDataGrid1.Rows[index].Cells[1].Value;
                    var item2 = bunifuCustomDataGrid1.Rows[index].Cells[3].Value;
                    var item3 = bunifuCustomDataGrid1.Rows[index].Cells[4].Value;
                    var item4 = bunifuCustomDataGrid1.Rows[index].Cells[5].Value;
                    var item = bunifuCustomDataGrid1.Rows[index].Cells[6].Value;
                    var item5 = bunifuCustomDataGrid1.Rows[index].Cells[7].Value;
                    var item6 = bunifuCustomDataGrid1.Rows[index].Cells[8].Value;
                    var item7 = bunifuCustomDataGrid1.Rows[index].Cells[9].Value;
                    var item8 = bunifuCustomDataGrid1.Rows[index].Cells[10].Value;
                    var item9 = bunifuCustomDataGrid1.Rows[index].Cells[11].Value;
                    var item10 = (Image)bunifuCustomDataGrid1.Rows[index].Cells[2].Value;
                    var item11 = bunifuCustomDataGrid1.Rows[index].Cells[12].Value;
                    // Lấy ra dòng được chọn gán vào các control phía trên
                    lblID.Text = item0.ToString();
                    txtID.Text = item0.ToString();
                    txtName.Text = item1.ToString();
                    txtAuthor.Text = item3.ToString();
                    txtCat.Text = item4.ToString();
                    txtContent.Text = item9.ToString();
                    txtView.Text = item8.ToString();
                    txtChapter.Text = item5.ToString();
                    txtStatus.Text = item6.ToString();
                    txtLink.Text = item2.ToString();
                    txtStar.Text = item11.ToString();
                    txtUpdate.Text = item7.ToString();
                    pComic.Image = item10;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string sChuoiTruyVan = "EXEC dbo.LayToanBoStore";
            //string sChuoiTruyVan1 = @"select * From [dbo].[store]";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan);
           // DataTable dt1 = DataProvider.TruyVanDataReader(sChuoiTruyVan1);
            Store_DTO storeDTO = new Store_DTO();
            storeDTO.ID = Convert.ToInt32(txtID.Text);
            storeDTO.Author = txtAuthor.Text;
            storeDTO.Category = txtCat.Text;
            storeDTO.Chapter = Convert.ToInt32(txtChapter.Text);
            storeDTO.Content = txtContent.Text;
            storeDTO.Link = txtLink.Text;
            storeDTO.Name = txtName.Text;
            storeDTO.Star = Convert.ToInt32(txtStar.Text);
            storeDTO.View = Convert.ToInt32(txtView.Text);
            storeDTO.Status = txtStatus.Text;
            storeDTO.Date = txtUpdate.Text;
            //int t = e1.RowIndex;
           // Bitmap bitmap = new Bitmap(@"F:\hinhcomic\167964 - OVVF5E - 82");
            //string duongdan = dt.Rows[t]["img"].ToString();
            string duongdan = @"F:\hinhcomic\error.jpg";
            if (path == "")
            {
                storeDTO.Image = duongdan;
            }else storeDTO.Image = path;
            //storeDTO.Image=dt.Rows[]
             
           
            if (Store_BUL.InsertStore(storeDTO) == true) //Nó đã thực thi làm thay đổi CSDL 
            {
                bunifuCustomDataGrid1.Rows.Clear();
                LoadDataGridView();
                MessageBox.Show("Thêm thành công!", "Thông báo");
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Store_DTO storeDTO = new Store_DTO();
            int IDs = Convert.ToInt32(lblID.Text);
           // storeDTO.ID =Convert.ToInt32( lblID.Text);
            if (Store_BUL.DeleteStore(IDs) == true) //Nó đã thực thi làm thay đổi CSDL 
            {
                bunifuCustomDataGrid1.Rows.Clear();
                LoadDataGridView();
                Reset();
                MessageBox.Show("xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("xóa không thành công!", "Thông báo");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void Reset()
        {
            txtAuthor.Text = "";
            txtCat.Text = "";
            txtChapter.Text = "";
            txtContent.Text = "";
            txtID.Text = "";
            txtLink.Text = "";
            txtName.Text = "";
            txtStar.Text = "";
            txtStatus.Text = "";
            txtUpdate.Text = "";
            txtView.Text = "";
            //Bitmap bitmap = new Bitmap(@"F:\hinhcomic\error");
            pComic.Image =null;
        }

    }
}

