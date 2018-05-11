using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;
using BUL;
using DAL;

namespace Comic
{
    public partial class page_Details : UserControl
    {
        string path = "";
        byte[] image = null;
        User_DTO userDTO;
        public static string userName;
        public page_Details()
        {
            InitializeComponent();
        }
        public page_Details(string s)
        {
            InitializeComponent();
            //this.userName = s;
            lblUserName.Text = s;
            userName = lblUserName.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtNick.Text = "";
            pComic.Image = null;
        }
        User_DTO CheckControl()
        {
            //Bước 1: Kiểm tra lỗi     
            int loi = 0;
            if (txtName.Text.Trim() == "")
            {
                loi++;
                txtName.BackColor = Color.Coral;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
            if (txtNick.Text.Trim() == "")
            {
                loi++;
                txtNick.BackColor = Color.Coral;
            }
            else
            {
                txtNick.BackColor = Color.White;
            }
            if (txtEmail.Text.Trim() == "")
            {
                loi++;
                txtEmail.BackColor = Color.Coral;
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
            if (pComic == null)
            {
                loi++;
                MessageBox.Show("Hãy chọn hình ảnh", "Thông báo");
            }

            if (txtAddress.Text.Trim() == "")
            {
                loi++;
                txtAddress.BackColor = Color.Coral;
            }
            else
            {
                txtAddress.BackColor = Color.White;
            }
            if ((!chkFemale.Checked && !chkMale.Checked) || (chkFemale.Checked && chkMale.Checked))
            {
                loi++;
            }
            if (loi != 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo");
                return null;
            }
            //Bước 2: Gán giá trị thuộc tính user
             userDTO = new User_DTO();
            userDTO.userName = userName;
            userDTO.fullName = txtName.Text;
            userDTO.nickName = txtNick.Text;
            userDTO.address = txtAddress.Text;
            userDTO.avatar = image;
            userDTO.birthDay = dateTimePicker1.Value;
            if (chkMale.Checked)
            {
                userDTO.sex = true;
            }
            if (chkFemale.Checked)
            {
                userDTO.sex = false;
            }
            return userDTO;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"Exec TruyVanProfile @username";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql, new object[] { userName });
            User_DTO user = CheckControl();
            //Bước 3: Insert vào bảng NHÂN VIÊN
            if (user != null)
            {
                if (user.avatar == null) user.avatar = (byte[])dt.Rows[0]["Avatar"];
                if (User_BUL.UpdateUser(user) == true) //Nó đã thực thi làm thay đổi CSDL 
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    LoadDetails();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Thông báo");
                }
            }
            //else
            //{

            //        if (User_BUL.ThemUser(user) == true) //Nó đã thực thi làm thay đổi CSDL 
            //    {
            //        //   LoadDataGridView();
            //        MessageBox.Show("Cập nhật thành công!", "Thông báo");
            //        //Reset();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Cập nhật không thành công!", "Thông báo");
            //    }
            //}


        }

        private void page_Details_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDetails();
            }catch(Exception ex) { }
        }
        void LoadDetails()
        {
            string sql = string.Format("EXEC TruyVanEmail @username");
            var dt = DataProvider.Instance.ExecuteScalar(sql, new object[] { userName });
            txtEmail.Text = dt.ToString();

            string sql1 = @"Exec TruyVanProfile @username";
            DataTable dt2 = DataProvider.Instance.ExecuteQuery(sql1, new object[] { userName });
            if (dt2 != null && dt2.Rows.Count > 0) //Nếu datatable hợp lệ và có giá trị
            {
                
                    txtName.Text = dt2.Rows[0]["FullName"].ToString();
                    txtAddress.Text = dt2.Rows[0]["Address"].ToString();

                    txtNick.Text = dt2.Rows[0]["Nickname"].ToString();
                    string t = dt2.Rows[0]["Sex"].ToString();
                    if (t == "True") chkMale.Checked = true;
                    else chkFemale.Checked = false;
                    dateTimePicker1.Value = Convert.ToDateTime(dt2.Rows[0]["Birthday"].ToString());
                    byte[] HinhAnh = (byte[])(dt2.Rows[0]["Avatar"]);
                    lblAge.Text = dt2.Rows[0]["Age"].ToString();
                    // byte[] toBytes = Encoding.ASCII.GetBytes(somestring);
                    pComic.Image = ByteToImage(HinhAnh);
               
            }
        }
    }
}
