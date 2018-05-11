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
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string info = @"Data Source=DESKTOP-RTBB5RM\SQLEXPRESS;Initial Catalog=truyentranh;Integrated Security=True";
                if (conn == null)
                    conn = new SqlConnection(info);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                string sql = "Insert into [user](username,password,email,role) " + "values (@username,@pass,@email,@role)"; 
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUser.Text;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPass.Text;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@role", SqlDbType.VarChar).Value = "customer";
                int ret=cmd.ExecuteNonQuery();
                if (ret > 0 && ValidateChildren(ValidationConstraints.Enabled)) MessageBox.Show("Đăng ký thành công");
                else MessageBox.Show("Đăng ký thất bại");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRe_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtRe.Text))
            {
                e.Cancel = true;
                txtRe.Focus();
                if(txtPass.Text!=txtRe.Text)
                errorProvider1.SetError(txtRe, "Your Repassword are not correct");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRe, null);
            }
        }
    }
}
