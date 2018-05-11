namespace Comic
{
    partial class Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBackup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pComic = new System.Windows.Forms.PictureBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChapter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtView = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dgbb = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Store_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.store_link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.store_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_chapter = new System.Windows.Forms.DataGridViewImageColumn();
            this.num_chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_view = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_star = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateInsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pComic)).BeginInit();
            this.dgbb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Store_id,
            this.store_name,
            this.img,
            this.store_link,
            this.store_author,
            this.store_cat,
            this.image_chapter,
            this.num_chapter,
            this.store_status,
            this.store_update,
            this.store_view,
            this.store_content,
            this.store_star,
            this.DateInsert,
            this.DateUpLoad,
            this.DateDelete});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Crimson;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 493);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1399, 211);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.pComic);
            this.panel1.Controls.Add(this.txtContent);
            this.panel1.Controls.Add(this.txtUpdate);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtStar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtChapter);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtView);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLink);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 487);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(518, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 22);
            this.txtID.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(355, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 23);
            this.label12.TabIndex = 38;
            this.label12.Text = "ID:";
            // 
            // btnBackup
            // 
            this.btnBackup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBackup.BackColor = System.Drawing.Color.Crimson;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.BorderRadius = 0;
            this.btnBackup.ButtonText = "BACKUP";
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DisabledColor = System.Drawing.Color.Gray;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBackup.Iconimage = global::Comic.Properties.Resources.storing;
            this.btnBackup.Iconimage_right = null;
            this.btnBackup.Iconimage_right_Selected = null;
            this.btnBackup.Iconimage_Selected = null;
            this.btnBackup.IconMarginLeft = 0;
            this.btnBackup.IconMarginRight = 0;
            this.btnBackup.IconRightVisible = true;
            this.btnBackup.IconRightZoom = 0D;
            this.btnBackup.IconVisible = true;
            this.btnBackup.IconZoom = 90D;
            this.btnBackup.IsTab = false;
            this.btnBackup.Location = new System.Drawing.Point(1117, 338);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Normalcolor = System.Drawing.Color.Crimson;
            this.btnBackup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBackup.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBackup.selected = false;
            this.btnBackup.Size = new System.Drawing.Size(161, 55);
            this.btnBackup.TabIndex = 37;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Textcolor = System.Drawing.Color.White;
            this.btnBackup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pComic
            // 
            this.pComic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pComic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pComic.Location = new System.Drawing.Point(55, 23);
            this.pComic.Name = "pComic";
            this.pComic.Size = new System.Drawing.Size(254, 303);
            this.pComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pComic.TabIndex = 36;
            this.pComic.TabStop = false;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(904, 164);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(444, 162);
            this.txtContent.TabIndex = 35;
            this.txtContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(904, 16);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(254, 22);
            this.txtUpdate.TabIndex = 34;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(186, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 23);
            this.lblID.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(147, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "UPDATE";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = global::Comic.Properties.Resources.rotation;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(1117, 405);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.Crimson;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(161, 55);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::Comic.Properties.Resources.cart;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(948, 405);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Crimson;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(161, 55);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackColor = System.Drawing.Color.Crimson;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.ButtonText = "INSERT";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsert.Iconimage = global::Comic.Properties.Resources.atm;
            this.btnInsert.Iconimage_right = null;
            this.btnInsert.Iconimage_right_Selected = null;
            this.btnInsert.Iconimage_Selected = null;
            this.btnInsert.IconMarginLeft = 0;
            this.btnInsert.IconMarginRight = 0;
            this.btnInsert.IconRightVisible = true;
            this.btnInsert.IconRightZoom = 0D;
            this.btnInsert.IconVisible = true;
            this.btnInsert.IconZoom = 90D;
            this.btnInsert.IsTab = false;
            this.btnInsert.Location = new System.Drawing.Point(948, 338);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.Crimson;
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(161, 55);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtStar
            // 
            this.txtStar.Location = new System.Drawing.Point(904, 118);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(254, 22);
            this.txtStar.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(802, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Start:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(518, 355);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(254, 22);
            this.txtStatus.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Status:";
            // 
            // txtChapter
            // 
            this.txtChapter.Location = new System.Drawing.Point(518, 296);
            this.txtChapter.Name = "txtChapter";
            this.txtChapter.Size = new System.Drawing.Size(254, 22);
            this.txtChapter.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Chapter:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(802, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Content:";
            // 
            // txtView
            // 
            this.txtView.Location = new System.Drawing.Point(904, 69);
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(254, 22);
            this.txtView.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(802, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "View:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Updating:";
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(518, 217);
            this.txtCat.Multiline = true;
            this.txtCat.Name = "txtCat";
            this.txtCat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCat.Size = new System.Drawing.Size(254, 43);
            this.txtCat.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Category_Comic:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(518, 171);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(254, 22);
            this.txtAuthor.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Author:";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(518, 122);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(254, 22);
            this.txtLink.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Link:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(518, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 22);
            this.txtName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(107, 332);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(151, 36);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dgbb
            // 
            this.dgbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgbb.Controls.Add(this.pic);
            this.dgbb.Location = new System.Drawing.Point(597, 496);
            this.dgbb.Name = "dgbb";
            this.dgbb.Size = new System.Drawing.Size(198, 10);
            this.dgbb.TabIndex = 5;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.pic.Location = new System.Drawing.Point(0, -3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(129, 17);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(335, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 10);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 10);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Store_id
            // 
            this.Store_id.HeaderText = "ID";
            this.Store_id.Name = "Store_id";
            // 
            // store_name
            // 
            this.store_name.HeaderText = "Name";
            this.store_name.Name = "store_name";
            // 
            // img
            // 
            this.img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.img.HeaderText = "Image";
            this.img.Name = "img";
            this.img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.img.Width = 24;
            // 
            // store_link
            // 
            this.store_link.HeaderText = "Link";
            this.store_link.Name = "store_link";
            this.store_link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.store_link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // store_author
            // 
            this.store_author.HeaderText = "Author";
            this.store_author.Name = "store_author";
            // 
            // store_cat
            // 
            this.store_cat.HeaderText = "Category_Comic";
            this.store_cat.Name = "store_cat";
            // 
            // image_chapter
            // 
            this.image_chapter.HeaderText = "%chapter";
            this.image_chapter.Name = "image_chapter";
            this.image_chapter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image_chapter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.image_chapter.Width = 200;
            // 
            // num_chapter
            // 
            this.num_chapter.HeaderText = "chapter";
            this.num_chapter.Name = "num_chapter";
            // 
            // store_status
            // 
            this.store_status.HeaderText = "Status";
            this.store_status.Name = "store_status";
            // 
            // store_update
            // 
            this.store_update.HeaderText = "Updating";
            this.store_update.Name = "store_update";
            // 
            // store_view
            // 
            this.store_view.HeaderText = "View";
            this.store_view.Name = "store_view";
            // 
            // store_content
            // 
            this.store_content.HeaderText = "Content";
            this.store_content.Name = "store_content";
            // 
            // store_star
            // 
            this.store_star.HeaderText = "Star";
            this.store_star.Name = "store_star";
            // 
            // DateInsert
            // 
            this.DateInsert.HeaderText = "DateInsert";
            this.DateInsert.Name = "DateInsert";
            // 
            // DateUpLoad
            // 
            this.DateUpLoad.HeaderText = "DateUpLoad";
            this.DateUpLoad.Name = "DateUpLoad";
            // 
            // DateDelete
            // 
            this.DateDelete.HeaderText = "DateDelete";
            this.DateDelete.Name = "DateDelete";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgbb);
            this.Controls.Add(this.panel1);
            this.Name = "Store";
            this.Size = new System.Drawing.Size(1388, 713);
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pComic)).EndInit();
            this.dgbb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
       // private System.Windows.Forms.PictureBox pComic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Panel dgbb;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pComic;
        private Bunifu.Framework.UI.BunifuFlatButton btnBackup;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_name;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewLinkColumn store_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_cat;
        private System.Windows.Forms.DataGridViewImageColumn image_chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_star;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUpLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDelete;
    }
}
