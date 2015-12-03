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
    public partial class frmPwdReset : Form
    {
        private string pwd, email;
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public frmPwdReset()
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
            lblPwdOld.Text = "";
            lblPwdNew.Text = "";
            lblPwdChk.Text = "";

            string resetPwd = "UPDATE `f_user24`.`KancolleCust` " + 
                "SET `Pwd`='" + txtPwdNew.Text + "' WHERE `Email`='" + email + "';";

            cmd = new MySqlCommand(resetPwd, conn);
            if (txtPwd.Text == "")
                lblPwdOld.Text = "*";
            else if (txtPwd.Text != PWD)
                lblPwdOld.Text = "Incorrect";
            if (txtPwdNew.Text == "")
                lblPwdNew.Text = "*";
            if (txtPwdChk.Text == "")
                lblPwdChk.Text = "*";
            else if (txtPwdChk.Text != txtPwdNew.Text)
                lblPwdChk.Text = "Password doesn't match";

            if (txtPwd.Text != "" && txtPwdNew.Text != "" && txtPwdChk.Text == txtPwdNew.Text)
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New password applied");
                    this.Close();
                }
                catch (MySqlException se)
                {
                    MessageBox.Show(se.ToString());
                }
        }

        public string PWD { set { pwd = value; } get { return pwd; } }
        public string EMAIL { set { email = value; } }

        private void frmPwdReset_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
