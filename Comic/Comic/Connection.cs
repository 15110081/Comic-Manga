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
using DAL;
namespace Comic
{
    public partial class Connection : Form
    {
        DAL.DataProvider db = null;
        string may = "";
        string user = "";
        string pass = "";
        SqlConnection conn;
        SqlDataAdapter daDatabase = null;
        DataTable dtDatabase = null;
        public Connection()
        {
            InitializeComponent();
          //  button1.Enabled = false;
        }
        public static string conString1;
        public static string database;
        //public List<string> GetDatabaseList()
        //{
        //    List<string> list = new List<string>();

        //    // Open connection to the database
        //    string conString = @"Server=" + txt_id.Text.ToString() + "; User id=" + txt_name.Text.ToString() + "; Password=" + txt_pass.Text.ToString() + ";";

        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        con.Close();
        //        con.Open();

        //        // Set up a command with the given query and associate
        //        // this with the current connection.
        //        using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
        //        {
        //            using (IDataReader dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    list.Add(dr[0].ToString());
        //                }
        //            }
        //        }
        //        con.Close();
        //    }
        //    return list;

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //Khai báo các biến 
            string ipserver = null;
            string username = null;
            string password = null;
            //Gán các giá trị từ các combobox, textbox vào các biến đã khởi tạo
            ipserver = txt_id.Text;
            username = txt_name.Text;
            password = txt_pass.Text;
            //Các biến sau khi được gán giá trị sẽ được ghép thành chuỗi kết nối trong lớp DAL
            DAL.DataProvider.Instance.server = "Server =" + ipserver + ";";
            DAL.DataProvider.Instance.userId = "User Id=" + username + ";";
            DAL.DataProvider.Instance.Pass = "Password=" + password;
            DAL.DataProvider.Instance.database = "Initial Catalog=truyentranh;";
            if (DAL.DataProvider.Instance.checkconnect())
            {
                MessageBox.Show("Kết nối đến Server thành công");
                //comboBox.Enabled = true;
                load();
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến Server. Vui lòng kiểm tra lại UserName hoặc PassWord");
            }
        }
        bool i = false;
        private void load()
        {
            may = txt_id.Text;
            user = txt_name.Text;
            pass = txt_pass.Text;
            try

            {
                string strConnectionString =            // tạo chuỗi kết nối
                "Server =" + may + ";"                  // lấy id máy server
                + "User Id=" + user + ";"                    // tên đăng nhập vào server
                 + "Password=" + pass;                  // mật khẩu
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                //MessageBox.Show(                        // kết nối được xuất câu thông báo
                //     "ket noi dc"
                //     , "Thông báo",
                //     MessageBoxButtons.OK,
                //     MessageBoxIcon.Information);
                i = true;
                //button1.Enabled = true;
                //db.ipServer = may;
                //db.user= user;
                //db.password = pass;              

                daDatabase = new SqlDataAdapter(
                   "select * from master.sys.databases", conn);// chọn tất cả các database từ sever
                dtDatabase = new DataTable();
                dtDatabase.Clear();
                daDatabase.Fill(dtDatabase);                    // từ dataset đổ vào datatable
                conn.Close();
                //comboBox1.DataSource = dtDatabase;
               // comboBox1.DisplayMember = "name";
               // comboBox1.ValueMember = "name";
                this.Hide();
                mainLogin form2 = new mainLogin();
                form2.ShowDialog();
                
            }
            catch (SqlException)                                // kết nối bị lỗi xuất ra thông báo
            {
                MessageBox.Show(
                    "Không ket noi dc may tao bi hu r!!!"
                    , "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (i == true)
            //{
            //    database = comboBox1.SelectedValue.ToString();
            //    //conString1 = @"Server=" + txt_id.Text.ToString() + "; DataBase=" + database + "; User id=" + txt_name.Text.ToString() + "; Password=" + txt_pass.Text.ToString() + ";";
            //    DAL.DataProvider.Instance.database = "Initial Catalog=" + database + ";";
            //   // DAL.DataProvider.Instance.server = @"Server=" + txt_id.Text.ToString() + ";";
            //    this.Hide();
            //    mainLogin form2 = new mainLogin();
            //    form2.ShowDialog();
            //    this.Close();
            //}
            //i = true;

        }
    }
}
