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
    public partial class frmCard : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;

        private string pwd, email, operation = "";

        public frmCard()
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
            lblCard.Text = "";
            lblPwd.Text = "";

            string updateCard = "UPDATE `f_user24`.`KancollePayment` " +
                "SET `Card_Num`='" + txtCardNo.Text + "' " + 
                "WHERE `Card_Num` = '" + txtCardNo.Text + "';";
            string addCard = "INSERT INTO `f_user24`.`KancollePayment` " + 
                "(`Card_Num`, `Email`, `Pwd`) VALUES " + 
                "('" + txtCardNo.Text + "', '" + EMAIL + "', '" + txtPwd.Text + "');";

            if (operation == "update")
                cmd = new MySqlCommand(updateCard, conn);
            else
                cmd = new MySqlCommand(addCard, conn);

            if (txtCardNo.Text == "")
                lblCard.Text = "*";

            if (txtPwd.Text == "")
                lblPwd.Text = "*";
            else if (txtPwd.Text != PWD)
                lblPwd.Text = "Incorrect Password";

            if(txtCardNo.Text != "" && txtPwd.Text != "")
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Card information updated");
                    this.Close();
                }
                catch (MySqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
        }

        public string PWD { set { pwd = value; } get { return pwd; } }
        public string EMAIL { set { email = value; } get { return email; } }
        public string CARD { set { txtCardNo.Text = value; } get { return txtCardNo.Text; } }

        private void frmCard_Load(object sender, EventArgs e)
        {
            if (txtCardNo.Text == "")
                operation = "add";
            else
                operation = "update";
        }

        private void frmCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
