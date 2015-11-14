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
        private string num;

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

        public string HP
        {
            get { return txtHP.Text; }
            set { txtHP.Text = value; }
        }

        public string FPinit
        {
            get { return txtFpInit.Text; }
            set { txtFpInit.Text = value; }
        }

        public string FPmax
        {
            get { return txtFpMax.Text; }
            set { txtFpMax.Text = value; }
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

        public string TPDinit
        {
            get { return txtTpdInit.Text; }
            set { txtTpdInit.Text = value; }
        }

        public string TPDmax
        {
            get { return txtTpdMax.Text; }
            set { txtTpdMax.Text = value; }
        }

        public string EVASinit
        {
            get { return txtEvsInit.Text; }
            set { txtEvsInit.Text = value; }
        }

        public string EVASmax
        {
            get { return txtEvsMax.Text; }
            set { txtEvsMax.Text = value; }
        }

        public string AAinit
        {
            get { return txtAAInit.Text; }
            set { txtAAInit.Text = value; }
        }

        public string AAmax
        {
            get { return txtAAMax.Text; }
            set { txtAAMax.Text = value; }
        }

        public string AIRCRAFT
        {
            get { return txtAircraft.Text; }
            set { txtAircraft.Text = value; }
        }

        public string ASWinit
        {
            get { return txtASWInit.Text; }
            set { txtASWInit.Text = value; }
        }

        public string ASWmax
        {
            get { return txtASWMax.Text; }
            set { txtASWMax.Text = value; }
        }

        public string SPEED
        {
            get { return txtSpeed.Text; }
            set { txtSpeed.Text = value; }
        }

        public string LOSinit
        {
            get { return txtLOSInit.Text; }
            set { txtLOSInit.Text = value; }
        }

        public string LOSmax
        {
            get { return txtLOSMax.Text; }
            set { txtLOSMax.Text = value; }
        }

        public string RANGE
        {
            get { return txtRange.Text; }
            set { txtRange.Text = value; }
        }

        public string LUCKinit
        {
            get { return txtLuckInit.Text; }
            set { txtLuckInit.Text = value; }
        }

        public string LUCKmax
        {
            get { return txtLuckMax.Text; }
            set { txtLuckMax.Text = value; }
        }

        public string BUILDTIME
        {
            get { return txtTime.Text; }
            set { txtTime.Text = value; }
        }

        public string SHIP_NAME
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string NUM
        {
            set { num = value; }
        }

        public void AddImg(Image img)
        {
            btnImg.Image = img;
        }
    }
}
