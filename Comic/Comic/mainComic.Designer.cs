namespace Comic
{
    partial class mainComic
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.page_Home1 = new Comic.page_Home();
            this.page_Updating1 = new Comic.page_Updating();
            this.page_Ratings1 = new Comic.page_Ratings();
            this.page_Popular1 = new Comic.page_Popular();
            this.page_History1 = new Comic.page_History();
            this.page_Details1 = new Comic.page_Details();
            this.page_Complete1 = new Comic.page_Complete();
            this.page_DetailsComic1 = new Comic.ucMainComic.page_DetailsComic();
            this.sideleft = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPopular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnComplete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDetails = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSignOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdating = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRating = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel4.SuspendLayout();
            this.sideleft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(257, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 56);
            this.panel1.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Crimson;
            this.bunifuImageButton1.Image = global::Comic.Properties.Resources.menu_button_of_three_horizontal_lines;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(4, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 47);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.page_Home1);
            this.panel4.Controls.Add(this.page_Updating1);
            this.panel4.Controls.Add(this.page_Ratings1);
            this.panel4.Controls.Add(this.page_Popular1);
            this.panel4.Controls.Add(this.page_History1);
            this.panel4.Controls.Add(this.page_Details1);
            this.panel4.Controls.Add(this.page_Complete1);
            this.panel4.Controls.Add(this.page_DetailsComic1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(257, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(766, 625);
            this.panel4.TabIndex = 3;
            // 
            // page_Home1
            // 
            this.page_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Home1.Location = new System.Drawing.Point(0, 0);
            this.page_Home1.Name = "page_Home1";
            this.page_Home1.Size = new System.Drawing.Size(764, 623);
            this.page_Home1.TabIndex = 6;
            // 
            // page_Updating1
            // 
            this.page_Updating1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Updating1.Location = new System.Drawing.Point(0, 0);
            this.page_Updating1.Name = "page_Updating1";
            this.page_Updating1.Size = new System.Drawing.Size(764, 623);
            this.page_Updating1.TabIndex = 5;
            // 
            // page_Ratings1
            // 
            this.page_Ratings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Ratings1.Location = new System.Drawing.Point(0, 0);
            this.page_Ratings1.Name = "page_Ratings1";
            this.page_Ratings1.Size = new System.Drawing.Size(764, 623);
            this.page_Ratings1.TabIndex = 4;
            // 
            // page_Popular1
            // 
            this.page_Popular1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Popular1.Location = new System.Drawing.Point(0, 0);
            this.page_Popular1.Name = "page_Popular1";
            this.page_Popular1.Size = new System.Drawing.Size(764, 623);
            this.page_Popular1.TabIndex = 3;
            // 
            // page_History1
            // 
            this.page_History1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_History1.Location = new System.Drawing.Point(0, 0);
            this.page_History1.Name = "page_History1";
            this.page_History1.Size = new System.Drawing.Size(764, 623);
            this.page_History1.TabIndex = 2;
            // 
            // page_Details1
            // 
            this.page_Details1.BackColor = System.Drawing.Color.White;
            this.page_Details1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Details1.Location = new System.Drawing.Point(0, 0);
            this.page_Details1.Name = "page_Details1";
            this.page_Details1.Size = new System.Drawing.Size(764, 623);
            this.page_Details1.TabIndex = 1;
            // 
            // page_Complete1
            // 
            this.page_Complete1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Complete1.Location = new System.Drawing.Point(0, 0);
            this.page_Complete1.Name = "page_Complete1";
            this.page_Complete1.Size = new System.Drawing.Size(764, 623);
            this.page_Complete1.TabIndex = 0;
            // 
            // page_DetailsComic1
            // 
            this.page_DetailsComic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_DetailsComic1.Location = new System.Drawing.Point(0, 0);
            this.page_DetailsComic1.Name = "page_DetailsComic1";
            this.page_DetailsComic1.Size = new System.Drawing.Size(764, 623);
            this.page_DetailsComic1.TabIndex = 7;
            // 
            // sideleft
            // 
            this.sideleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.sideleft.Controls.Add(this.panel3);
            this.sideleft.Controls.Add(this.btnHome);
            this.sideleft.Controls.Add(this.btnPopular);
            this.sideleft.Controls.Add(this.btnComplete);
            this.sideleft.Controls.Add(this.btnHistory);
            this.sideleft.Controls.Add(this.btnDetails);
            this.sideleft.Controls.Add(this.btnSignOut);
            this.sideleft.Controls.Add(this.btnUpdating);
            this.sideleft.Controls.Add(this.btnRating);
            this.sideleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideleft.Location = new System.Drawing.Point(0, 0);
            this.sideleft.Name = "sideleft";
            this.sideleft.Size = new System.Drawing.Size(257, 681);
            this.sideleft.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.lblHi);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 56);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Comic.Properties.Resources.devil;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "  Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = global::Comic.Properties.Resources.house__2_;
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 90D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(1, 57);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(257, 59);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.Black;
            this.btnHome.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPopular
            // 
            this.btnPopular.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPopular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnPopular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopular.BorderRadius = 0;
            this.btnPopular.ButtonText = "Favorite";
            this.btnPopular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPopular.DisabledColor = System.Drawing.Color.Gray;
            this.btnPopular.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPopular.Iconimage = global::Comic.Properties.Resources.star;
            this.btnPopular.Iconimage_right = null;
            this.btnPopular.Iconimage_right_Selected = null;
            this.btnPopular.Iconimage_Selected = null;
            this.btnPopular.IconMarginLeft = 0;
            this.btnPopular.IconMarginRight = 0;
            this.btnPopular.IconRightVisible = true;
            this.btnPopular.IconRightZoom = 0D;
            this.btnPopular.IconVisible = true;
            this.btnPopular.IconZoom = 90D;
            this.btnPopular.IsTab = false;
            this.btnPopular.Location = new System.Drawing.Point(2, 191);
            this.btnPopular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnPopular.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPopular.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPopular.selected = false;
            this.btnPopular.Size = new System.Drawing.Size(257, 59);
            this.btnPopular.TabIndex = 2;
            this.btnPopular.Text = "Favorite";
            this.btnPopular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPopular.Textcolor = System.Drawing.Color.Black;
            this.btnPopular.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopular.Click += new System.EventHandler(this.btnPopular_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComplete.BorderRadius = 0;
            this.btnComplete.ButtonText = "Complete";
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.DisabledColor = System.Drawing.Color.Gray;
            this.btnComplete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnComplete.Iconimage = global::Comic.Properties.Resources.success;
            this.btnComplete.Iconimage_right = null;
            this.btnComplete.Iconimage_right_Selected = null;
            this.btnComplete.Iconimage_Selected = null;
            this.btnComplete.IconMarginLeft = 0;
            this.btnComplete.IconMarginRight = 0;
            this.btnComplete.IconRightVisible = true;
            this.btnComplete.IconRightZoom = 0D;
            this.btnComplete.IconVisible = true;
            this.btnComplete.IconZoom = 90D;
            this.btnComplete.IsTab = false;
            this.btnComplete.Location = new System.Drawing.Point(1, 398);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnComplete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnComplete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnComplete.selected = false;
            this.btnComplete.Size = new System.Drawing.Size(257, 59);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete";
            this.btnComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComplete.Textcolor = System.Drawing.Color.Black;
            this.btnComplete.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistory.BorderRadius = 0;
            this.btnHistory.ButtonText = "  History";
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistory.Iconimage = global::Comic.Properties.Resources.history;
            this.btnHistory.Iconimage_right = null;
            this.btnHistory.Iconimage_right_Selected = null;
            this.btnHistory.Iconimage_Selected = null;
            this.btnHistory.IconMarginLeft = 0;
            this.btnHistory.IconMarginRight = 0;
            this.btnHistory.IconRightVisible = true;
            this.btnHistory.IconRightZoom = 0D;
            this.btnHistory.IconVisible = true;
            this.btnHistory.IconZoom = 90D;
            this.btnHistory.IsTab = false;
            this.btnHistory.Location = new System.Drawing.Point(1, 124);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnHistory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHistory.selected = false;
            this.btnHistory.Size = new System.Drawing.Size(257, 59);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Text = "  History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHistory.Textcolor = System.Drawing.Color.Black;
            this.btnHistory.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.BorderRadius = 0;
            this.btnDetails.ButtonText = "Profile";
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetails.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetails.Iconimage = global::Comic.Properties.Resources.list;
            this.btnDetails.Iconimage_right = null;
            this.btnDetails.Iconimage_right_Selected = null;
            this.btnDetails.Iconimage_Selected = null;
            this.btnDetails.IconMarginLeft = 0;
            this.btnDetails.IconMarginRight = 0;
            this.btnDetails.IconRightVisible = true;
            this.btnDetails.IconRightZoom = 0D;
            this.btnDetails.IconVisible = true;
            this.btnDetails.IconZoom = 90D;
            this.btnDetails.IsTab = false;
            this.btnDetails.Location = new System.Drawing.Point(2, 258);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnDetails.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDetails.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetails.selected = false;
            this.btnDetails.Size = new System.Drawing.Size(257, 65);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Profile";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetails.Textcolor = System.Drawing.Color.Black;
            this.btnDetails.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.BorderRadius = 0;
            this.btnSignOut.ButtonText = "Sign Out";
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignOut.Iconimage = global::Comic.Properties.Resources.sign_out;
            this.btnSignOut.Iconimage_right = null;
            this.btnSignOut.Iconimage_right_Selected = null;
            this.btnSignOut.Iconimage_Selected = null;
            this.btnSignOut.IconMarginLeft = 0;
            this.btnSignOut.IconMarginRight = 0;
            this.btnSignOut.IconRightVisible = true;
            this.btnSignOut.IconRightZoom = 0D;
            this.btnSignOut.IconVisible = true;
            this.btnSignOut.IconZoom = 90D;
            this.btnSignOut.IsTab = false;
            this.btnSignOut.Location = new System.Drawing.Point(2, 532);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnSignOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSignOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSignOut.selected = false;
            this.btnSignOut.Size = new System.Drawing.Size(257, 59);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignOut.Textcolor = System.Drawing.Color.Black;
            this.btnSignOut.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnUpdating
            // 
            this.btnUpdating.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnUpdating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdating.BorderRadius = 0;
            this.btnUpdating.ButtonText = "Updating";
            this.btnUpdating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdating.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdating.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdating.Iconimage = global::Comic.Properties.Resources.rotate;
            this.btnUpdating.Iconimage_right = null;
            this.btnUpdating.Iconimage_right_Selected = null;
            this.btnUpdating.Iconimage_Selected = null;
            this.btnUpdating.IconMarginLeft = 0;
            this.btnUpdating.IconMarginRight = 0;
            this.btnUpdating.IconRightVisible = true;
            this.btnUpdating.IconRightZoom = 0D;
            this.btnUpdating.IconVisible = true;
            this.btnUpdating.IconZoom = 90D;
            this.btnUpdating.IsTab = false;
            this.btnUpdating.Location = new System.Drawing.Point(1, 331);
            this.btnUpdating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdating.Name = "btnUpdating";
            this.btnUpdating.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnUpdating.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdating.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdating.selected = false;
            this.btnUpdating.Size = new System.Drawing.Size(257, 59);
            this.btnUpdating.TabIndex = 5;
            this.btnUpdating.Text = "Updating";
            this.btnUpdating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdating.Textcolor = System.Drawing.Color.Black;
            this.btnUpdating.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdating.Click += new System.EventHandler(this.btnUpdating_Click);
            // 
            // btnRating
            // 
            this.btnRating.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRating.BorderRadius = 0;
            this.btnRating.ButtonText = "Ratings";
            this.btnRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRating.DisabledColor = System.Drawing.Color.Gray;
            this.btnRating.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRating.Iconimage = global::Comic.Properties.Resources.column;
            this.btnRating.Iconimage_right = null;
            this.btnRating.Iconimage_right_Selected = null;
            this.btnRating.Iconimage_Selected = null;
            this.btnRating.IconMarginLeft = 0;
            this.btnRating.IconMarginRight = 0;
            this.btnRating.IconRightVisible = true;
            this.btnRating.IconRightZoom = 0D;
            this.btnRating.IconVisible = true;
            this.btnRating.IconZoom = 90D;
            this.btnRating.IsTab = false;
            this.btnRating.Location = new System.Drawing.Point(2, 465);
            this.btnRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRating.Name = "btnRating";
            this.btnRating.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnRating.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRating.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRating.selected = false;
            this.btnRating.Size = new System.Drawing.Size(257, 59);
            this.btnRating.TabIndex = 7;
            this.btnRating.Text = "Ratings";
            this.btnRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRating.Textcolor = System.Drawing.Color.Black;
            this.btnRating.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(62, 17);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(38, 28);
            this.lblHi.TabIndex = 1;
            this.lblHi.Text = "Hi,";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(101, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 28);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Hi";
            // 
            // mainComic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sideleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainComic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainComic";
            this.Load += new System.EventHandler(this.mainComic_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.sideleft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnComplete;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetails;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdating;
        private Bunifu.Framework.UI.BunifuFlatButton btnRating;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistory;
        private Bunifu.Framework.UI.BunifuFlatButton btnPopular;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Panel sideleft;
        private System.Windows.Forms.Panel panel3;
        private page_Updating page_Updating1;
        private page_Ratings page_Ratings1;
        private page_Popular page_Popular1;
        private page_History page_History1;
        private page_Details page_Details1;
        private page_Complete page_Complete1;
        private page_Home page_Home1;
        private ucMainComic.page_DetailsComic page_DetailsComic1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHi;
    }
}