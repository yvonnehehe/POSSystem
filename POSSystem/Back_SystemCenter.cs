using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Back_SystemCenter : Form
    {
        public Back_SystemCenter()
        {
            InitializeComponent();
        }
        public bool isSystemOFF { get; set; }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Back_Center BC = new Back_Center();

            if (SystemOff.Checked == true)
            {
                BC.isSystemOFF = true;
                //EP.Show();
                this.Close();
                BC.Visible = true;

            }
            //Back_Center BC = new Back_Center();
            this.Close();
            BC.Visible = true;


        }

        private void Back_SystemCenter_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
