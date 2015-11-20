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
    public partial class Form1 : Form
    {
        private string init = "", max = "", shiptype = "", shipclass = "";
        private string ShipNo = "", HP = "", Firepower = "", Armor = "", 
            Torpedo = "", Evasion = "", AA = "", Aircraft = "", 
            ASW = "", Speed = "", LOS = "", Range = "", Luck = "";
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        Statistics stats;

        public Form1()
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
                        MessageBox.Show("Can Not connect to server.");
                        break;
                    case 1:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }

        private void loadType()
        {
            string findClass = "select Ship_Type from ShipInfo " + 
                "group by Ship_Type " +
                "order by Ship_Type";

            Form2 f2 = new Form2();
            dgvType.Rows.Clear();
            cmd = new MySqlCommand(findClass, conn);
            reader = cmd.ExecuteReader();
            dgvType.ColumnCount = 1;
            dgvType.Columns[0].Name = "Type";
            while (reader.Read())
                dgvType.Rows.Add(reader.GetString(0));
            reader.Close();
        }

        private void loadClass(string type)
        {
            string findClass = "select Ship_Class from ShipInfo " +
                "where Ship_Type = '" + type + "' " +
                "group by Ship_Class " +
                "order by Ship_No";

            shiptype = type;
            dgvClass.Rows.Clear();
            cmd = new MySqlCommand(findClass, conn);
            reader = cmd.ExecuteReader();
            dgvClass.ColumnCount = 1;
            dgvClass.Columns[0].Name = "Class";
            while (reader.Read())
                dgvClass.Rows.Add(reader.GetString(0));
            reader.Close();
        }

        private void loadShip(string Class)
        {
            string findShip = "select Ship_Name from ShipInfo " +
                "where Ship_Class = '" + Class + "'" + 
                "order by Ship_No";

            shipclass = Class;
            dgvShip.Rows.Clear();
            cmd = new MySqlCommand(findShip, conn);
            reader = cmd.ExecuteReader();
            dgvShip.ColumnCount = 1;
            dgvShip.Columns[0].Name = "Ship";
            while (reader.Read())
                dgvShip.Rows.Add(reader.GetString(0));
            reader.Close();
        }

        public void defStats(string ship)
        {
            string findStats = "select * from ShipStats " +
                "where Ship_Name = '" + ship + "';";

            cmd = new MySqlCommand(findStats, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ShipNo = reader.GetInt32(1).ToString("000");
                HP = reader.GetString(2);
                Firepower = reader.GetString(3);
                Armor = reader.GetString(4);
                Torpedo = reader.GetString(5);
                Evasion = reader.GetString(6);
                AA = reader.GetString(7);
                Aircraft = reader.GetString(8);
                ASW = reader.GetString(9);
                Speed = reader.GetString(10);
                LOS = reader.GetString(11);
                Range = reader.GetString(12);
                Luck = reader.GetString(13);
            }
            reader.Close();
        }

        public void loadStats(string ship)
        {
            lblHP.Text = HP;
            lblFirpower.Text = Firepower;
            lblArmor.Text = Armor;
            lblTorpedo.Text = Torpedo;
            lblEvasion.Text = Evasion;
            lblAA.Text = AA;
            lblAircraft.Text = Aircraft;
            lblASW.Text = ASW;
            lblSpeed.Text = Speed;
            lblLOS.Text = LOS;
            lblRange.Text = Range;
            lblLuck.Text = Luck;
            lblNo.Text = "No. " + ShipNo;
            lblName.Text = ship;
            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + ShipNo);
            btnImg.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstRcp.View = View.Details;
            lstRcp.GridLines = true;
            lstRcp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstRcp.Columns[0].ImageIndex = 0;
            lstRcp.Columns[1].ImageIndex = 1;
            lstRcp.Columns[2].ImageIndex = 2;
            lstRcp.Columns[3].ImageIndex = 3;

            string[] row1 = { "1", "2", "3", "4"};
            string[] row2 = { "5", "6", "7", "8" };
            ListViewItem item1 = new ListViewItem(row1);
            ListViewItem item2 = new ListViewItem(row2);
            lstRcp.Items.Add(item1);
            lstRcp.Items.Add(item2);

            connection();

            if (conn != null)
            {
                loadType();
                loadClass("Battleship");
                loadShip("Nagato");
            }
            else
                MessageBox.Show("Try to connect.");

            defStats("Nagato");
            loadStats("Nagato");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            stats = new Statistics();
            stats.HP = lblHP.Text;
            stats.FIREPOWER = lblFirpower.Text;
            stats.ARMOR = lblArmor.Text;
            stats.TORPEDO = lblTorpedo.Text;
            stats.EVASION = lblEvasion.Text;
            stats.AA = lblAA.Text;
            stats.AIRCRAFT = lblAircraft.Text;
            stats.ASW = lblASW.Text;
            stats.SPEED = lblSpeed.Text;
            stats.LOS = lblLOS.Text;
            stats.RANGE = lblRange.Text;
            stats.LUCK = lblLuck.Text;
            //stats.BUILDTIME = lblTime.Text;
            stats.SHIP_NAME = lblName.Text;
            stats.NUM = ShipNo;
            stats.SHIPTYPE = shiptype;
            stats.SHIPCLASS = shipclass;

            Form2 f2 = new Form2();
            f2.Show();
            f2.OP = "UPDATE";

            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + stats.NUM);
            f2.AddImg(img);

            f2.HP = stats.HP;
            f2.AIRCRAFT = stats.AIRCRAFT;
            f2.SPEED = stats.SPEED;
            f2.RANGE = stats.RANGE;
            //f2.BUILDTIME = stats.BUILDTIME;

            assignVal(stats.FIREPOWER);
            f2.FPinit = init;
            f2.FPmax = max;

            assignVal(stats.ARMOR);
            f2.ARMORinit = init;
            f2.ARMORmax = max;

            assignVal(stats.TORPEDO);
            f2.TPDinit = init;
            f2.TPDmax = max;

            assignVal(stats.EVASION);
            f2.EVASinit = init;
            f2.EVASmax = max;

            assignVal(stats.AA);
            f2.AAinit = init;
            f2.AAmax = max;

            assignVal(stats.ASW);
            f2.ASWinit = init;
            f2.ASWmax = max;

            assignVal(stats.LOS);
            f2.LOSinit = init;
            f2.LOSmax = max;

            assignVal(stats.LUCK);
            f2.LUCKinit = init;
            f2.LUCKmax = max;

            f2.SHIP_NAME = stats.SHIP_NAME;
            f2.NUM = stats.NUM;
            f2.SHIPCLASS = stats.SHIPCLASS;
            f2.SHIPTYPE = stats.SHIPTYPE;
        }

        private void assignVal(string s)
        {
            int idxOpen = s.IndexOf('('), idxClosing = s.IndexOf(')');
            if (idxOpen > 0)
            {
                init = s.Substring(0, idxOpen);
                max = s.Substring(idxOpen + 1, idxClosing - idxOpen - 1);
            }
            else
            {
                init = s;
                max = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void dgvType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = dgvType.SelectedCells[0].Value.ToString();
            loadClass(type);
            string Class = dgvClass.SelectedCells[0].Value.ToString();
            loadShip(Class);
            string ship = dgvShip.SelectedCells[0].Value.ToString();
            defStats(ship);
            loadStats(ship);
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Class = dgvClass.SelectedCells[0].Value.ToString();
            loadShip(Class);
            string ship = dgvShip.SelectedCells[0].Value.ToString();
            defStats(ship);
            loadStats(ship);
        }

        private void dgvShip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ship = dgvShip.SelectedCells[0].Value.ToString();
            defStats(ship);
            loadStats(ship);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.OP = "ADD";
            f2.AddBtnTxt = "Add\r\r Image\r\r (Feature in Construction)";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM `ShipStats` WHERE `Ship_Name`=@shipname and`Ship_No`=@num;" + 
                "DELETE FROM `ShipInfo` WHERE `Ship_Name`=@shipname and`Ship_No`=@num;";
            cmd = new MySqlCommand(delete, conn);
            cmd.Parameters.AddWithValue("@shipname", lblName.Text);
            cmd.Parameters.AddWithValue("@num", int.Parse(ShipNo));
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
