﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Kancolle_Assistant
{
    public partial class frmHome : Form
    {
        private string init = "", max = "", shiptype = "", shipclass = "";
        private string ShipNo = "", HP = "", Firepower = "", Armor = "", 
            Torpedo = "", Evasion = "", AA = "", Aircraft = "", 
            ASW = "", Speed = "", LOS = "", Range = "", Luck = "";
        private string[] rare = {"Shimakaze", "Yukikaze", "Suzuya", "Kumano", 
                                "Mutsu", "Nagato"};
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private MySqlDataAdapter adapter;
        private DataSet ds;
        Statistics stats;

        public frmHome()
        {
            InitializeComponent();
        }

        private void connection()
        {
            XmlTextReader xml = new XmlTextReader("connection.xml");
            string connStr = "";
            string[] attrs = { "SERVER", "database", "uid", "password" };
            string[] vals = new string[4];
            for(int i = 0; i < vals.Length; i++)
            {
                xml.ReadToFollowing(attrs[i]);
                xml.Read();
                connStr += attrs[i] + "=" + xml.Value + "; ";
            }
            xml.Close();
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
            
            cmd = new MySqlCommand(findClass, conn);
            adapter = new MySqlDataAdapter();
            ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            ds.Tables[0].Columns[0].ColumnName = "Type";
            dgvType.DataSource = ds.Tables[0];
        }

        private void loadClass(string type)
        {
            string findClass = "select Ship_Class from ShipInfo " +
                "where Ship_Type = '" + type + "' " +
                "group by Ship_Class " +
                "order by Ship_No";

            shiptype = type;
            cmd = new MySqlCommand(findClass, conn);
            adapter = new MySqlDataAdapter();
            ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            ds.Tables[0].Columns[0].ColumnName = "Class";
            dgvClass.DataSource = ds.Tables[0];
        }

        private void btnChkItems_Click(object sender, EventArgs e)
        {
            frmItmes Items = new frmItmes();
            Items.Show();
        }

        private void loadShip(string Class)
        {
            string findShip = "select Ship_Name from ShipInfo " +
                "where Ship_Class = '" + Class + "'" + 
                "order by Ship_No";

            shipclass = Class;
            cmd = new MySqlCommand(findShip, conn);
            adapter = new MySqlDataAdapter();
            ds = new DataSet();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            ds.Tables[0].Columns[0].ColumnName = "Ship";
            dgvShip.DataSource = ds.Tables[0];
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

        public void reloadTypes()
        {
            dgvType.Rows.Clear();
            dgvType.Refresh();
        }

        public void reloadShips()
        {
            dgvShip.Rows.Clear();
            dgvShip.Refresh();
        }

        public void loadRecipe(string type, string ship)
        {
            string recipe = "";
            if (rare.Contains(ship))
                recipe = "select `Fuel`, `Ammunition`, `Steel`, `Bauxite` from Recipe " +
                    "where `Ship_Type` = '" + type + "' and Rare = 1;";
            else
                recipe = "select `Fuel`, `Ammunition`, `Steel`, `Bauxite` from Recipe " +
                    "where `Ship_Type` = '" + type + "';";

            ListViewItem item;
            cmd = new MySqlCommand(recipe, conn);
            reader = cmd.ExecuteReader();
            lstRcp.Items.Clear();
            lstRcp.Columns[0].ImageIndex = 0;
            lstRcp.Columns[1].ImageIndex = 1;
            lstRcp.Columns[2].ImageIndex = 2;
            lstRcp.Columns[3].ImageIndex = 3;
            while (reader.Read())
            {
                item = new ListViewItem(new string[]{
                    reader.GetString(0), 
                    reader.GetString(1), 
                    reader.GetString(2), 
                    reader.GetString(3)
                });
                lstRcp.Items.Add(item);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstRcp.View = View.Details;
            connection();

            if (conn != null)
            {
                loadType();
                loadClass("Battleship");
                loadShip("Nagato");

                defStats("Nagato");
                loadStats("Nagato");
                loadRecipe("Battleship", "Nagato");
            }
            else
                MessageBox.Show("Try to connect.");
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
            stats.SHIP_NAME = lblName.Text;
            stats.NUM = ShipNo;
            stats.SHIPTYPE = shiptype;
            stats.SHIPCLASS = shipclass;

            frmEdit f2 = new frmEdit();
            f2.Show();
            f2.OP = "UPDATE";

            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + stats.NUM);
            f2.AddImg(img);

            f2.HP = stats.HP;
            f2.AIRCRAFT = stats.AIRCRAFT;
            f2.SPEED = stats.SPEED;
            f2.RANGE = stats.RANGE;

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
            loadRecipe(type, ship);
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = dgvType.SelectedCells[0].Value.ToString();
            string Class = dgvClass.SelectedCells[0].Value.ToString();
            loadShip(Class);
            string ship = dgvShip.SelectedCells[0].Value.ToString();
            defStats(ship);
            loadStats(ship);
            loadRecipe(type, ship);
        }

        private void dgvShip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = dgvType.SelectedCells[0].Value.ToString();
            string ship = dgvShip.SelectedCells[0].Value.ToString();
            defStats(ship);
            loadStats(ship);
            loadRecipe(type, ship);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEdit f2 = new frmEdit();
            f2.Show();
            f2.OP = "ADD";
            f2.AddBtnTxt = "Add\r\r Image\r\r (Feature in Construction)";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string delStat = "DELETE FROM `ShipStats` WHERE `Ship_Name`=@shipname and`Ship_No`=@num;";
            string delInfo = "DELETE FROM `ShipInfo` WHERE `Ship_Name`=@shipname and`Ship_No`=@num;";
            MySqlCommand cmd1 = new MySqlCommand(delStat, conn);
            MySqlCommand cmd2 = new MySqlCommand(delInfo, conn);
            cmd1.Parameters.AddWithValue("@shipname", lblName.Text);
            cmd1.Parameters.AddWithValue("@num", int.Parse(ShipNo));
            cmd2.Parameters.AddWithValue("@shipname", lblName.Text);
            cmd2.Parameters.AddWithValue("@num", int.Parse(ShipNo));
            try
            {
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Record deleted");
                dgvShip.Rows.RemoveAt(dgvShip.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
