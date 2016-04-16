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
    public partial class frmItmes : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private int total;

        public frmItmes()
        {
            InitializeComponent();
            connection();
        }

        private void connection()
        {
            string connStr = "SERVER=localhost; " +
                "DATABASE=kancolle; " +
                "UID=root;";
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
            string res = "SELECT * FROM kancolle.Resources;";
            string cons = "SELECT * FROM kancolle.Consumables;";
            string recmd = "SELECT * FROM kancolle.Recommended;";
            string special = "SELECT * FROM kancolle.Special;";
            

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

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            lblPrice.Text = "Total: ";
            total = 0;

            for (int i = 0; i < dgvRes.RowCount - 1; i++)
            {
                if (int.Parse(dgvRes.Rows[i].Cells[3].Value.ToString()) > 0)
                    total += int.Parse(dgvRes.Rows[i].Cells[2].Value.ToString()) *
                        int.Parse(dgvRes.Rows[i].Cells[3].Value.ToString());
            }

            for (int i = 0; i < dgvCons.RowCount - 1; i++)
            {
                if (int.Parse(dgvCons.Rows[i].Cells[3].Value.ToString()) > 0)
                    total += int.Parse(dgvCons.Rows[i].Cells[2].Value.ToString()) *
                        int.Parse(dgvCons.Rows[i].Cells[3].Value.ToString());
            }

            for (int i = 0; i < dgvRecm.RowCount - 1; i++)
            {
                if (int.Parse(dgvRecm.Rows[i].Cells[3].Value.ToString()) > 0)
                    total += int.Parse(dgvRecm.Rows[i].Cells[2].Value.ToString()) *
                        int.Parse(dgvRecm.Rows[i].Cells[3].Value.ToString());
            }

            for (int i = 0; i < dgvSpecial.RowCount - 1; i++)
            {
                if (int.Parse(dgvSpecial.Rows[i].Cells[3].Value.ToString()) > 0)
                    total += int.Parse(dgvSpecial.Rows[i].Cells[2].Value.ToString()) *
                        int.Parse(dgvSpecial.Rows[i].Cells[3].Value.ToString());
            }

            lblPrice.Text += "$" + total.ToString();
        }
    }
}
