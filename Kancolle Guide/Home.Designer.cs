﻿namespace Kancolle_Assistant
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.dgvType = new System.Windows.Forms.DataGridView();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.dgvShip = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblAircraft = new System.Windows.Forms.Label();
            this.lblLuck = new System.Windows.Forms.Label();
            this.lblLOS = new System.Windows.Forms.Label();
            this.lblASW = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAA = new System.Windows.Forms.Label();
            this.lblTorpedo = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblEvasion = new System.Windows.Forms.Label();
            this.lblFirpower = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstRcp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnChkItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShip)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvType
            // 
            this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvType.Location = new System.Drawing.Point(12, 35);
            this.dgvType.Name = "dgvType";
            this.dgvType.Size = new System.Drawing.Size(130, 150);
            this.dgvType.TabIndex = 0;
            this.dgvType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvType_CellClick);
            // 
            // dgvClass
            // 
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClass.Location = new System.Drawing.Point(151, 35);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.Size = new System.Drawing.Size(130, 150);
            this.dgvClass.TabIndex = 1;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);
            // 
            // dgvShip
            // 
            this.dgvShip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShip.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvShip.Location = new System.Drawing.Point(287, 35);
            this.dgvShip.Name = "dgvShip";
            this.dgvShip.Size = new System.Drawing.Size(130, 150);
            this.dgvShip.TabIndex = 2;
            this.dgvShip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShip_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Firepower";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Torpedo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Armor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "AA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Evasion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ASW";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Aircraft";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "LOS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Speed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Luck";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Range";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 191);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 191);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblRange);
            this.tabPage1.Controls.Add(this.lblSpeed);
            this.tabPage1.Controls.Add(this.lblAircraft);
            this.tabPage1.Controls.Add(this.lblLuck);
            this.tabPage1.Controls.Add(this.lblLOS);
            this.tabPage1.Controls.Add(this.lblASW);
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lblAA);
            this.tabPage1.Controls.Add(this.lblTorpedo);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.lblHP);
            this.tabPage1.Controls.Add(this.lblArmor);
            this.tabPage1.Controls.Add(this.lblEvasion);
            this.tabPage1.Controls.Add(this.lblFirpower);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 165);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(59, 139);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(10, 13);
            this.lblRange.TabIndex = 47;
            this.lblRange.Text = "-";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(59, 113);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(10, 13);
            this.lblSpeed.TabIndex = 46;
            this.lblSpeed.Text = "-";
            // 
            // lblAircraft
            // 
            this.lblAircraft.AutoSize = true;
            this.lblAircraft.Location = new System.Drawing.Point(59, 87);
            this.lblAircraft.Name = "lblAircraft";
            this.lblAircraft.Size = new System.Drawing.Size(10, 13);
            this.lblAircraft.TabIndex = 45;
            this.lblAircraft.Text = "-";
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.Location = new System.Drawing.Point(188, 139);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(10, 13);
            this.lblLuck.TabIndex = 44;
            this.lblLuck.Text = "-";
            // 
            // lblLOS
            // 
            this.lblLOS.AutoSize = true;
            this.lblLOS.Location = new System.Drawing.Point(188, 113);
            this.lblLOS.Name = "lblLOS";
            this.lblLOS.Size = new System.Drawing.Size(10, 13);
            this.lblLOS.TabIndex = 43;
            this.lblLOS.Text = "-";
            // 
            // lblASW
            // 
            this.lblASW.AutoSize = true;
            this.lblASW.Location = new System.Drawing.Point(188, 87);
            this.lblASW.Name = "lblASW";
            this.lblASW.Size = new System.Drawing.Size(10, 13);
            this.lblASW.TabIndex = 42;
            this.lblASW.Text = "-";
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(367, 36);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(24, 24);
            this.btnDel.TabIndex = 34;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(367, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Location = new System.Drawing.Point(188, 61);
            this.lblAA.Name = "lblAA";
            this.lblAA.Size = new System.Drawing.Size(10, 13);
            this.lblAA.TabIndex = 41;
            this.lblAA.Text = "-";
            // 
            // lblTorpedo
            // 
            this.lblTorpedo.AutoSize = true;
            this.lblTorpedo.Location = new System.Drawing.Point(188, 35);
            this.lblTorpedo.Name = "lblTorpedo";
            this.lblTorpedo.Size = new System.Drawing.Size(10, 13);
            this.lblTorpedo.TabIndex = 40;
            this.lblTorpedo.Text = "-";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Kancolle_Assistant.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(367, 133);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 24);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(59, 9);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(10, 13);
            this.lblHP.TabIndex = 39;
            this.lblHP.Text = "-";
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Location = new System.Drawing.Point(59, 35);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(10, 13);
            this.lblArmor.TabIndex = 38;
            this.lblArmor.Text = "-";
            // 
            // lblEvasion
            // 
            this.lblEvasion.AutoSize = true;
            this.lblEvasion.Location = new System.Drawing.Point(59, 61);
            this.lblEvasion.Name = "lblEvasion";
            this.lblEvasion.Size = new System.Drawing.Size(10, 13);
            this.lblEvasion.TabIndex = 37;
            this.lblEvasion.Text = "-";
            // 
            // lblFirpower
            // 
            this.lblFirpower.AutoSize = true;
            this.lblFirpower.Location = new System.Drawing.Point(188, 9);
            this.lblFirpower.Name = "lblFirpower";
            this.lblFirpower.Size = new System.Drawing.Size(10, 13);
            this.lblFirpower.TabIndex = 36;
            this.lblFirpower.Text = "-";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstRcp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 165);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recipe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstRcp
            // 
            this.lstRcp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstRcp.GridLines = true;
            this.lstRcp.Location = new System.Drawing.Point(6, 6);
            this.lstRcp.Name = "lstRcp";
            this.lstRcp.Size = new System.Drawing.Size(385, 153);
            this.lstRcp.SmallImageList = this.imgLst;
            this.lstRcp.TabIndex = 0;
            this.lstRcp.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "Fuel.png");
            this.imgLst.Images.SetKeyName(1, "Ammunition.png");
            this.imgLst.Images.SetKeyName(2, "Steel.png");
            this.imgLst.Images.SetKeyName(3, "Bauxite.png");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(536, 318);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 24);
            this.lblName.TabIndex = 49;
            this.lblName.Tag = "-";
            this.lblName.Text = "Name";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(537, 350);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(29, 16);
            this.lblNo.TabIndex = 50;
            this.lblNo.Text = "No.";
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(462, 12);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(218, 300);
            this.btnImg.TabIndex = 3;
            this.btnImg.UseVisualStyleBackColor = true;
            // 
            // btnChkItems
            // 
            this.btnChkItems.Location = new System.Drawing.Point(12, 6);
            this.btnChkItems.Name = "btnChkItems";
            this.btnChkItems.Size = new System.Drawing.Size(75, 23);
            this.btnChkItems.TabIndex = 51;
            this.btnChkItems.Text = "Check Items";
            this.btnChkItems.UseVisualStyleBackColor = true;
            this.btnChkItems.Click += new System.EventHandler(this.btnChkItems_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 389);
            this.Controls.Add(this.btnChkItems);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.dgvShip);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.dgvType);
            this.Name = "frmHome";
            this.Text = "Kancolle Guide";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShip)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvType;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridView dgvShip;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblAircraft;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.Label lblLOS;
        private System.Windows.Forms.Label lblASW;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.Label lblTorpedo;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblEvasion;
        private System.Windows.Forms.Label lblFirpower;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.ListView lstRcp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnChkItems;
    }
}

