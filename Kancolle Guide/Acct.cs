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
    public partial class frmAcct : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd1, cmd2, cmd3;
        private MySqlDataReader reader;
        private string email;

        public frmAcct()
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

        private void Form5_Load(object sender, EventArgs e)
        {
            string loadCust = "SELECT * FROM f_user24.KancolleCust " + 
                "where Email='" + email + "';";
            string loadCard = "SELECT Card_Num FROM f_user24.KancollePayment " +
                "where Email='" + email + "';";

            cmd1 = new MySqlCommand(loadCust, conn);
            cmd2 = new MySqlCommand(loadCard, conn);

            try
            {
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    txtEmail.Text = reader.GetString(0);
                    txtPwd.Text = reader.GetString(1);
                    txtLN.Text = reader.GetString(2);
                    txtFN.Text = reader.GetString(3);
                }
                reader.Close();

                reader = cmd2.ExecuteReader();
                while (reader.Read())
                    txtCardNo.Text = reader.GetString(0);
                reader.Close();
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.ToString());
            }
        }

        public string EMAIL { set { email = value; } }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmPwdReset f6 = new frmPwdReset();
            f6.PWD = txtPwd.Text;
            f6.EMAIL = txtEmail.Text;
            f6.Show();
        }

        private void btnChg_Click(object sender, EventArgs e)
        {
            frmCard card = new frmCard();
            card.PWD = txtPwd.Text;
            card.EMAIL = txtEmail.Text;
            card.CARD = txtCardNo.Text;
            card.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string update = "UPDATE `f_user24`.`KancolleCust` " +
                "SET `Last_Name`='" + txtLN.Text + "', `First_Name`='" + txtFN.Text + "' " +
                "WHERE `Email`='" + txtEmail.Text + "';";

            cmd3 = new MySqlCommand(update, conn);

            try
            {
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Information updated");
            }
            catch (MySqlException se)
            {
                MessageBox.Show(se.ToString());
            }
        }

        private void frmAcct_FormClosing(object sender, FormClosingEventArgs e)
        {
            reader.Close();
            conn.Close();
        }
    }
}
