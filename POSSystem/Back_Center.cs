using POSSystem.Properties;
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

    public partial class Back_Center : Form
    {

        public Back_Center()
        {
            InitializeComponent();
        }

        private void btn會員資料維護_Click(object sender, EventArgs e)
        {
            Back_CustomerCenter back_customercenter = new Back_CustomerCenter();
            back_customercenter.EID = EID;
            back_customercenter.Show();
            this.Hide();
        }

        private void btn商品維護_Click(object sender, EventArgs e)
        {
            Back_ProductCenter back_productcenter = new Back_ProductCenter();
            back_productcenter.EID = EID;
            back_productcenter.Show();
            this.Hide();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            Back_OrderCenter back_OrderCenter = new Back_OrderCenter();
            back_OrderCenter.EID = EID;
            back_OrderCenter.Show();
            this.Hide();
        }

        private void btn系統維護_Click(object sender, EventArgs e)
        {
            if (isSystemOFF == true)
            {
                Back_SystemCenter BS = new Back_SystemCenter();
                BS.isSystemOFF = isSystemOFF;
                BS.EID = EID;
                BS.SystemOff.Checked = true;
                BS.Show();
                this.Hide();
            }
            else
            {
                Back_SystemCenter BS = new Back_SystemCenter();
                BS.EID = EID;
                BS.Show();
                this.Hide();
            }
        }
        public bool isSystemOFF { get; set; }
        public int EID { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EnterPage EP = new EnterPage();

            if (isSystemOFF == true)
            {
                EP.isSystemOFF = true;
                this.Hide();
                EP.Visible = true;
            }
            else { 
            this.Hide();
            EP.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn員工資料維護_Click(object sender, EventArgs e)
        {
            Back_EmpolyeesCenter E = new Back_EmpolyeesCenter();
            E.EID = EID;
            E.Show();
            this.Hide();
        }

        private void Back_Center_Load(object sender, EventArgs e)
        {
            if(EID == 1)
            {
                btn員工資料維護.Visible = true;
                btn系統維護.Visible = true;
            }
        }
    }
}
