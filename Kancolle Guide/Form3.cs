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
    public partial class Form3 : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public Form3()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string find = "SELECT Pwd FROM f_user24.KancolleCust " + 
                "where Email = '" + txtEmail.Text + "';";
            cmd = new MySqlCommand(find, conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            if (!reader.HasRows)
                lblEmail.Text = "Invalid email";
            else if (txtPwd.Text != reader.GetString(0))
                lblPwd.Text = "Password incorrect";
            else
                MessageBox.Show("Login successful");
            reader.Close();
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
