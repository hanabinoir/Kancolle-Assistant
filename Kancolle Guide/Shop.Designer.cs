namespace Kancolle_Assistant
{
    partial class frmShop
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.colItem1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCons = new System.Windows.Forms.DataGridView();
            this.colItem2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvRecm = new System.Windows.Forms.DataGridView();
            this.colItem3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceRecmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRecmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSpecial = new System.Windows.Forms.DataGridView();
            this.colItem4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEffSpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceSpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtySpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecm)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecial)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 289);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resources";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRes
            // 
            this.dgvRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem1,
            this.colEffect,
            this.PriceRes,
            this.QtyRes});
            this.dgvRes.Location = new System.Drawing.Point(6, 6);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.Size = new System.Drawing.Size(446, 251);
            this.dgvRes.TabIndex = 0;
            // 
            // colItem1
            // 
            this.colItem1.HeaderText = "Item";
            this.colItem1.Name = "colItem1";
            this.colItem1.ReadOnly = true;
            this.colItem1.Width = 33;
            // 
            // colEffect
            // 
            this.colEffect.HeaderText = "Effect";
            this.colEffect.Name = "colEffect";
            this.colEffect.ReadOnly = true;
            this.colEffect.Width = 60;
            // 
            // PriceRes
            // 
            this.PriceRes.HeaderText = "Price";
            this.PriceRes.Name = "PriceRes";
            this.PriceRes.ReadOnly = true;
            this.PriceRes.Width = 56;
            // 
            // QtyRes
            // 
            this.QtyRes.HeaderText = "Quantity";
            this.QtyRes.Name = "QtyRes";
            this.QtyRes.Width = 71;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCons);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consumables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCons
            // 
            this.dgvCons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem2,
            this.dataGridViewTextBoxColumn1,
            this.PriceCons,
            this.QtyCons});
            this.dgvCons.Location = new System.Drawing.Point(6, 6);
            this.dgvCons.Name = "dgvCons";
            this.dgvCons.Size = new System.Drawing.Size(446, 251);
            this.dgvCons.TabIndex = 1;
            // 
            // colItem2
            // 
            this.colItem2.HeaderText = "Item";
            this.colItem2.Name = "colItem2";
            this.colItem2.ReadOnly = true;
            this.colItem2.Width = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Effect";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // PriceCons
            // 
            this.PriceCons.HeaderText = "Price";
            this.PriceCons.Name = "PriceCons";
            this.PriceCons.ReadOnly = true;
            this.PriceCons.Width = 56;
            // 
            // QtyCons
            // 
            this.QtyCons.HeaderText = "Quantity";
            this.QtyCons.Name = "QtyCons";
            this.QtyCons.Width = 71;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvRecm);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(458, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recommended";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvRecm
            // 
            this.dgvRecm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRecm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem3,
            this.dataGridViewTextBoxColumn4,
            this.PriceRecmd,
            this.QtyRecmd});
            this.dgvRecm.Location = new System.Drawing.Point(6, 6);
            this.dgvRecm.Name = "dgvRecm";
            this.dgvRecm.Size = new System.Drawing.Size(446, 254);
            this.dgvRecm.TabIndex = 1;
            // 
            // colItem3
            // 
            this.colItem3.HeaderText = "Item";
            this.colItem3.Name = "colItem3";
            this.colItem3.ReadOnly = true;
            this.colItem3.Width = 33;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Effect";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // PriceRecmd
            // 
            this.PriceRecmd.HeaderText = "Price";
            this.PriceRecmd.Name = "PriceRecmd";
            this.PriceRecmd.ReadOnly = true;
            this.PriceRecmd.Width = 56;
            // 
            // QtyRecmd
            // 
            this.QtyRecmd.HeaderText = "Quantity";
            this.QtyRecmd.Name = "QtyRecmd";
            this.QtyRecmd.Width = 71;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvSpecial);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(458, 263);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Special";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSpecial
            // 
            this.dgvSpecial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSpecial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem4,
            this.colEffSpecial,
            this.PriceSpecial,
            this.QtySpecial});
            this.dgvSpecial.Location = new System.Drawing.Point(6, 6);
            this.dgvSpecial.Name = "dgvSpecial";
            this.dgvSpecial.Size = new System.Drawing.Size(446, 254);
            this.dgvSpecial.TabIndex = 1;
            // 
            // colItem4
            // 
            this.colItem4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItem4.HeaderText = "Item";
            this.colItem4.Name = "colItem4";
            this.colItem4.ReadOnly = true;
            this.colItem4.Width = 33;
            // 
            // colEffSpecial
            // 
            this.colEffSpecial.HeaderText = "Effect";
            this.colEffSpecial.Name = "colEffSpecial";
            this.colEffSpecial.ReadOnly = true;
            // 
            // PriceSpecial
            // 
            this.PriceSpecial.HeaderText = "Price";
            this.PriceSpecial.Name = "PriceSpecial";
            this.PriceSpecial.ReadOnly = true;
            // 
            // QtySpecial
            // 
            this.QtySpecial.HeaderText = "Quantity";
            this.QtySpecial.Name = "QtySpecial";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 307);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(399, 307);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.Location = new System.Drawing.Point(318, 307);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(75, 23);
            this.btnGetPrice.TabIndex = 3;
            this.btnGetPrice.Text = "Get Price";
            this.btnGetPrice.UseVisualStyleBackColor = true;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(180, 312);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Total: ";
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 342);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnGetPrice);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmShop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecm)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.DataGridView dgvCons;
        private System.Windows.Forms.DataGridView dgvRecm;
        private System.Windows.Forms.DataGridView dgvSpecial;
        private System.Windows.Forms.DataGridViewImageColumn colItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRes;
        private System.Windows.Forms.DataGridViewImageColumn colItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyCons;
        private System.Windows.Forms.DataGridViewImageColumn colItem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceRecmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRecmd;
        private System.Windows.Forms.DataGridViewImageColumn colItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEffSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtySpecial;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}