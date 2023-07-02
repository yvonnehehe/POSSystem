using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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

        public int selectID;
        public int getorderid;
        public int ordertetailid;

        string image_modify_name = "";
        int cupcount;
        int subtotal;
        int price;
        int Q; //接收讀出來的數量
        string stringSugar = ""; //甜度儲存在這兒
        string stringIce = ""; //冰塊儲存在這兒
        int P_ID;
        int ListID;
        string nonono = "0%";
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
        public void ShowProductDetail(int selectID)
        {
            if (selectID > 0)
            {
                //cup預設值
                txtQ.Text = "1";
                cupcount = 1;
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
                    labSubtotal.Text = "NT$ " + reader["Price"].ToString();
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
                Subtotal();
            }
        }

        private void btnQadd一_Click(object sender, EventArgs e)
        {
            cupcount++;
            txtQ.Text = cupcount.ToString();
            Subtotal();
        }

        private void btnQLower_Click(object sender, EventArgs e)
        {
            if (cupcount > 1)
            {
                cupcount--;
                txtQ.Text = cupcount.ToString();
                Subtotal();
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
            Subtotal();
        }
        void Subtotal()
        {

            if (isEspresso)
            {
                subtotal = (cupcount * (price + 20));
            }
            else
            {
                subtotal = cupcount * price;
            }
            labSubtotal.Text = $"NT$ {subtotal}";
        }
        //尚未做重複點擊add按鈕
        private void pictureBoxAddShopping_Click(object sender, EventArgs e)
        {
            if (ListID == 4)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string insertnNewOrderDetail = @"
                    INSERT INTO orderdetail (P_ID, Quantity, Subtotal, Sugar, Ice, Espresso)
                    VALUES (@pid, @NewQuantity, @NewSubtotal,@NewSugar,@NewIce,@NewEspresso);
                    ";

                SqlCommand cmd = new SqlCommand(insertnNewOrderDetail, con);
                //cmd.Parameters.AddWithValue("@OrderID", getorderid);
                cmd.Parameters.AddWithValue("@pid", P_ID);
                cmd.Parameters.AddWithValue("@NewQuantity", cupcount);
                cmd.Parameters.AddWithValue("@NewSubtotal", subtotal);
                cmd.Parameters.AddWithValue("@NewSugar", nonono);
                cmd.Parameters.AddWithValue("@NewIce", nonono);
                cmd.Parameters.AddWithValue("@NewEspresso", isEspresso);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows}件商品已成功添加到購物車");

            }
            else if (ListID == 1)
            {
                if ((stringSugar != "") && (stringIce != ""))
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string insertnNewOrderDetail = @"
                    INSERT INTO orderdetail (P_ID, Quantity, Subtotal, Sugar, Ice, Espresso)
                    VALUES (@pid, @NewQuantity, @Subtotal, @NewSugar, @NewIce, @NewEspresso);
                    ";

                    SqlCommand cmd = new SqlCommand(insertnNewOrderDetail, con);
                    //cmd.Parameters.AddWithValue("@OrderID", getorderid);
                    cmd.Parameters.AddWithValue("@pid", P_ID);
                    cmd.Parameters.AddWithValue("@NewQuantity", cupcount);
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                    cmd.Parameters.AddWithValue("@NewSugar", "0%");
                    cmd.Parameters.AddWithValue("@NewIce", "0%");
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
            else
            {
                if ((stringSugar != "") && (stringIce != ""))
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string insertnNewOrderDetail = @"
                    INSERT INTO orderdetail (P_ID, Quantity, Subtotal, Sugar, Ice, Espresso)
                    VALUES (@pid, @NewQuantity, @Subtotal, @NewSugar, @NewIce, @NewEspresso);
                    ";

                    SqlCommand cmd = new SqlCommand(insertnNewOrderDetail, con);
                    //cmd.Parameters.AddWithValue("@OrderID", getorderid);
                    cmd.Parameters.AddWithValue("@pid", P_ID);
                    cmd.Parameters.AddWithValue("@NewQuantity", cupcount);
                    cmd.Parameters.AddWithValue("@Subtotal", subtotal);
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
        List<int> listOrderDetailID = new List<int>();
        public void ReadOrderDetail(int ordertetailid)
        {
            if (ordertetailid > 0)
            {
                SqlConnectionStringBuilder scsb2 = new SqlConnectionStringBuilder();
                scsb2.DataSource = @".";
                scsb2.InitialCatalog = "IspanPersonalProject_POS";
                scsb2.IntegratedSecurity = true;
                string strDBConnectionString2 = scsb2.ConnectionString;

                SqlConnection con = new SqlConnection(strDBConnectionString2);
                con.Open();
                string strSQL = @"SELECT  *
                                FROM orderdetail od
                                INNER JOIN products p ON od.P_ID = p.P_ID
                                WHERE OrderDetail_ID = @SearchOdID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchOdID", ordertetailid);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    P_ID = (int)reader["P_ID"];
                    listOrderDetailID.Add((int)reader["OrderDetail_ID"]);
                    labName.Text = reader["P_Name"].ToString();
                    labPrice.Text = reader["Price"].ToString();
                    price = (int)reader["Price"];
                    txtQ.Text = reader["Quantity"].ToString();
                    cupcount = (int)reader["Quantity"];
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
                    bool isCoffee = reader["List_ID"].ToString() == "1";
                    checkBoxEspresso_CheckedChanged(isCoffee);
                    string Sugar = reader["Sugar"].ToString();
                    if (Sugar == "100%")
                    {
                        rBtnSugar100.Checked = true;
                    }
                    else if (Sugar == "80%")
                    {
                        rBtnSugar80.Checked = true;
                    }
                    else if (Sugar == "40%")
                    {
                        rBtnSugar40.Checked = true;
                    }
                    else
                    {
                        rBtnSugar0.Checked = true;
                    }
                    string Ice = reader["Ice"].ToString();
                    if (Ice == "100%")
                    {
                        rBtnIce100.Checked = true;
                    }
                    else if (Ice == "80%")
                    {
                        rBtnIce80.Checked = true;
                    }
                    else if (Ice == "40%")
                    {
                        rBtnIce40.Checked = true;
                    }
                    else
                    {
                        rBtnIce0.Checked = true;
                    }
                    checkBoxEspresso.Checked = Convert.ToBoolean(reader["Espresso"]);
                    if (checkBoxEspresso.Checked == true)
                    {
                        isEspresso=true;
                        Subtotal();
                        //labSubtotal.Text = $"NT$ {subtotal}";
                    }
                    else
                    {
                        Subtotal();
                    }        

                }
                reader.Close();
                con.Close();
            }
        }

        private void btnDetele_Click(object sender, EventArgs e)
        {
            //刪除OrderDetail
            if (ordertetailid > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from orderdetail where OrderDetail_ID = @SearchOdID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchOdID", ordertetailid);

                if (MessageBox.Show("確認刪除此筆商品", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"{rows}筆商品刪除成功");
                }
            }
            else
            {
                MessageBox.Show("商品未選");
            }


        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            //存進資料庫
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "UPDATE orderdetail SET Quantity = @NewQuantity, Subtotal = @NewSubtotal, Sugar = @NewSugar, Ice = @NewIce, Espresso = @NewEspresso WHERE OrderDetail_ID = @SearchOID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchOID", ordertetailid);
            cmd.Parameters.AddWithValue("@NewQuantity", txtQ.Text);
            cmd.Parameters.AddWithValue("@NewSubtotal", subtotal);
            cmd.Parameters.AddWithValue("@NewSugar", stringSugar);
            cmd.Parameters.AddWithValue("@NewIce", stringIce);
            cmd.Parameters.AddWithValue("@NewEspresso", isEspresso);

            int rows = cmd.ExecuteNonQuery();
            con.Close();
            ReadOrderDetail(ordertetailid);
            MessageBox.Show($"{rows}筆商品更新成功");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
