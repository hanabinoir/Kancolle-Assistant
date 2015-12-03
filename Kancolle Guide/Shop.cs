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
        private string email = "", cardNum = "";
        private int total;

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
            if(email != "")
                btnLogin.Text = "Log out";

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        public string EMAIL { set { email = value; } }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult res;

            if (email == "")
            {
                res = MessageBox.Show("Do you want to go to the login page?",
                    "Login Required", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    btnLogin_Click(sender, e);
                
            }
            else
            {
                string findCard = "SELECT `Card_Num` FROM f_user24.KancollePayment " + 
                    "where Email = '" + email + "';";
                cmd = new MySqlCommand(findCard, conn);
                reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    res = MessageBox.Show("Do you want to add a payment methdo?",
                        "Payment Method Required", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        frmCard card = new frmCard();
                        card.EMAIL = email;
                        card.Show();
                    }
                }
                else
                    while(reader.Read())
                        cardNum = reader.GetString(0);
                reader.Close();

                if (cardNum != "")
                {
                    res = MessageBox.Show("Payment total: $" + total.ToString(),
                        "Order Review", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        string insertTrans = "INSERT INTO `f_user24`.`KancolleTrans` " +
                            "(`Trans_No`, `Trans_Date`, `Amt`, `Card_Num`) VALUES " +
                            "(null, '" + DateTime.Now + "', '" + total + "', '" +
                            cardNum + "');";
                        cmd = new MySqlCommand(insertTrans, conn);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Transaction successful");
                        }
                        catch (MySqlException se)
                        {
                            MessageBox.Show(se.ToString());
                        }
                    }
                }
            }
        }
    }
}
