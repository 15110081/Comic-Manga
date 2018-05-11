using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic
{
    public partial class ReadComic : Form
    {
        string[] files;
        int count = 0;
        public static string s2;
        public ReadComic(string s)
        {
            InitializeComponent();
            lblUserName.Text = s;
            s2 = lblUserName.Text;
        }
        public ReadComic(string s, string s1,string s3)
        {
            InitializeComponent();
            linkChapterID.Text = s;
            txtStoreID.Text = s1;
            txtChapterName.Text = s3;
            InsertHistoryuser();
        }
        public ReadComic( )
        {
            InitializeComponent();
        }
        private void ReadComic_Load(object sender, EventArgs e)
        {         
            LoadImage();        
        }
        public void LoadImage()
        {
            string sChuoiTruyVan = "select image_path From [dbo].[image] where chapter_id=" + linkChapterID.Text;
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sChuoiTruyVan);
            string pathtest = dt.Rows[0]["image_path"].ToString();
            pathtest = pathtest.Substring(0, pathtest.Length - 5);
            string filepath = @"E:/" + pathtest;
            //txtchapterpath.Text = filepath;
            files = Directory.GetFiles(filepath).OrderBy(f => new FileInfo(f).FullName).ToArray();
            var images = new Image[files.Length];
            for (int j = 0; j < files.Length; j++)
            {
                images[j] = Image.FromFile(files[j]);               
                PictureBox imgComic = new PictureBox();
                imgComic.SizeMode = PictureBoxSizeMode.AutoSize;             
                imgComic.Image = images[j];                
                imgComic.Anchor = AnchorStyles.Left;
                imgComic.Anchor = AnchorStyles.Right;
                imgComic.Dock = DockStyle.Fill;
                Panel pnl = new Panel();
                pnl.AutoSize = true;
                pnl.Dock = DockStyle.Fill;
                pnl.Controls.Add(imgComic);
                flowLayoutPanel1.Controls.Add(pnl);
            }
            ReadComic.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
        }
        public void InsertHistoryuser()
        {
            //  string ChuoiTruyVan = string.Format("insert into [dbo].[history_user](store_id,username,date_history,chaptername) values({0},{1},{2},{3}) ",txtStoreID.Text,txtUserName.Text,);
           string query = "EXEC [dbo].[Insert_History_User] @store_id , @username , @chaptername";
           int dt= DataProvider.Instance.ExecuteNonQuery(query, new object[] { txtStoreID.Text,s2,txtChapterName.Text});
        }
        private void ReadComic_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetailsComic form = new DetailsComic(txtStoreID.Text);
            form.Show();
        }
    }
}
