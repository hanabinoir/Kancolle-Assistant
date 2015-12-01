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
    public partial class frmReg : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd1, cmd2, cmd3;
        private bool reged = false;

        public frmReg()
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblEmail.Text = "";
            lblPwd.Text = "";
            lblPwd2.Text = "";

            string chkDuo = "SELECT * FROM f_user24.KancolleCust " + 
                "where Email = '" + txtEmail.Text + "';";

            string addCust = "INSERT INTO `f_user24`.`KancolleCust` " + 
                "(`Email`, `Pwd`, `Last_Name`, `First_Name`) " + 
                "VALUES (@email, @pwd, @fn, @ln);";
            string addCard = "INSERT INTO `f_user24`.`KancollePayment` " + 
                "(`Card_Num`, `Email`, `Pwd`) VALUES " + 
                "(@card, @email, @pwd);";

            cmd1 = new MySqlCommand(addCust, conn);
            cmd2 = new MySqlCommand(addCard, conn);
            cmd3 = new MySqlCommand(chkDuo, conn);

            cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd1.Parameters.AddWithValue("@pwd", txtPwd.Text);
            cmd1.Parameters.AddWithValue("@fn", txtFN.Text);
            cmd1.Parameters.AddWithValue("@ln", txtLN.Text);

            cmd2.Parameters.AddWithValue("@card", txtCardNo.Text);
            cmd2.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd2.Parameters.AddWithValue("@pwd", txtPwd.Text);

            if (txtEmail.Text == "")
            {
                lblEmail.Text = "*";
                lblEmail.ForeColor = System.Drawing.Color.Red;
            }
            if (txtPwd.Text == "")
            {
                lblPwd.Text = "*";
                lblPwd.ForeColor = System.Drawing.Color.Red;
            }

            if (txtPwd2.Text == "")
            {
                lblPwd2.Text = "*";
                lblPwd2.ForeColor = System.Drawing.Color.Red;
            }
            else if (txtPwd2.Text != txtPwd.Text)
            {
                lblPwd2.Text = "Password doesn't match";
                lblPwd.ForeColor = System.Drawing.Color.Red;
            }



            if (txtEmail.Text != "" && txtPwd.Text != "" && txtPwd2.Text != "")
            {
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully");
                    reged = true;
                }
                catch (MySqlException se)
                {
                    switch (se.Number)
                    {
                        case 1062:
                            MessageBox.Show("The email address is already registered");
                            break;
                    }
                }
            }
                

            if(txtCardNo.Text != "")
                try
                {
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Payment Method Added");
                }
                catch (MySqlException se)
                {
                    MessageBox.Show(se.ToString());
                }

            if (reged)
            {
                frmAcct f5 = new frmAcct();
                f5.EMAIL = txtEmail.Text;
                f5.Show();
                this.Close();
            }
        }
    }
}
