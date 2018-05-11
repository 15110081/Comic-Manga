namespace Comic
{
    partial class page_History
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
            this.lblName = new System.Windows.Forms.Label();
            this.fLayOutHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(427, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "history";
            this.lblName.Visible = false;
            // 
            // fLayOutHistory
            // 
            this.fLayOutHistory.AutoScroll = true;
            this.fLayOutHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayOutHistory.Location = new System.Drawing.Point(0, 0);
            this.fLayOutHistory.Name = "fLayOutHistory";
            this.fLayOutHistory.Size = new System.Drawing.Size(903, 625);
            this.fLayOutHistory.TabIndex = 1;
            // 
            // page_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.fLayOutHistory);
            this.Name = "page_History";
            this.Size = new System.Drawing.Size(903, 625);
            this.Load += new System.EventHandler(this.page_History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel fLayOutHistory;
    }
}
