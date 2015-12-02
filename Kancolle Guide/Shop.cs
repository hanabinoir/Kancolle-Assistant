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
    public partial class frmShop : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public frmShop()
        {
            InitializeComponent();
            connection();
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

        private void frmShop_Load(object sender, EventArgs e)
        {
            string res = "SELECT * FROM f_user24.Resources;";
            string cons = "SELECT * FROM f_user24.Consumables;";
            string recmd = "SELECT * FROM f_user24.Recommended;";
            string special = "SELECT * FROM f_user24.Special;";

            

            cmd = new MySqlCommand(res, conn);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject(reader.GetString(0));
                colItem1.Image = img;
                dgvRes.Rows.Add(colItem1.Image, reader.GetString(1), reader.GetString(2), "0");
            }
            reader.Close();

            cmd = new MySqlCommand(cons, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject(reader.GetString(0));
                colItem2.Image = img;
                dgvCons.Rows.Add(colItem2.Image, reader.GetString(1), reader.GetString(2), "0");
            }
            reader.Close();

            cmd = new MySqlCommand(recmd, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject(reader.GetString(0));
                colItem3.Image = img;
                dgvRecm.Rows.Add(colItem3.Image, reader.GetString(1), reader.GetString(2), "0");
            }
            reader.Close();

            cmd = new MySqlCommand(special, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject(reader.GetString(0));
                colItem4.Image = img;
                dgvSpecial.Rows.Add(colItem4.Image, reader.GetString(1), reader.GetString(2), "0");
            }
            reader.Close();
        }
    }
}
