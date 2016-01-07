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
    public partial class frmOrdHist : Form
    {
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        private string email, cardNum = "";

        public frmOrdHist()
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

        private void OrdHist_Load(object sender, EventArgs e)
        {
            string findCard = "SELECT `Card_Num` FROM f_user24.KancollePayment " + 
                "where Email = '" + email + "';";

            lstOrd.Items.Clear();
            cmd = new MySqlCommand(findCard, conn);
            reader = cmd.ExecuteReader();
            if (!reader.HasRows)
                lstOrd.Items.Add("No payment method added");
            else
                while (reader.Read())
                    cardNum = reader.GetString(0);
            reader.Close();

            if (cardNum != "")
            {
                string findTrans = "viewOrders";
                cmd = new MySqlCommand(findTrans, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@card", cardNum);
                cmd.Parameters["@card"].Direction = ParameterDirection.Input;

                reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                    lstOrd.Items.Add("No order history");
                else
                {
                    lstOrd.Columns.Add("No.");
                    lstOrd.Columns.Add("Date");
                    lstOrd.Columns.Add("Amount");
                    lstOrd.Columns.Add("Card");
                    lstOrd.View = View.Details;
                    while (reader.Read())
                    {
                        lstOrd.Items.Add(new ListViewItem(new string[]{
                            reader.GetString(0), 
                            reader.GetString(1), 
                            "$" + reader.GetString(2), 
                            reader.GetString(3)
                        }));
                    }
                }
                reader.Close();
            }
        }

        public string EMAIL { set { email = value; } }

        private void frmOrdHist_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
    }
}
