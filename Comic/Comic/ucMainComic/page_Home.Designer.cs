namespace Comic
{
    partial class page_Home
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
            this.fLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.fLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLayout
            // 
            this.fLayout.AutoScroll = true;
            this.fLayout.Controls.Add(this.txtUserName);
            this.fLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayout.Location = new System.Drawing.Point(0, 0);
            this.fLayout.Name = "fLayout";
            this.fLayout.Size = new System.Drawing.Size(1321, 733);
            this.fLayout.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(3, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Visible = false;
            // 
            // page_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fLayout);
            this.Name = "page_Home";
            this.Size = new System.Drawing.Size(1321, 733);
            this.Load += new System.EventHandler(this.page_Home_Load);
            this.fLayout.ResumeLayout(false);
            this.fLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLayout;
        private System.Windows.Forms.TextBox txtUserName;
    }
}
