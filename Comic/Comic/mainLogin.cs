using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;

namespace Comic
{
    public partial class mainLogin : Form
    {
        public mainLogin()
        {
            InitializeComponent();
            txtEmail.ForeColor = Color.LightGray;
            txtEmail.Text = "Please Enter Name";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);

            txtPassword.ForeColor = Color.LightGray;
            txtPassword.Text = "Please Enter Password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
        }
        string role;
        private void txtEmail_MouseEnter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Username")
            {
                txtEmail.Text = "";

            }
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string sql = "EXEC dbo.DangNhap @userName , @passWord";

            DataTable dt = DataProvider.Instance.ExecuteQuery(sql, new object[] { txtEmail.Text, txtPassword.Text }); ;

            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lệ và có giá trị
            {
                for (int i = 0; i < dt.Rows.Count; i++) //Duyệt datatable và đưa vào list đối tượng NHANVIEN_DTO
                {
                    role = dt.Rows[i]["role"].ToString();
                    int temp_customer;
                    temp_customer = role.CompareTo("customer");
                    int temp_admin;
                    temp_admin = role.CompareTo("admin");
                    string sql1 = "EXEC dbo.UpdateDateTimeNow @userName";
                    DataTable dt1;
                    if (temp_customer == 0)
                    {
                        // string sql1 = string.Format("update user set lastLogin=getdate() where username={0}", dt.Rows[i]["username"].ToString());
                        
                         dt1 = DataProvider.Instance.ExecuteQuery(sql1, new object[] { dt.Rows[i]["username"].ToString() });
                        page_Home fHome = new page_Home(dt.Rows[i]["username"].ToString());
                        ReadComic fRead = new ReadComic(dt.Rows[i]["username"].ToString());
                        mainComic form1 = new mainComic(dt.Rows[i]["username"].ToString());
                        page_History fHistory = new page_History(dt.Rows[i]["username"].ToString());
                        page_Details fProfile = new page_Details(dt.Rows[i]["username"].ToString());
                        form1.Show();
                        this.Hide();
                    }
                    if (temp_admin == 0)
                    {
                        dt1 = DataProvider.Instance.ExecuteQuery(sql1, new object[] { dt.Rows[i]["username"].ToString() });
                        formAdmin form2 = new formAdmin();
                        form2.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                // lblWarning.Show();
                lblWarning.Text = "Username or Password is WRONG";
            }

        }


        private void mainLogin_Load(object sender, EventArgs e)
        {

        }



        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Please Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Please Enter Name")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Please Enter Name";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Please Enter Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }


        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Please Enter Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_MouseEnter_1(object sender, EventArgs e)
        {
            //txtPassword.Text = "";
            txtPassword.ForeColor = Color.LightGray;
        }

        private void txtEmail_MouseEnter_1(object sender, EventArgs e)
        {
            //txtEmail.Text = "";
            txtEmail.ForeColor = Color.LightGray;
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Please Enter Name";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            formRegister form = new formRegister();
            form.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            formFPass form = new formFPass();
            form.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
