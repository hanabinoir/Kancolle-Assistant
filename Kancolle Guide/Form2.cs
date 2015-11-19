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

namespace Kancolle_Guide
{
    public partial class Form2 : Form
    {
        private string num, shipname, init = "", max = "", op = "";
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public Form2()
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
            Form1 f1 = new Form1();
            f1.Refresh();
            conn.Close();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = "update ShipStats set " + 
                "Ship_Name = @shipname, HP = @hp, Firepower = @fp, " + 
                "Armor = @armor, Torpedo = @tpd, Evasion = @evas, " + 
                "AA = @aa, Aircraft = @airc, ASW = @asw, " + 
                "Speed = @spd, LOS = @los, Ship_Range = @range, Luck = @luck " +
                "where Ship_Name = @shipname and Ship_No = @num;" +
                "update ShipInfo set Ship_Name = @shipname, " + 
                "Ship_Class = @shipclass, Ship_Type = @shiptype " +
                "where Ship_Name = @shipname and Ship_No = @num;";

            string insert = "INSERT INTO `ShipStats` " + 
                "(`Ship_Name`, `Ship_No`, `HP`, `Firepower`, `Armor`, " + 
                "`Torpedo`, `Evasion`, `AA`, `Aircraft`, `ASW`, " + 
                "`Speed`, `LOS`, `Ship_Range`, `Luck`) " +
                "VALUES  (@shipname, @num, @hp, @fp, @armor, @tpd, " +
                "@evas, @aa, @airc, @asw, @spd, @los, @range, @luck);" +
                "INSERT INTO `ShipInfo` (`Ship_Name`, `Ship_No`, `Ship_Class`, `Ship_Type`) " +
                "VALUES (@shipname, @num, @shipclass, @shiptype)";

            shipname = txtName.Text;
            num = txtNum.Text;

            if(op == "UPDATE")
                cmd = new MySqlCommand(update, conn);
            else
                cmd = new MySqlCommand(insert, conn);

            cmd.Parameters.AddWithValue("@shipname", shipname);
            cmd.Parameters.AddWithValue("@hp", txtHP.Text);
            cmd.Parameters.AddWithValue("@fp", txtFpInit.Text + " (" + txtFpMax.Text + ")");
            cmd.Parameters.AddWithValue("@armor", txtArmorInit.Text + " (" + txtArmorMax.Text + ")");
            cmd.Parameters.AddWithValue("@tpd", txtTpdInit.Text + " (" + txtTpdMax.Text + ")");
            cmd.Parameters.AddWithValue("@evas", txtEvsInit.Text + " (" + txtEvsMax.Text + ")");
            cmd.Parameters.AddWithValue("@aa", txtAAInit.Text + " (" + txtAAMax.Text + ")");
            cmd.Parameters.AddWithValue("@airc", txtAircraft.Text);
            if(txtASWMax.Text != "")
                cmd.Parameters.AddWithValue("@asw", txtASWInit.Text + " (" + txtASWMax.Text + ")");
            else
                cmd.Parameters.AddWithValue("@asw", txtASWInit.Text);
            cmd.Parameters.AddWithValue("@spd", txtSpeed.Text);
            cmd.Parameters.AddWithValue("@los", txtLOSInit.Text + " (" + txtLOSMax.Text + ")");
            cmd.Parameters.AddWithValue("@range", txtRange.Text);
            cmd.Parameters.AddWithValue("@luck", txtLuckInit.Text + " (" + txtLuckMax.Text + ")");
            cmd.Parameters.AddWithValue("@num", int.Parse(num));
            cmd.Parameters.AddWithValue("@shipclass", txtClass.Text);
            cmd.Parameters.AddWithValue("@shiptype", txtType.Text);

            try
            {
                cmd.ExecuteNonQuery();
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

        public string SPEED { set { txtSpeed.Text = value; } }

        public string LOSinit { set { txtLOSInit.Text = value; } }
        public string LOSmax { set { txtLOSMax.Text = value; } }

        public string RANGE { set { txtRange.Text = value; } }

        public string LUCKinit { set { txtLuckInit.Text = value; } }
        public string LUCKmax { set { txtLuckMax.Text = value; } }

        //public string BUILDTIME { set { txtTime.Text = value; } }

        public string SHIP_NAME { set { txtName.Text = value; shipname = value; } }

        public string SHIPCLASS { set { txtClass.Text = value; } }

        public string SHIPTYPE { set { txtType.Text = value; } }

        public string NUM { set { txtNum.Text = value; num = value; } }

        public void AddImg(Image img)
        {
            btnImg.Image = img;
        }

        public string AddBtnTxt { set { btnImg.Text = value; } }

        public string OP { set { op = value; } }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*stats = new Statistics();
            txtHP.Text = stats.HP;

            MessageBox.Show(txtHP.Text + " " + stats.FIREPOWER);

            assignVal(stats.FIREPOWER);
            txtFpInit.Text = init;
            txtFpMax.Text = max;*/
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
