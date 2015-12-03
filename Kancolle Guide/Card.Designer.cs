namespace Kancolle_Assistant
{
    partial class frmCard
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
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(75, 12);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(100, 20);
            this.txtCardNo.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Card No. ";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(75, 38);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password: ";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCard.Location = new System.Drawing.Point(181, 15);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(0, 13);
            this.lblCard.TabIndex = 28;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPwd.Location = new System.Drawing.Point(181, 41);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(0, 13);
            this.lblPwd.TabIndex = 29;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(100, 72);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 107);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label6);
            this.Name = "frmCard";
            this.Text = "Card";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCard_FormClosing);
            this.Load += new System.EventHandler(this.frmCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnSubmit;
    }
}