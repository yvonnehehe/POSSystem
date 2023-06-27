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
            back_customercenter.Show();
            this.Hide();
        }

        private void btn商品維護_Click(object sender, EventArgs e)
        {
            Back_ProductCenter back_productcenter = new Back_ProductCenter();
            back_productcenter.Show();
            this.Hide();
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            Back_OrderCenter back_OrderCenter = new Back_OrderCenter();
            back_OrderCenter.Show();
            this.Hide();
        }

        private void btn系統維護_Click(object sender, EventArgs e)
        {
            Back_SystemCenter back_SystemCenter = new Back_SystemCenter();
            back_SystemCenter.Show();
            this.Hide();
        }
    }
}
