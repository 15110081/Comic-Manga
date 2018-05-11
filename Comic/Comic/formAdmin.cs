using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void btnStore_Click_1(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            btnStore.Textcolor = Color.Crimson;
            btnTreeView.Textcolor = Color.Black;
            store1.BringToFront();
        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            btnTreeView.Textcolor = Color.Crimson;
            btnStore.Textcolor = Color.Black;
            treeViewListView1.BringToFront();   
        }
        string strConn = @"Data Source=DESKTOP-PIBLKPK;Initial Catalog=truyentranh;Integrated Security=True";
        SqlConnection conn = null;
        void openConnection()
        {
            SqlConnection conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            SqlCommand cmdstore = new SqlCommand("select * from [dbo].[store]", conn);
            openConnection();
            //SqlDataReader readerstore = cmdstore.ExecuteReader();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
            btnStore.Textcolor = Color.Black;
            btnTreeView.Textcolor = Color.Black;
            bunifuFlatButton6.Textcolor = Color.Crimson;
            subcontractor1.BringToFront();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            mainLogin form = new mainLogin();
            form.Show();
            this.Hide();
        }
    }
}
