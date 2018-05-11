namespace Comic
{
    partial class formAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTreeView = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider = new System.Windows.Forms.PictureBox();
            this.btnStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.store1 = new Comic.Store();
            this.treeViewListView1 = new Comic.ucFormAdmin.TreeViewListView();
            this.subcontractor1 = new Comic.ucFormAdmin.Subcontractor();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 58);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Form Manager Admin";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Crimson;
            this.bunifuImageButton1.Image = global::Comic.Properties.Resources.back;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.bunifuFlatButton6);
            this.panel2.Controls.Add(this.bunifuFlatButton5);
            this.panel2.Controls.Add(this.bunifuFlatButton4);
            this.panel2.Controls.Add(this.bunifuFlatButton3);
            this.panel2.Controls.Add(this.btnTreeView);
            this.panel2.Controls.Add(this.slider);
            this.panel2.Controls.Add(this.btnStore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 62);
            this.panel2.TabIndex = 1;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Subcontractor";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(194, 7);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(183, 43);
            this.bunifuFlatButton6.TabIndex = 6;
            this.bunifuFlatButton6.Text = "Subcontractor";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "All Store";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(767, 4);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(183, 43);
            this.bunifuFlatButton5.TabIndex = 5;
            this.bunifuFlatButton5.Text = "All Store";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "All Store";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(958, 4);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(183, 43);
            this.bunifuFlatButton4.TabIndex = 4;
            this.bunifuFlatButton4.Text = "All Store";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "All Store";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(576, 7);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(183, 43);
            this.bunifuFlatButton3.TabIndex = 3;
            this.bunifuFlatButton3.Text = "All Store";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTreeView
            // 
            this.btnTreeView.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnTreeView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTreeView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTreeView.BorderRadius = 0;
            this.btnTreeView.ButtonText = "TreeView";
            this.btnTreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreeView.DisabledColor = System.Drawing.Color.Gray;
            this.btnTreeView.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTreeView.Iconimage = null;
            this.btnTreeView.Iconimage_right = null;
            this.btnTreeView.Iconimage_right_Selected = null;
            this.btnTreeView.Iconimage_Selected = null;
            this.btnTreeView.IconMarginLeft = 0;
            this.btnTreeView.IconMarginRight = 0;
            this.btnTreeView.IconRightVisible = true;
            this.btnTreeView.IconRightZoom = 0D;
            this.btnTreeView.IconVisible = true;
            this.btnTreeView.IconZoom = 90D;
            this.btnTreeView.IsTab = false;
            this.btnTreeView.Location = new System.Drawing.Point(385, 7);
            this.btnTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTreeView.Name = "btnTreeView";
            this.btnTreeView.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnTreeView.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnTreeView.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.btnTreeView.selected = false;
            this.btnTreeView.Size = new System.Drawing.Size(183, 43);
            this.btnTreeView.TabIndex = 2;
            this.btnTreeView.Text = "TreeView";
            this.btnTreeView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTreeView.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTreeView.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeView.Click += new System.EventHandler(this.btnTreeView_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.LightCoral;
            this.slider.Location = new System.Drawing.Point(12, 57);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(168, 10);
            this.slider.TabIndex = 1;
            this.slider.TabStop = false;
            // 
            // btnStore
            // 
            this.btnStore.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnStore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStore.BorderRadius = 0;
            this.btnStore.ButtonText = "All Store";
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStore.DisabledColor = System.Drawing.Color.Gray;
            this.btnStore.ForeColor = System.Drawing.Color.Crimson;
            this.btnStore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStore.Iconimage = null;
            this.btnStore.Iconimage_right = null;
            this.btnStore.Iconimage_right_Selected = null;
            this.btnStore.Iconimage_Selected = null;
            this.btnStore.IconMarginLeft = 0;
            this.btnStore.IconMarginRight = 0;
            this.btnStore.IconRightVisible = true;
            this.btnStore.IconRightZoom = 0D;
            this.btnStore.IconVisible = true;
            this.btnStore.IconZoom = 90D;
            this.btnStore.IsTab = false;
            this.btnStore.Location = new System.Drawing.Point(3, 7);
            this.btnStore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStore.Name = "btnStore";
            this.btnStore.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnStore.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnStore.OnHoverTextColor = System.Drawing.Color.Crimson;
            this.btnStore.selected = false;
            this.btnStore.Size = new System.Drawing.Size(183, 43);
            this.btnStore.TabIndex = 0;
            this.btnStore.Text = "All Store";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStore.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStore.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.store1);
            this.panel3.Controls.Add(this.treeViewListView1);
            this.panel3.Controls.Add(this.subcontractor1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 780);
            this.panel3.TabIndex = 2;
            // 
            // store1
            // 
            this.store1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.store1.Location = new System.Drawing.Point(0, 0);
            this.store1.Name = "store1";
            this.store1.Size = new System.Drawing.Size(1400, 780);
            this.store1.TabIndex = 0;
            // 
            // treeViewListView1
            // 
            this.treeViewListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewListView1.Location = new System.Drawing.Point(0, 0);
            this.treeViewListView1.Name = "treeViewListView1";
            this.treeViewListView1.Size = new System.Drawing.Size(1400, 780);
            this.treeViewListView1.TabIndex = 1;
            // 
            // subcontractor1
            // 
            this.subcontractor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subcontractor1.Location = new System.Drawing.Point(0, 0);
            this.subcontractor1.Name = "subcontractor1";
            this.subcontractor1.Size = new System.Drawing.Size(1400, 780);
            this.subcontractor1.TabIndex = 2;
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAdmin";
            this.Load += new System.EventHandler(this.formAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnStore;
        private System.Windows.Forms.PictureBox slider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnTreeView;
        private System.Windows.Forms.Panel panel3;
        private Store store1;
        private ucFormAdmin.TreeViewListView treeViewListView1;
        private ucFormAdmin.Subcontractor subcontractor1;
    }
}