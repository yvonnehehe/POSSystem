using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class S_SystemOff : Form
    {
        public bool isSystemOFF { get; set; }

        public S_SystemOff()
        {
            InitializeComponent();
        }

        private void btnBackEnterPage_Click(object sender, EventArgs e)
        {
            if (isSystemOFF == true)
            {
                EnterPage EP = new EnterPage();
                EP.isSystemOFF = true;
                EP.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
                Program.EnterPage.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
