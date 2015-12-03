namespace Kancolle_Assistant
{
    partial class frmPwdReset
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
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwdChk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwdNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPwdOld = new System.Windows.Forms.Label();
            this.lblPwdNew = new System.Windows.Forms.Label();
            this.lblPwdChk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPwd2.Location = new System.Drawing.Point(218, 41);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(0, 13);
            this.lblPwd2.TabIndex = 21;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPwd.Location = new System.Drawing.Point(218, 15);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(0, 13);
            this.lblPwd.TabIndex = 20;
            // 
            // txtPwdChk
            // 
            this.txtPwdChk.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdChk.Location = new System.Drawing.Point(112, 64);
            this.txtPwdChk.Name = "txtPwdChk";
            this.txtPwdChk.PasswordChar = '*';
            this.txtPwdChk.Size = new System.Drawing.Size(100, 20);
            this.txtPwdChk.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm Password: ";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(112, 12);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 20);
            this.txtPwd.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Old Password: ";
            // 
            // txtPwdNew
            // 
            this.txtPwdNew.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdNew.Location = new System.Drawing.Point(112, 38);
            this.txtPwdNew.Name = "txtPwdNew";
            this.txtPwdNew.PasswordChar = '*';
            this.txtPwdNew.Size = new System.Drawing.Size(100, 20);
            this.txtPwdNew.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "New Password: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(137, 95);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPwdOld
            // 
            this.lblPwdOld.AutoSize = true;
            this.lblPwdOld.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPwdOld.Location = new System.Drawing.Point(224, 15);
            this.lblPwdOld.Name = "lblPwdOld";
            this.lblPwdOld.Size = new System.Drawing.Size(0, 13);
            this.lblPwdOld.TabIndex = 25;
            // 
            // lblPwdNew
            // 
            this.lblPwdNew.AutoSize = true;
            this.lblPwdNew.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPwdNew.Location = new System.Drawing.Point(224, 41);
            this.lblPwdNew.Name = "lblPwdNew";
            this.lblPwdNew.Size = new System.Drawing.Size(0, 13);
            this.lblPwdNew.TabIndex = 26;
            // 
            // lblPwdChk
            // 
            this.lblPwdChk.AutoSize = true;
            this.lblPwdChk.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPwdChk.Location = new System.Drawing.Point(224, 67);
            this.lblPwdChk.Name = "lblPwdChk";
            this.lblPwdChk.Size = new System.Drawing.Size(0, 13);
            this.lblPwdChk.TabIndex = 27;
            // 
            // frmPwdReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 130);
            this.Controls.Add(this.lblPwdChk);
            this.Controls.Add(this.lblPwdNew);
            this.Controls.Add(this.lblPwdOld);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPwdNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPwd2);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtPwdChk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Name = "frmPwdReset";
            this.Text = "Reset Passoword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPwdReset_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwdChk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwdNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPwdOld;
        private System.Windows.Forms.Label lblPwdNew;
        private System.Windows.Forms.Label lblPwdChk;
    }
}