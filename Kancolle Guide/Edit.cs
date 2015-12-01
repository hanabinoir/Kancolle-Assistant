using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kancolle_Assistant
{
    public partial class frmEdit : Form
    {
        private string num, shipname, init = "", max = "", op = "";
        private MySqlConnection conn;
        private MySqlCommand cmd1, cmd2;

        public frmEdit()
        {
            InitializeComponent();
        }

        private void connection()
        {
            string connStr = "SERVER=ec2-52-20-54-9.compute-1.amazonaws.com; " +
                "DATABASE=f_user24; " +
                "UID=f_user24; " +
                "PASSWORD=f_user24;";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            frmHome f1 = new frmHome();
            if (op == "UPDATE")
                f1.reloadShips();
            else
                f1.reloadTypes();
            conn.Close();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateStats = "UPDATE `f_user24`.`ShipStats` SET " +
                "`Ship_Name`=@shipname, `Ship_No`=@num, `HP`=@hp, `Firepower`=@fp, " + 
                "`Armor`=@armor, `Torpedo`=@tpd, `Evasion`=@evas, `AA`=@aa, `Aircraft`=@airc, " + 
                "`ASW`=@asw, `Speed`=@spd, `LOS`=@los, `Ship_Range`=@range, `Luck`=@luck " + 
                "WHERE `Ship_Name`=@shipname and `Ship_No`=@num;";

            string updateInfo = "UPDATE `f_user24`.`ShipInfo` SET " + 
                "`Ship_Name`=@shipname, `Ship_No`=@num, `Ship_Class`=@shipclass, " + 
                "`Ship_Type`=@shiptype WHERE `Ship_Name`=@shipname and `Ship_No`=@num;";

            string insertStats = "INSERT INTO `ShipStats` " +
                "(`Ship_Name`, `Ship_No`, `HP`, `Firepower`, `Armor`, " +
                "`Torpedo`, `Evasion`, `AA`, `Aircraft`, `ASW`, " +
                "`Speed`, `LOS`, `Ship_Range`, `Luck`) " +
                "VALUES  (@shipname, @num, @hp, @fp, @armor, @tpd, " +
                "@evas, @aa, @airc, @asw, @spd, @los, @range, @luck);";
            string insertInfo = "INSERT INTO `ShipInfo` " + 
                "(`Ship_Name`, `Ship_No`, `Ship_Class`, `Ship_Type`) " +
                "VALUES (@shipname, @num, @shipclass, @shiptype);";

            shipname = txtName.Text;
            num = txtNum.Text;
            if (op == "UPDATE")
            {
                cmd1 = new MySqlCommand(updateStats, conn);
                cmd2 = new MySqlCommand(updateInfo, conn);
            }
            else
            {
                cmd1 = new MySqlCommand(insertStats, conn);
                cmd2 = new MySqlCommand(insertInfo, conn);
            }

            cmd1.Parameters.AddWithValue("@shipname", shipname);
            cmd2.Parameters.AddWithValue("@shipname", shipname);
            cmd1.Parameters.AddWithValue("@hp", txtHP.Text);
            cmd1.Parameters.AddWithValue("@fp", txtFpInit.Text + "(" + txtFpMax.Text + ")");
            cmd1.Parameters.AddWithValue("@armor", txtArmorInit.Text + "(" + txtArmorMax.Text + ")");
            if(txtTpdMax.Text != "")
                cmd1.Parameters.AddWithValue("@tpd", txtTpdInit.Text);
            else
                cmd1.Parameters.AddWithValue("@tpd", txtTpdInit.Text + "(" + txtTpdMax.Text + ")");
            cmd1.Parameters.AddWithValue("@evas", txtEvsInit.Text + "(" + txtEvsMax.Text + ")");
            cmd1.Parameters.AddWithValue("@aa", txtAAInit.Text + "(" + txtAAMax.Text + ")");
            cmd1.Parameters.AddWithValue("@airc", txtAircraft.Text);
            if(txtASWMax.Text != "")
                cmd1.Parameters.AddWithValue("@asw", txtASWInit.Text + "(" + txtASWMax.Text + ")");
            else
                cmd1.Parameters.AddWithValue("@asw", txtASWInit.Text);
            cmd1.Parameters.AddWithValue("@spd", SPEED);
            cmd1.Parameters.AddWithValue("@los", txtLOSInit.Text + "(" + txtLOSMax.Text + ")");
            cmd1.Parameters.AddWithValue("@range", RANGE);
            cmd1.Parameters.AddWithValue("@luck", txtLuckInit.Text + "(" + txtLuckMax.Text + ")");
            cmd1.Parameters.AddWithValue("@num", int.Parse(num));
            cmd2.Parameters.AddWithValue("@num", int.Parse(num));
            cmd2.Parameters.AddWithValue("@shipclass", txtClass.Text);
            cmd2.Parameters.AddWithValue("@shiptype", SHIPTYPE);

            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Statistics updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string HP { set { txtHP.Text = value; } }

        public string FPinit { set { txtFpInit.Text = value; } }
        public string FPmax { set { txtFpMax.Text = value; } }

        public string ARMORinit { set { txtArmorInit.Text = value; } }
        public string ARMORmax { set { txtArmorMax.Text = value; } }

        public string TPDinit { set { txtTpdInit.Text = value; } }
        public string TPDmax { set { txtTpdMax.Text = value; } }

        public string EVASinit { set { txtEvsInit.Text = value; } }
        public string EVASmax { set { txtEvsMax.Text = value; } }

        public string AAinit { set { txtAAInit.Text = value; } }
        public string AAmax { set { txtAAMax.Text = value; } }

        public string AIRCRAFT { set { txtAircraft.Text = value; } }

        public string ASWinit { set { txtASWInit.Text = value; } }
        public string ASWmax { set { txtASWMax.Text = value; } }

        public string SPEED
        {
            set
            {
                if (value != null)
                    cboSpeed.SelectedIndex = cboSpeed.Items.IndexOf(value);
            }
            get
            {
                if (cboSpeed.SelectedItem != null)
                    return cboSpeed.SelectedItem.ToString();
                else
                    return "";
            }
        }

        public string LOSinit { set { txtLOSInit.Text = value; } }
        public string LOSmax { set { txtLOSMax.Text = value; } }

        public string RANGE 
        { 
            set 
            {
                if (value != null)
                    cboRange.SelectedIndex = cboRange.Items.IndexOf(value); 
            }
            get
            {
                if (cboRange.SelectedItem != null)
                    return cboRange.SelectedItem.ToString();
                else
                    return "";
            }
        }

        public string LUCKinit { set { txtLuckInit.Text = value; } }
        public string LUCKmax { set { txtLuckMax.Text = value; } }

        //public string BUILDTIME { set { txtTime.Text = value; } }

        public string SHIP_NAME { set { txtName.Text = value; shipname = value; } }

        public string SHIPCLASS { set { txtClass.Text = value; } }

        public string SHIPTYPE 
        {
            set 
            { 
                if(value != null)
                    cboType.SelectedIndex = cboType.Items.IndexOf(value);
            }
            get
            {
                if (cboType.SelectedItem != null)
                    return cboType.SelectedItem.ToString();
                else
                    return "";
            }
        }

        public string NUM { set { txtNum.Text = value; num = value; } }

        public void AddImg(Image img)
        {
            btnImg.Image = img;
        }

        public string AddBtnTxt { set { btnImg.Text = value; } }

        public string OP { set { op = value; } }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void assignVal(string s)
        {
            int idxOpen = s.IndexOf('('), idxClosing = s.IndexOf(')');
            if (idxOpen > 0)
            {
                init = s.Substring(0, idxOpen);
                max = s.Substring(idxOpen + 1, idxClosing - idxOpen - 1);
            }
        }
    }
}
