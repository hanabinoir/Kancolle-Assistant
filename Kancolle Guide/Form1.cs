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
        private string No, HP, Firepower, Armor, Torpedo, 
            Evasion, AA, Aircraft, ASW, Speed, LOS, Range, Luck;
        private MySqlConnection conn;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            lstRcp.View = View.Details;
            lstRcp.GridLines = true;
            lstRcp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstRcp.Columns[0].ImageIndex = 0;
            lstRcp.Columns[1].ImageIndex = 1;
            lstRcp.Columns[2].ImageIndex = 2;
            lstRcp.Columns[3].ImageIndex = 3;

            connection();

            string findType = "select Ship_Type from Ships " + 
                "group by Ship_Type " + 
                "order by Ship_Type";

            string findClass = "select Class from Ships " + 
                "where Ship_Type = 'Battleship' " +
                "group by Class " + 
                "order by Ship_No";

            string findShip = "select Ship_Name from Ships " +
                "where Class = 'Nagato'";

            if (conn != null)
            {
                MySqlCommand cmd;
                MySqlDataReader reader;

                cmd = new MySqlCommand(findType, conn);
                reader = cmd.ExecuteReader();
                dgvType.ColumnCount = 1;
                dgvType.Columns[0].Name = "Type";
                while(reader.Read())
                    dgvType.Rows.Add(reader.GetString(0));
                reader.Close();

                cmd = new MySqlCommand(findClass, conn);
                reader = cmd.ExecuteReader();
                dgvClass.ColumnCount = 1;
                dgvClass.Columns[0].Name = "Class";
                while (reader.Read())
                    dgvClass.Rows.Add(reader.GetString(0));
                reader.Close();

                cmd = new MySqlCommand(findShip, conn);
                reader = cmd.ExecuteReader();
                dgvShip.ColumnCount = 1;
                dgvShip.Columns[0].Name = "Ship";
                while (reader.Read())
                {
                    dgvShip.Rows.Add(reader.GetString(0));
                    lblName.Text = reader.GetString(0);
                }
                    
                reader.Close();
            }
            else
                MessageBox.Show("Try to connect.");

            defStats("Nagato");
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

            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject("_" + No);
            btnImg.Image = img;
        }

        private void defStats(string ship)
        {
            string findStats = "select * from Ships " + 
                "where Ship_Name = '" + ship + "';";
            MySqlCommand cmd;
            MySqlDataReader reader;

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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.HP = lblHP.Text;
            stats.ARMOR = lblArmor.Text;

            Form2 editStats = new Form2();
            editStats.Show();

            assignVal(stats.HP);
            editStats.HPinit = init;
            editStats.HPMax = max;

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
            {
                init = s;
                max = "-";
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Kancolle Voices\Nagato-Introduction.ogg");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
