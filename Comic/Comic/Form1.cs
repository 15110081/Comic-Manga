using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using DAL;
using Microsoft.Win32;
using System.Diagnostics;

namespace Comic
{
    public partial class Form1 : Form
    {
        string[] files;
        int count = 0;
        public static float value = 1;
        public Form1(string s,string s1)
        {
            InitializeComponent();
            INIT();
            this.imgComic.MouseWheel += ImgComic_MouseWheel;
            linkchapterid.Text = s;
            txtStoreID.Text = s1;
        }
        public Form1()
        {
            InitializeComponent();          
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            //if (keyData == Keys.Up)
            //{
            //    MessageBox.Show("You pressed Up arrow key");
            //    return true;
            //}
            //capture down arrow key
            //if (keyData == Keys.Down)
            //{
            //    MessageBox.Show("You pressed Down arrow key");
            //    return true;
            //}
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                DisplayNextFile(--count % files.Length);
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                DisplayNextFile(++count % files.Length);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ImgComic_MouseWheel(object sender, MouseEventArgs e)
        {
            //  flag = 1;
            // Override OnMouseWheel event, for zooming in/out with the scroll wheel
            if (imgComic.Image != null)
            {
                // If the mouse wheel is moved forward (Zoom in)
                if (e.Delta > 0)
                {
                    // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                    if ((imgComic.Width < (15 * this.Width)) && (imgComic.Height < (15 * this.Height)))
                    {
                        // Change the size of the picturebox, multiply it by the ZOOMFACTOR
                        imgComic.Width = (int)(imgComic.Width * 1.25);
                        imgComic.Height = (int)(imgComic.Height * 2.25);

                        // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
                        imgComic.Top = (int)(e.Y - 1.25 * (e.Y - imgComic.Top));
                        imgComic.Left = (int)(e.X - 1.25 * (e.X - imgComic.Left));



                    }
                }
                else
                {
                    // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                    if ((imgComic.Width > (this.Width/10)) && (imgComic.Height > (this.Height/10)))
                    {// Change the size of the picturebox, divide it by the ZOOMFACTOR
                        imgComic.Width = (int)(imgComic.Width / 1.25);
                        imgComic.Height = (int)(imgComic.Height / 1.25);

                        // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
                        imgComic.Top = (int)(e.Y - 0.80 * (e.Y - imgComic.Top));
                        imgComic.Left = (int)(e.X - 0.80 * (e.X - imgComic.Left));

                    }
                }
            }
        }
        private Point firstPoint = new Point();

        public void INIT()
        {
            imgComic.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };
            imgComic.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);
                    imgComic.Location = new Point(imgComic.Location.X - res.X, imgComic.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
        }
        private void imgComic_MouseDown(object sender, MouseEventArgs e)
        {
            if (imgComic.Focused) return;
            imgComic.Focus();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            DisplayNextFile(count);
        }
       
        private void DisplayNextFile(int c)
        {
            string sChuoiTruyVan1 = "select chapter_link From [dbo].[chapter] where chapter_id=" + linkchapterid.Text;
            DataTable dt1 = DataProvider.Instance.TruyVanDataTable(sChuoiTruyVan1);
            linkchapter.Text = dt1.Rows[0]["chapter_link"].ToString();
            // string filepath = @"E:\xampp\htdocs\get_data\get_manga\data\eab0d3d82e3de59362f6f536ffb5252a";
            string sChuoiTruyVan = "select image_path From [dbo].[image] where chapter_id=" + linkchapterid.Text;
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sChuoiTruyVan);
            string pathtest = dt.Rows[0]["image_path"].ToString();
            pathtest = pathtest.Substring(0, pathtest.Length -5);
            string filepath = @"E:\"+pathtest;
            txtchapterpath.Text = filepath;
            files = Directory.GetFiles(filepath).OrderBy(f => new FileInfo(f).CreationTime).ToArray();
            var images = new Image[files.Length];
            if (c > files.Length) count=c= 0;
             
            for (int i = c; i < files.Length; ++i)
            {
                images[i] = Image.FromFile(files[i]);
                linkpage.Text = Convert.ToString(i);
                imgComic.Image = images[i];
                break;
            }


            if (count == files.Length) count = 0;
            if (count == 0) count = files.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayNextFile(--count%files.Length);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayNextFile(++count % files.Length);
          
        }

        private void rigthButton_Click(object sender, EventArgs e)
        {
            DisplayNextFile(++count % files.Length);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DisplayNextFile(--count % files.Length);
        }

        private void linkchapter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(GetDefaultBrowserPath(), linkchapter.Text);
        }
        private static string GetDefaultBrowserPath()
        {
            string key = @"HTTP\shell\open\command";
            using (RegistryKey registrykey = Registry.ClassesRoot.OpenSubKey(key, false))
            {
                return ((string)registrykey.GetValue(null, null)).Split('"')[1];
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetailsComic form = new DetailsComic(txtStoreID.Text);
            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkpage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
