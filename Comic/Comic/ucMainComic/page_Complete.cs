﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Comic
{
    public partial class page_Complete : UserControl
    {
        public string s;
        public page_Complete()
        {
            InitializeComponent();
        }
        public void LoadComic()
        {
            string sChuoiTruyVan = "EXEC dbo.LayStoreHoanThanh";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan);
            if (dt != null && dt.Rows.Count > 0) //Nếu datatable hợp lệ và có giá trị
            {
                for (int i = 0; i < dt.Rows.Count; i++) //Duyệt datatable và đưa vào list đối tượng NHANVIEN_DTO
                {
                    Panel pnl = new Panel();
                    pnl.Width = 130;
                    pnl.Height = 240;
                    Bunifu.Framework.UI.BunifuImageButton btnIMG = new Bunifu.Framework.UI.BunifuImageButton();
                    Bitmap bm = new Bitmap(dt.Rows[i]["img"].ToString());
                    btnIMG.Image = bm;
                    btnIMG.Width = 130;
                    btnIMG.Height = 200;
                    btnIMG.Tag = dt.Rows[i]["store_id"].ToString();
                    btnIMG.Click += new EventHandler(DynamicClick);
                    Panel pnlComic = new Panel();
                    btnIMG.BackColor = Color.White;
                    pnl.Controls.Add(btnIMG);
                    Label lbl = new Label();
                    lbl.AutoSize = false;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Width = 130;
                    lbl.Height = 40;
                    lbl.Text = dt.Rows[i]["store_name"].ToString();
                    lbl.Location = new Point(0, btnIMG.Height);
                    lbl.Font = new Font("Segou IU", 8, FontStyle.Bold);
                    pnl.Controls.Add(lbl);

                    fLayoutComplete.Controls.Add(pnl);
                }
            }
        }
        private void DynamicClick(object sender, EventArgs e)
        {
            s = Convert.ToString((sender as Bunifu.Framework.UI.BunifuImageButton).Tag);
            DetailsComic form = new DetailsComic(s);
            form.Show();
        }

        private void page_Complete_Load(object sender, EventArgs e)
        {
            LoadComic();
        }
    }
}
