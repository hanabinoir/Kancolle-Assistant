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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public string HPinit
        {
            get { return txtHPInit.Text; }
            set { txtHPInit.Text = value; }
        }

        public string HPMax
        {
            get { return txtHPMax.Text; }
            set { txtHPMax.Text = value; }
        }

        public string ARMORinit
        {
            get { return txtArmorInit.Text; }
            set { txtArmorInit.Text = value; }
        }

        public string ARMORmax
        {
            get { return txtArmorMax.Text; }
            set { txtArmorMax.Text = value; }
        }
    }
}
