using Comic.ucMainComic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic
{
    public partial class mainComic : Form
    {

        //Thread threadLoadProcessBar;
        //Thread threadLoadUserControl;
        //Task taskLoadProgressBar;
        //Task taskLoadUserControl;
        //ProgressBar progressBar;
        //Label lblPhanTram;
        //string ucName;
        //public void NoiDungUserControl()
        //{
        //    //Xóa hết những user control trong phần
        //    //foreach (UserControl uc in panel4.Controls.OfType<UserControl>())
        //    //{
        //    //    panel4.Controls.Remove(uc);
        //    //}
        //    //Add vào processbar từ ucProgressBar
        //    ucProgressBar PB = new ucProgressBar();
        //    PB.Dock = DockStyle.Fill;
        //    panel4.Controls.Add(PB);
        //    panel4.Controls["ucProgressBar"].BringToFront();
        //    //Gán giá trị Progressbar cho biến toàn cục
        //    progressBar = PB.PB;
        //    lblPhanTram = PB.Loading;
        //   // taskLoadUserControl = new Task(LoadUserControl);
        //   // taskLoadUserControl.Start();
        //    taskLoadProgressBar = new Task(LoadProgressBar);     
        //    taskLoadProgressBar.Start();
        //}
       
        public mainComic(string s)
        {
            InitializeComponent();
            lblUser.Text = s;
        }


        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainLogin form1 = new mainLogin();
            form1.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
           // ucProgressBar1.BringToFront();
            page_History1.BringToFront();
           
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
          //  ucProgressBar1.BringToFront();
            page_Popular1.BringToFront();   
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            page_Details1.BringToFront();
            //Label mLbl = (Label)sender;
            //Panel mPanel = (Panel)mLbl.Parent;
            //ucName = mPanel.AccessibleName;
            //NoiDungUserControl();
        }

        private void btnUpdating_Click(object sender, EventArgs e)
        {
          //  ucProgressBar1.BringToFront();
            page_Updating1.BringToFront();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

           // ucProgressBar1.BringToFront();
            page_Complete1.BringToFront();
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
           // ucProgressBar1.BringToFront();
            page_Ratings1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (sideleft.Width == 193)
            {
                sideleft.Width = 0;
            }
            else
            {
                sideleft.Width = 193;
            }
        }

        private void mainComic_Load(object sender, EventArgs e)
        {
            sideleft.Width = 0;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
            //ucProgressBar1.BringToFront();
            page_Home1.BringToFront();
        }
        //public async void LoadUserControl()
        //{

        //    // threadLoadUserControl.Suspend();
        //    taskLoadProgressBar.Wait();
        //    panel4.Invoke(new MethodInvoker(delegate ()
        //    {

        //        switch (ucName)
        //        {
        //            case "page_Complete":
        //                {
        //                    page_Complete uc = new page_Complete();
        //                    uc.Dock = DockStyle.Fill;
        //                    panel4.Controls.Add(uc);
        //                    panel4.Controls["page_Complete"].BringToFront();
        //                }; break;
        //            case "page_Details":
        //                {
        //                    page_Details uc = new page_Details();
        //                    uc.Dock = DockStyle.Fill;
        //                    panel4.Controls.Add(uc);
        //                    panel4.Controls["page_Details"].BringToFront();
        //                }; break;
        //            case "page_History":
        //                {
        //                    page_History uc = new page_History();
        //                    uc.Dock = DockStyle.Fill;
        //                    panel4.Controls.Add(uc);
        //                    panel4.Controls["page_History"].BringToFront();
        //                }; break;
        //            case "page_Popular":
        //                {
        //                    page_Popular uc = new page_Popular();
        //                    uc.Dock = DockStyle.Fill;
        //                    panel4.Controls.Add(uc);
        //                    panel4.Controls["page_Popular"].BringToFront();
        //                }; break;
        //            case "page_Ratings":
        //                {
        //                    page_Ratings uc = new page_Ratings();
        //                    uc.Dock = DockStyle.Fill;
        //                    panel4.Controls.Add(uc);
        //                    panel4.Controls["page_Ratings"].BringToFront();
        //                }; break;
        //            case "page_Updating":
        //                {
        //                    page_Updating uc = new page_Updating();
        //                    uc.Dock = DockStyle.Fill;
        //                    panel4.Controls.Add(uc);
        //                    panel4.Controls["page_Updating"].BringToFront();
        //                }; break;
        //            case "page_Home":
        //                {
        //                    page_Home uc = new page_Home();
        //                    uc.Dock = DockStyle.Fill;
        //                    panel4.Controls.Add(uc);
        //                    panel4.Controls["page_Home"].BringToFront();
        //                }; break;
        //        }
        //    }));
        //}
    }
}
