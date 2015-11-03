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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstRcp.View = View.Details;
            lstRcp.GridLines = true;
            lstRcp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            dgvType.ColumnCount = 1;
            dgvType.Columns[0].Name = "Type";
            dgvType.Rows.Add("Battleship");
            dgvType.Rows.Add("Carrier");
            dgvType.Rows.Add("Heavy Cruiser");
            dgvType.Rows.Add("Light Cruiser");
            dgvType.Rows.Add("Destroyer");

            dgvClass.ColumnCount = 1;
            dgvClass.Columns[0].Name = "Class";
            dgvClass.Rows.Add("Nagato");
            dgvClass.Rows.Add("Fusou");
            dgvClass.Rows.Add("Ise");

            dgvShip.ColumnCount = 1;
            dgvShip.Rows.Add("Nagato");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form2 editStatus = new Form2();
            editStatus.Show();
        }
    }
}
