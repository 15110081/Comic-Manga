namespace Comic
{
    partial class Form1
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
            this.linkchapterid = new System.Windows.Forms.LinkLabel();
            this.linkchapter = new System.Windows.Forms.LinkLabel();
            this.txtchapterpath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.linkpage = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rigthButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.imgComic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rigthButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkchapterid
            // 
            this.linkchapterid.AutoSize = true;
            this.linkchapterid.Location = new System.Drawing.Point(88, 10);
            this.linkchapterid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkchapterid.Name = "linkchapterid";
            this.linkchapterid.Size = new System.Drawing.Size(55, 13);
            this.linkchapterid.TabIndex = 5;
            this.linkchapterid.TabStop = true;
            this.linkchapterid.Text = "linkLabel1";
            this.linkchapterid.Visible = false;
            // 
            // linkchapter
            // 
            this.linkchapter.AutoSize = true;
            this.linkchapter.Location = new System.Drawing.Point(876, 0);
            this.linkchapter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkchapter.Name = "linkchapter";
            this.linkchapter.Size = new System.Drawing.Size(55, 13);
            this.linkchapter.TabIndex = 7;
            this.linkchapter.TabStop = true;
            this.linkchapter.Text = "linkLabel1";
            this.linkchapter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkchapter_LinkClicked);
            // 
            // txtchapterpath
            // 
            this.txtchapterpath.Location = new System.Drawing.Point(9, 10);
            this.txtchapterpath.Margin = new System.Windows.Forms.Padding(2);
            this.txtchapterpath.Name = "txtchapterpath";
            this.txtchapterpath.Size = new System.Drawing.Size(76, 20);
            this.txtchapterpath.TabIndex = 8;
            this.txtchapterpath.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtStoreID);
            this.panel1.Controls.Add(this.linkchapter);
            this.panel1.Controls.Add(this.linkpage);
            this.panel1.Controls.Add(this.linkchapterid);
            this.panel1.Controls.Add(this.txtchapterpath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 59);
            this.panel1.TabIndex = 9;
            // 
            // txtStoreID
            // 
            this.txtStoreID.Location = new System.Drawing.Point(10, 33);
            this.txtStoreID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(76, 20);
            this.txtStoreID.TabIndex = 10;
            this.txtStoreID.Visible = false;
            // 
            // linkpage
            // 
            this.linkpage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.linkpage.Enabled = false;
            this.linkpage.Location = new System.Drawing.Point(621, 35);
            this.linkpage.Margin = new System.Windows.Forms.Padding(2);
            this.linkpage.Name = "linkpage";
            this.linkpage.Size = new System.Drawing.Size(19, 20);
            this.linkpage.TabIndex = 9;
            this.linkpage.TextChanged += new System.EventHandler(this.linkpage_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 59);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1249, 691);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.rigthButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1195, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(54, 691);
            this.panel4.TabIndex = 12;
            // 
            // rigthButton
            // 
            this.rigthButton.BackColor = System.Drawing.Color.White;
            this.rigthButton.Image = global::Comic.Properties.Resources.right_chevron;
            this.rigthButton.ImageActive = null;
            this.rigthButton.Location = new System.Drawing.Point(12, 249);
            this.rigthButton.Margin = new System.Windows.Forms.Padding(2);
            this.rigthButton.Name = "rigthButton";
            this.rigthButton.Size = new System.Drawing.Size(35, 39);
            this.rigthButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rigthButton.TabIndex = 3;
            this.rigthButton.TabStop = false;
            this.rigthButton.Zoom = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 691);
            this.panel3.TabIndex = 11;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = global::Comic.Properties.Resources.left_chevron;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(11, 249);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 39);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // imgComic
            // 
            this.imgComic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgComic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgComic.ErrorImage = global::Comic.Properties.Resources.browser;
            this.imgComic.Image = global::Comic.Properties.Resources.browser;
            this.imgComic.InitialImage = null;
            this.imgComic.Location = new System.Drawing.Point(221, -5);
            this.imgComic.Margin = new System.Windows.Forms.Padding(2);
            this.imgComic.Name = "imgComic";
            this.imgComic.Size = new System.Drawing.Size(750, 1000);
            this.imgComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgComic.TabIndex = 0;
            this.imgComic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.imgComic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 691);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1249, 750);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rigthButton)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkchapterid;
        private System.Windows.Forms.LinkLabel linkchapter;
        private System.Windows.Forms.TextBox txtchapterpath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox linkpage;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton rigthButton;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox imgComic;
        private System.Windows.Forms.Panel panel2;
    }
}

