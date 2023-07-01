using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.IO;

namespace POSSystem
{
    public partial class Checkout : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public int getsum;
        public int getcid;
        int orderID;

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
            if (getcid > 0)
            {
                txtUsePoint.BackColor = SystemColors.Window;
                txtUsePoint.ReadOnly = false;
            }
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
        }
        void paymentmethod()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            if (isCard == true)
            {
                string strSQL = "UPDATE orders SET  PaymentMethod = @iscard WHERE O_ID = @oid;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@oid", orderID);
                if (usepoint > 0) 
                {
                    string strSQL2 = "UPDATE Customer SET   Point = @NewPoint WHERE　C_ID = @cid;";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@cid", getcid);

                    int Newpoint = point - usepoint;
                    cmd2.Parameters.AddWithValue("@NewPoint", Newpoint);
                    int rows2 = cmd2.ExecuteNonQuery(); 
                }
                cmd.Parameters.AddWithValue("@iscard", $"信用卡");
                int rows = cmd.ExecuteNonQuery(); 
                MessageBox.Show($"信用卡結帳完成");
                this.Close();
            }
            else if (isCash == true)
            {
                string strSQL = "UPDATE orders SET  PaymentMethod = @iscash WHERE O_ID = @oid;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@oid", orderID);
                cmd.Parameters.AddWithValue("@iscash", $"現金");
                if (usepoint > 0)
                {
                    string strSQL2 = "UPDATE Customer SET   Point = @NewPoint WHERE　C_ID = @cid;";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@cid", getcid);

                    int Newpoint = point - usepoint;
                    cmd2.Parameters.AddWithValue("@NewPoint", Newpoint);
                    int rows2 = cmd2.ExecuteNonQuery();
                }
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"現金結帳完成");
                this.Close();
            }
            con.Close();
        }
        int newTotal;
        int usepoint;
        void UpdateTotal()
        {
            if (int.TryParse(txtUsePoint.Text, out usepoint))
            {
                if(usepoint <= getsum) 
                { 
                newTotal = getsum - usepoint;
                labTotal.Text = "NT $" + newTotal.ToString();
                }
                else
                {
                    MessageBox.Show("輸入的值不能超過總金額");
                    txtUsePoint.Text = "";
                }
            }

            else
            {
                labTotal.Text = "NT $" + getsum.ToString();
            }
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



        int total = 0;
        int point = 0;
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
                point = (int)reader["Point"];
            }
            reader.Close();
            con.Close();
            labSum.Text = "NT $" + getsum.ToString();
            labTotal.Text = "NT $" + getsum.ToString();
        }
        public bool isCard = false;
        public bool isCash = false;
        private void btnCard_Click(object sender, EventArgs e)
        {
            //ShoppingCar shoppingcar = new ShoppingCar();
            //shoppingcar.getNewOID = 0;

            isCard = true;
            orderfinlly();
            paymentmethod();
            message = $"您以信用卡結帳，金額為{getsum}元!";
            testmessage();
            this.Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            //ShoppingCar shoppingcar = new ShoppingCar();
            //shoppingcar.getNewOID = 0;

            isCash = true;
            orderfinlly();
            paymentmethod();
            message = $"您以現金結帳，金額為{getsum}元!";
            testmessage();
            this.Close();
        }

        private void txtUsePoint_TextChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        string message = "";
        void testmessage()
        {
            string token = "KXbKBf92ALXq5uW6SxIg3RdmWPnWfrspLmMbjD9808J";
            //string message = "您以現金結帳 金額為 " + DateTime.Now.ToString("yyyyMMddHHmmss");

            string url = "https://notify-api.line.me/api/notify";
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.DefaultConnectionLimit = 9999;
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12; // Use TLS 1.2, TLS 1.1, and TLS 1.0

                var request = (HttpWebRequest)WebRequest.Create(url);
                var postData = string.Format("message={0}", message);
                var data = Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Authorization", "Bearer " + token);

                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072; // Use TLS 1.2
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true; // Bypass certificate validation

                using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
