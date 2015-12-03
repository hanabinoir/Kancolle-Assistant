namespace Kancolle_Assistant
{
    partial class frmOrdHist
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
            this.lstOrd = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstOrd
            // 
            this.lstOrd.Location = new System.Drawing.Point(12, 12);
            this.lstOrd.Name = "lstOrd";
            this.lstOrd.Size = new System.Drawing.Size(260, 237);
            this.lstOrd.TabIndex = 0;
            this.lstOrd.UseCompatibleStateImageBehavior = false;
            // 
            // frmOrdHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstOrd);
            this.Name = "frmOrdHist";
            this.Text = "Order History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdHist_FormClosing);
            this.Load += new System.EventHandler(this.OrdHist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstOrd;
    }
}