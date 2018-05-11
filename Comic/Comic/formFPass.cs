using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic
{
    public partial class formFPass : Form
    {
        public formFPass()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string i1=null;
        string email=null;
        string sql = null;
        List<string> result = new List<string>();
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
               

                string info = @"Data Source=DESKTOP-RTBB5RM\SQLEXPRESS;Initial Catalog=testLogin;Integrated Security=True;MultipleActiveResultSets=true";
                if (conn == null)
                    conn = new SqlConnection(info);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                sql = "select * from [user] where email='"+txtEmail.Text+"'";
                cmd.CommandText = sql;
                cmd.Connection = conn;
                SqlDataReader sqlReader = cmd.ExecuteReader();

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count >= 1)
                {
                    if (sqlReader.Read())
                    {
                        i1 = "Username:" + sqlReader.GetString(0) + "-" + "Password:" + sqlReader.GetString(1) + "\n";
                    }

                }
                else
                {
                    MessageBox.Show("Email không hợp lệ");
                    Application.Restart();
                }
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("hiomca@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "FORGOT PASSWORD " + DateTime.Now.ToLongDateString();
                mail.Body = i1;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("hiomca@gmail.com", "Quycodaycot0");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Successfull");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
