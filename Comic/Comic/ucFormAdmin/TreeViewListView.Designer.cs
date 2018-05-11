namespace Comic.ucFormAdmin
{
    partial class TreeViewListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvStore = new System.Windows.Forms.TreeView();
            this.pnltilte = new System.Windows.Forms.Panel();
            this.lblTilte = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvHISTORY = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.USERNAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.cbSao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTruyen = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnltilte.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHISTORY)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(59, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvStore);
            this.panel2.Controls.Add(this.pnltilte);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 713);
            this.panel2.TabIndex = 1;
            // 
            // tvStore
            // 
            this.tvStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStore.Location = new System.Drawing.Point(0, 48);
            this.tvStore.Name = "tvStore";
            this.tvStore.Size = new System.Drawing.Size(626, 665);
            this.tvStore.TabIndex = 1;
            // 
            // pnltilte
            // 
            this.pnltilte.BackColor = System.Drawing.Color.Crimson;
            this.pnltilte.Controls.Add(this.lblTilte);
            this.pnltilte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltilte.Location = new System.Drawing.Point(0, 0);
            this.pnltilte.Name = "pnltilte";
            this.pnltilte.Size = new System.Drawing.Size(626, 48);
            this.pnltilte.TabIndex = 0;
            // 
            // lblTilte
            // 
            this.lblTilte.AutoSize = true;
            this.lblTilte.BackColor = System.Drawing.Color.Crimson;
            this.lblTilte.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTilte.ForeColor = System.Drawing.Color.White;
            this.lblTilte.Location = new System.Drawing.Point(202, 3);
            this.lblTilte.Name = "lblTilte";
            this.lblTilte.Size = new System.Drawing.Size(214, 40);
            this.lblTilte.TabIndex = 0;
            this.lblTilte.Text = "HISTORY USER";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(626, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 713);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvHISTORY);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(602, 491);
            this.panel5.TabIndex = 6;
            // 
            // dgvHISTORY
            // 
            this.dgvHISTORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHISTORY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHISTORY.Location = new System.Drawing.Point(0, 0);
            this.dgvHISTORY.Name = "dgvHISTORY";
            this.dgvHISTORY.RowTemplate.Height = 24;
            this.dgvHISTORY.Size = new System.Drawing.Size(602, 491);
            this.dgvHISTORY.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 222);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(602, 491);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtTongTruyen);
            this.panel4.Controls.Add(this.cbSao);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbUserName);
            this.panel4.Controls.Add(this.USERNAME);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 222);
            this.panel4.TabIndex = 5;
            // 
            // cbUserName
            // 
            this.cbUserName.FormattingEnabled = true;
            this.cbUserName.Location = new System.Drawing.Point(185, 48);
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Size = new System.Drawing.Size(121, 24);
            this.cbUserName.TabIndex = 2;
            this.cbUserName.SelectedIndexChanged += new System.EventHandler(this.cbUserName_SelectedIndexChanged);
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.BackColor = System.Drawing.Color.White;
            this.USERNAME.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.Location = new System.Drawing.Point(40, 48);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(120, 28);
            this.USERNAME.TabIndex = 1;
            this.USERNAME.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "DATE";
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(459, 52);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(121, 24);
            this.cbDate.TabIndex = 4;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // cbSao
            // 
            this.cbSao.FormattingEnabled = true;
            this.cbSao.Location = new System.Drawing.Point(225, 120);
            this.cbSao.Name = "cbSao";
            this.cbSao.Size = new System.Drawing.Size(121, 24);
            this.cbSao.TabIndex = 6;
            this.cbSao.SelectedIndexChanged += new System.EventHandler(this.cbSao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "SỐ SAO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "TỔNG TRUYỆN";
            // 
            // txtTongTruyen
            // 
            this.txtTongTruyen.Location = new System.Drawing.Point(225, 187);
            this.txtTongTruyen.Name = "txtTongTruyen";
            this.txtTongTruyen.Size = new System.Drawing.Size(121, 22);
            this.txtTongTruyen.TabIndex = 8;
            // 
            // TreeViewListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TreeViewListView";
            this.Size = new System.Drawing.Size(1228, 771);
            this.Load += new System.EventHandler(this.TreeViewListView_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnltilte.ResumeLayout(false);
            this.pnltilte.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHISTORY)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvStore;
        private System.Windows.Forms.Panel pnltilte;
        private System.Windows.Forms.Label lblTilte;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvHISTORY;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbSao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTruyen;
    }
}
