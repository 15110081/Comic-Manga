using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUL;
namespace Comic.ucFormAdmin
{
    public partial class Subcontractor : UserControl
    {
        List<Chapter_DTO> lstChapterDTO;
        public Subcontractor()
        {
            InitializeComponent();
        }

        private void Subcontractor_Load(object sender, EventArgs e)
        {

            LoadBackupDelete();
            LoadComboBoxChapter();
        }
        //protected override void OnLoad(EventArgs e)
        //{

        //    dgvChapter.DataSource = lstChapterDTO;
        //}
        void LoadComboBoxChapter()
        {
            string sql = "EXEC LayToanBoStore";
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "[dbo].[store]";
            comboBox1.ValueMember = "store_name";
        }
        void LoadChapter(int trang)
        {
            lstChapterDTO = Chapter_BUL.LoadChapter();
            string sql = string.Format("select * from [dbo].[chapter]");
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            //dgvChapter.DataSource = dt;
            numericChapter.Minimum = 1;
            numericChapter.Maximum = LoadSoTrang(dt.Rows.Count);
            int trangSo = trang;
            int soDongNhanVien = 50;
            int skipRow = (trangSo - 1) * soDongNhanVien;
            List<Chapter_DTO> lstNhanVienPhanTrang = lstChapterDTO.Skip(skipRow).Take(soDongNhanVien).ToList();
            //Gán datasource cho control dgvHoSoNhanVien
           // dgvChapter.DataSource = typeof(List<Chapter_DTO>);
            dgvChapter.DataSource = lstNhanVienPhanTrang;
        }
        public void LoadImage()
        {
            string sql = string.Format("select * from [dbo].[image]");
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            dgvImage.DataSource = dt;
        }
        public void LoadAccount()
        {
            string sql = string.Format("select * from [dbo].[user]");
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            dgvAccount.DataSource = dt;
        }
        public void LoadBackupDelete()
        {
            string sql = string.Format("select * from [dbo].[store_backup_delete]");
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            dgvBackup.DataSource = dt;
        }
        int LoadSoTrang(int count)
        {
            int soDongHienThiTrenTrang = 50;
            int tongSoTrang = count / soDongHienThiTrenTrang;
            if (count % soDongHienThiTrenTrang != 0)
                tongSoTrang++;
            return tongSoTrang;
        }

        private void numericChapter_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            int trang = int.Parse(nud.Value.ToString());
            LoadChapter(trang);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from [dbo].[chapter] where chapter_name like '% {0}'",txtFindChapter.Text);
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            dgvChapter.DataSource = dt;
            
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from [dbo].[chapter] where chapter_name like '%{0}%'", txtName.Text);
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            dgvChapter.DataSource = dt;
        }

        private void btnLoadChapter_Click(object sender, EventArgs e)
        {
            LoadChapter(1);
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            LoadImage();        
        }

        private void btnLoadAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }


        private void btnDelBackup_Click(object sender, EventArgs e)
        {

        }

   

        private void dgvBackup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow dr = dgvBackup.Rows[e.RowIndex];
            string name = dr.Cells[1].Value + "";
            lblNAME.Text = name;
            //lblDATE.Text = dr.Cells[7].Value.ToString();
        }

        private void btnLoadBackupDEL_Click(object sender, EventArgs e)
        {
            LoadBackupDelete();
        }

        private void dgvChapter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvChapter.SelectedRows != null)
                {
                   int index = e.RowIndex;
                    var item0 = dgvChapter.Rows[index].Cells[0].Value;
                    var item1 = dgvChapter.Rows[index].Cells[1].Value;
                    var item2 = dgvChapter.Rows[index].Cells[2].Value;
                    var item3 = dgvChapter.Rows[index].Cells[3].Value;
                    var item4= dgvChapter.Rows[index].Cells[4].Value;
                    string sql = string.Format("select * from store where store_id='{0}'",item4);
                    DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
                    // Lấy ra dòng được chọn gán vào các control phía trên
                    txtID.Text = item0.ToString();
                    txtNameChapter.Text = item1.ToString();
                    txtDateChapter.Text = item2.ToString();
                    txtLinkChapter.Text = item3.ToString();
                    comboBox1.Text = dt.Rows[0]["store_name"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
