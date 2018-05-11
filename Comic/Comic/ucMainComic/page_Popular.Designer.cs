namespace Comic
{
    partial class page_Popular
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
            this.fLayoutPopular = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fLayoutPopular
            // 
            this.fLayoutPopular.AutoScroll = true;
            this.fLayoutPopular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutPopular.Location = new System.Drawing.Point(0, 0);
            this.fLayoutPopular.Name = "fLayoutPopular";
            this.fLayoutPopular.Size = new System.Drawing.Size(980, 597);
            this.fLayoutPopular.TabIndex = 0;
            // 
            // page_Popular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fLayoutPopular);
            this.Name = "page_Popular";
            this.Size = new System.Drawing.Size(980, 597);
            this.Load += new System.EventHandler(this.page_Popular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fLayoutPopular;
    }
}
