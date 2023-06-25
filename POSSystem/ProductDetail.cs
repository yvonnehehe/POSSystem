using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class ProductDetail : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        string strImageDir = @"..\productsimage";

        public int selectID = 0;
        public int getorderid = 0;

        string image_modify_name = "";
        int cupcount = 1;
        int totalprice = 0;
        int price = 0;
        string stringSugar = ""; //甜度儲存在這兒
        string stringIce = ""; //冰塊儲存在這兒
        int P_ID;
        int ListID = 0;

        public ProductDetail()
        {
            InitializeComponent();
        }


        private void ProductDetail_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }
        public void ShowProductDetail(int selectID, int orderid)
        {
            getorderid = orderid;
            //SetOrderID(getorderid);
            //cup預設值
            txtCup.Text = "1";
            if (selectID > 0)
            {
                SqlConnectionStringBuilder scsb2 = new SqlConnectionStringBuilder();
                scsb2.DataSource = @".";
                scsb2.InitialCatalog = "IspanPersonalProject_POS";
                scsb2.IntegratedSecurity = true;
                string strDBConnectionString2 = scsb2.ConnectionString;

                SqlConnection con = new SqlConnection(strDBConnectionString2);
                con.Open();
                string strSQL = "select * from products where P_ID = @SearchListID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchListID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    P_ID = (int)reader["P_ID"];
                    labName.Text = reader["P_Name"].ToString();
                    labPrice.Text = reader["Price"].ToString();
                    price = (int)reader["Price"];
                    lblPrice.Text = "NT$ " + reader["Price"].ToString();
                    txtDesc.Text = reader["P_Desc"].ToString();
                    //圖檔變動 上傳的圖檔以隨機命名產生檔名(不然會有重複)
                    image_modify_name = reader["P_Image"].ToString();
                    string 完整圖檔路徑 = strImageDir + "\\" + image_modify_name;
                    pictureBoxProduct.Image = Image.FromFile(完整圖檔路徑);
                    if (reader["List_ID"].ToString() == "4")
                    {
                        ListID = 4;
                        groupBoxSugar.Visible = false;
                        groupBoxIce.Visible = false;
                    }

                    //if(reader["List_ID"].ToString()=="1")
                    //{
                    //    checkBoxEspresso_CheckedChanged(true);
                    //}
                    //else
                    //{
                    //    checkBoxEspresso_CheckedChanged(false);
                    //}
                    bool isCoffee = reader["List_ID"].ToString() == "1";
                    checkBoxEspresso_CheckedChanged(isCoffee);

                }
                reader.Close();
                con.Close();
                TotalPrice();
            }
        }

        private void btnCupadd一_Click(object sender, EventArgs e)
        {
            cupcount++;
            txtCup.Text = cupcount.ToString();
            TotalPrice();
        }

        private void btnCupLower_Click(object sender, EventArgs e)
        {
            if (cupcount > 1)
            {
                cupcount--;
                txtCup.Text = cupcount.ToString();
                TotalPrice();
            }
        }
        //讓Espresso只在coffee時顯示
        public void checkBoxEspresso_CheckedChanged(bool isCoffee)
        {
            //isCoffee = true ? checkBoxEspresso.Visible = true : checkBoxEspresso.Visible = false;
            checkBoxEspresso.Visible = isCoffee;
        }

        bool isEspresso = false;
        private void checkBoxEspresso_CheckedChanged(object sender, EventArgs e)
        {
            isEspresso = checkBoxEspresso.Checked;
            TotalPrice();
        }
        void TotalPrice()
        {

            if (isEspresso)
            {
                totalprice = (cupcount * (price + 20));
            }
            else
            {
                totalprice = cupcount * price;
            }
            lblPrice.Text = $"NT$ {totalprice}";
        }
        private void pictureBoxAddShopping_Click(object sender, EventArgs e)
        {
            //if ((stringSugar != "") && (stringIce != ""))
            //{
            //    SqlConnection con = new SqlConnection(strDBConnectionString);
            //    con.Open();
            //    if (orderID == 0) //檢查是否已經有一個訂單進行中，如果沒有則創建新的訂單
            //    {
            //        //先創新的oid跟orderdate
            //        string insertNewOrder = @"INSERT INTO Orders (OrderDate) VALUES (@NewTime);
            //                                SELECT SCOPE_IDENTITY();
            //                                ";
            //        SqlCommand cmd = new SqlCommand(insertNewOrder, con);
            //        cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);
            //        //取得自動生成的oid
            //        orderID = Convert.ToInt32(cmd.ExecuteScalar());
            //    }
            //    //判斷oid有生成才會執行
            //    if (orderID > 0)
            //    {
            //        string insertOrderDetailQuery = @"
            //        INSERT INTO OrderDetail (O_ID, P_ID, Quantity, TotalPrice, Sugar, Ice, Espresso)
            //        VALUES (@OrderID, @pid, @NewQuantity, @NewTotalPrice, @NewSugar, @NewIce, @NewEspresso);
            //        ";

            //        SqlCommand cmd = new SqlCommand(insertOrderDetailQuery, con);
            //        cmd.Parameters.AddWithValue("@OrderID", orderID);
            //        cmd.Parameters.AddWithValue("@pid", P_ID);
            //        cmd.Parameters.AddWithValue("@NewQuantity", cupcount);
            //        cmd.Parameters.AddWithValue("@NewTotalPrice", totalprice);
            //        cmd.Parameters.AddWithValue("@NewSugar", stringSugar);
            //        cmd.Parameters.AddWithValue("@NewIce", stringIce);
            //        cmd.Parameters.AddWithValue("@NewEspresso", isEspresso);

            //        int rows = cmd.ExecuteNonQuery();
            //        con.Close();
            //        MessageBox.Show($"訂購資料新增成功, {rows}筆資料受影響");
            //    }
            //}

            //else
            //{
            //    MessageBox.Show("甜度,冰塊未選擇!");
            //}

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            if (ListID == 4)
            {
                string insertnNewOrderDetail = @"
                    INSERT INTO OrderDetail (O_ID, P_ID, Quantity, TotalPrice)
                    VALUES (@OrderID, @pid, @NewQuantity, @NewTotalPrice);
                    ";

                SqlCommand cmd = new SqlCommand(insertnNewOrderDetail, con);
                cmd.Parameters.AddWithValue("@OrderID", getorderid);
                cmd.Parameters.AddWithValue("@pid", P_ID);
                cmd.Parameters.AddWithValue("@NewQuantity", cupcount);
                cmd.Parameters.AddWithValue("@NewTotalPrice", totalprice);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows}件商品已成功添加到購物車");

            }
            else
            {
                if ((stringSugar != "") && (stringIce != ""))
                {
                    //SqlConnection con = new SqlConnection(strDBConnectionString);
                    //con.Open();
                    string insertnNewOrderDetail = @"
                    INSERT INTO OrderDetail (O_ID, P_ID, Quantity, TotalPrice, Sugar, Ice, Espresso)
                    VALUES (@OrderID, @pid, @NewQuantity, @NewTotalPrice, @NewSugar, @NewIce, @NewEspresso);
                    ";

                    SqlCommand cmd = new SqlCommand(insertnNewOrderDetail, con);
                    cmd.Parameters.AddWithValue("@OrderID", getorderid);
                    cmd.Parameters.AddWithValue("@pid", P_ID);
                    cmd.Parameters.AddWithValue("@NewQuantity", cupcount);
                    cmd.Parameters.AddWithValue("@NewTotalPrice", totalprice);
                    cmd.Parameters.AddWithValue("@NewSugar", stringSugar);
                    cmd.Parameters.AddWithValue("@NewIce", stringIce);
                    cmd.Parameters.AddWithValue("@NewEspresso", isEspresso);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"{rows}件商品已成功添加到購物車");
                }

                else
                {
                    MessageBox.Show("甜度,冰塊未選擇!");
                }

            }
            con.Close();
        }


        private void rBtnSugar100_CheckedChanged(object sender, EventArgs e)
        {
            stringSugar = "100%";
        }

        private void rBtnSugar80_CheckedChanged(object sender, EventArgs e)
        {
            stringSugar = "80%";
        }

        private void rBtnSugar40_CheckedChanged(object sender, EventArgs e)
        {
            stringSugar = "40%";
        }

        private void rBtnSugar0_CheckedChanged(object sender, EventArgs e)
        {
            stringSugar = "0%";
        }

        private void rBtnIce0_CheckedChanged(object sender, EventArgs e)
        {
            stringIce = "0%";
        }

        private void rBtnIce80_CheckedChanged(object sender, EventArgs e)
        {
            stringIce = "80%";
        }

        private void rBtnIce40_CheckedChanged(object sender, EventArgs e)
        {
            stringIce = "40%";
        }

        private void rBtnIce100_CheckedChanged(object sender, EventArgs e)
        {
            stringIce = "100%";
        }
    }
}
