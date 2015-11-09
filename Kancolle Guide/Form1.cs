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
        private string init = "", max = "";
        private string No = "", HP = "", Firepower = "", Armor = "", 
            Torpedo = "", Evasion = "", AA = "", Aircraft = "", 
            ASW = "", Speed = "", LOS = "", Range = "", Luck = "";
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

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
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }

        private void loadType()
        {
            string findClass = "select Ship_Type from Ships " + 
                "group by Ship_Type " +
                "order by Ship_No";

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
            string findClass = "select Class from Ships " +
                "where Ship_Type = '" + type + "' " +
                "group by Class " +
                "order by Ship_No";

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
            string findShip = "select Ship_Name from Ships " +
                "where Class = '" + Class + "'" + 
                "order by Ship_No";

            dgvShip.Rows.Clear();
            cmd = new MySqlCommand(findShip, conn);
            reader = cmd.ExecuteReader();
            dgvShip.ColumnCount = 1;
            dgvShip.Columns[0].Name = "Ship";
            while (reader.Read())
                dgvShip.Rows.Add(reader.GetString(0));
            reader.Close();
        }

        private void defStats(string ship)
        {
            string findStats = "select * from Ships " +
                "where Ship_Name = '" + ship + "';";

            cmd = new MySqlCommand(findStats, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                No = reader.GetInt32(1).ToString("000");
                HP = reader.GetString(4);
                Firepower = reader.GetString(5);
                Armor = reader.GetString(6);
                Torpedo = reader.GetString(7);
                Evasion = reader.GetString(8);
                AA = reader.GetString(9);
                Aircraft = reader.GetString(10);
                ASW = reader.GetString(11);
                Speed = reader.GetString(12);
                LOS = reader.GetString(13);
                Range = reader.GetString(14);
                Luck = reader.GetString(15);
            }
            reader.Close();
        }

        private void loadStats(string ship)
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
            lblNo.Text = "No. " + No;
            lblName.Text = ship;
            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + No);
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
            Statistics stats = new Statistics();
            stats.HP = lblHP.Text;
            stats.ARMOR = lblArmor.Text;

            Form2 editStats = new Form2();
            editStats.Show();

            assignVal(stats.HP);
            editStats.HP = init;

            assignVal(stats.ARMOR);
            editStats.ARMORinit = init;
            editStats.ARMORmax = max;
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
                init = s;
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
        }

        private void dgvShip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ship = dgvShip.SelectedCells[0].Value.ToString();
            defStats(ship);
            loadStats(ship);
        }
    }
}
