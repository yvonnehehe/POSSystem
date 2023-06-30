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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSSystem
{
    public partial class Checkout : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public int getsum;
        public int getcid;
        int orderID;
        List<int> listPoint = new List<int>();
        public Checkout()
        {
            InitializeComponent();
        }
        private void Checkout_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            讀取商品資料庫();
        }

        //結帳->結完帳 新增order oid cid 新增orderdetail oid is null 如果關閉表單->is null全刪
        void orderfinlly()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            NewOrderID();
            string strSQL = "UPDATE orderdetail SET  O_ID = @oid WHERE O_ID is NULL;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@oid", orderID);
            if (getcid > 0)
            {
                string strSQL2 = "UPDATE orders SET  C_ID = @cid WHERE O_ID = @oid;";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@cid", getcid);
                cmd2.Parameters.AddWithValue("@oid", orderID);
                int rows2 = cmd2.ExecuteNonQuery();
            }
            else
            {
                string strSQL2 = "UPDATE orders SET  C_ID = NULL WHERE O_ID = @oid;";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@oid", orderID);
                int rows2 = cmd2.ExecuteNonQuery();
            }

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show($"結帳完成");
        }
        void NewOrderID()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();

            if (orderID == 0) //檢查是否已經有一個訂單進行中，如果沒有則創建新的訂單
            {
                string getMaxOid = "SELECT MAX(O_ID) FROM orders;";
                SqlCommand cmd = new SqlCommand(getMaxOid, con);
                int maxOid = 0;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            maxOid = reader.GetInt32(0);
                        }
                    }
                }
                orderID = maxOid + 1;

                string insertNewOrder = "INSERT INTO orders (O_ID,OrderDate) VALUES (@NewOid,@NewTime);";
                SqlCommand cmd2 = new SqlCommand(insertNewOrder, con);
                cmd2.Parameters.AddWithValue("@NewOid", orderID);
                cmd2.Parameters.AddWithValue("@NewTime", DateTime.Now);
                cmd2.ExecuteNonQuery();
                //orderID = newOid;
            }
            con.Close();
        }




        //我要找CID的Point
        void 讀取商品資料庫()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from customer where C_ID like @SearchCID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCID", getcid);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                labePoint.Text = reader["Point"].ToString();
            }
            reader.Close();
            con.Close();
            labSum.Text = getsum.ToString();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //MyOrder myorder = new MyOrder();
            //HomePage homePage = new HomePage();
            //myorder.getcid = getcid;
            //myorder.TopLevel = false;
            //myorder.Dock = DockStyle.None;
            //homePage.panel2.Controls.Clear();
            //homePage.panel2.Controls.Add(myorder);
            //myorder.Show();
            orderfinlly();
            this.Close();



            //myorder.Show();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            orderfinlly();
            this.Close();
            //this.Hide();
            //MyOrder myorder = new MyOrder();
            //myorder.getcid = CID;
            //myorder.TopLevel = false;
            //myorder.Dock = DockStyle.None;
            //HomePage homePage = new HomePage();
            //homePage.panel2.Controls.Clear();
            //homePage.panel2.Controls.Add(myorder);
            //myorder.Show();
        }
    }
}
