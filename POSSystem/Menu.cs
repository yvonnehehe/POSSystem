using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Menu : Form
    {
        public int getcid { get; set; }
        public bool islogin { get; set; }
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        List<string> listProductName = new List<string>();
        List<string> listProductDesc = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        ProductDetail pd = new ProductDetail();
        string strDBConnectionString = "";
        string strImageDir = @"..\productsimage";


        public Menu()
        {
            InitializeComponent();
        }

        //int orderID;

        //public void NewOrderID(int newOid)
        //{
        //    SqlConnectionStringBuilder scsb2 = new SqlConnectionStringBuilder();
        //    scsb2.DataSource = @".";
        //    scsb2.InitialCatalog = "IspanPersonalProject_POS";
        //    scsb2.IntegratedSecurity = true;
        //    string strDBConnectionString2 = scsb2.ConnectionString;

        //    SqlConnection con = new SqlConnection(strDBConnectionString2);
        //    con.Open();

        //    if (orderID == 0) //檢查是否已經有一個訂單進行中，如果沒有則創建新的訂單
        //    {
        //        string getMaxOid = "SELECT MAX(O_ID) FROM orders;";
        //        SqlCommand cmd = new SqlCommand(getMaxOid, con);
        //        int maxOid = 0;

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                if (!reader.IsDBNull(0))
        //                {
        //                    maxOid = reader.GetInt32(0);
        //                }
        //            }
        //        }
        //        newOid = maxOid + 1;

        //        string insertNewOrder = "INSERT INTO orders (O_ID,OrderDate) VALUES (@NewOid,@NewTime);";
        //        SqlCommand cmd2 = new SqlCommand(insertNewOrder, con);
        //        cmd2.Parameters.AddWithValue("@NewOid", newOid);
        //        cmd2.Parameters.AddWithValue("@NewTime", DateTime.Now);
        //        cmd2.ExecuteNonQuery();


        //        orderID = newOid;
        //        //orderID = (int)cmd.ExecuteScalar();

        //        //    SqlCommand cmd2 = new SqlCommand(insertNewOrder, con);
        //        //    cmd2.Parameters.AddWithValue("@NewOid", newOid);
        //        //    cmd2.ExecuteNonQuery();

        //        //    SqlCommand cmd3 = new SqlCommand(insertNewOrderTime, con);
        //        //    cmd3.Parameters.AddWithValue("@NewTime", DateTime.Now);
        //        //    cmd3.ExecuteNonQuery();

        //    }

        //    con.Close();
        //    ////生出oid
        //    //SqlConnectionStringBuilder scsb3 = new SqlConnectionStringBuilder();
        //    //scsb3.DataSource = @".";
        //    //scsb3.InitialCatalog = "IspanPersonalProject_POS";
        //    //scsb3.IntegratedSecurity = true;
        //    //string strDBConnectionString3 = scsb3.ConnectionString;

        //    //SqlConnection con = new SqlConnection(strDBConnectionString3);
        //    //con.Open();

        //    //if (orderID == 0) //檢查是否已經有一個訂單進行中，如果沒有則創建新的訂單
        //    //{
        //    //    ////先創新的oid跟orderdate
        //    //    //string insertNewOrder = @"INSERT INTO Orders (O_ID,OrderDate) VALUES (@NewOID,@NewTime);
        //    //    //                        ";
        //    //    //SqlCommand cmd = new SqlCommand(insertNewOrder, con);
        //    //    //cmd.Parameters.AddWithValue("@NewOID", orderID);
        //    //    //cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);
        //    //    ////取得自動生成的oid
        //    //    //orderID = Convert.ToInt32(cmd.ExecuteScalar());
        //    //    string getMaxOid = "SELECT MAX(O_ID) FROM orders;";
        //    //    SqlCommand cmd = new SqlCommand(getMaxOid, con);
        //    //    int maxOid = 0;

        //    //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    //    {
        //    //        if (reader.Read())
        //    //        {
        //    //            if (!reader.IsDBNull(0))
        //    //            {
        //    //                maxOid = reader.GetInt32(0);
        //    //            }
        //    //        }
        //    //    }
        //    //    //string getMaxOid = "SELECT MAX(O_ID) FROM Orders;";
        //    //    //SqlCommand cmd = new SqlCommand(getMaxOid, con);
        //    //    //SqlDataReader reader = cmd.ExecuteReader();
        //    //    //int maxOid = (int)reader["MAX(O_ID)"];

        //    //    int newOid = maxOid + 1;

        //    //    string insertNewOrder = "INSERT INTO orderdetail (O_ID) VALUES (@NewOid);";
        //    //    SqlCommand cmd2 = new SqlCommand(insertNewOrder, con);
        //    //    cmd2.Parameters.AddWithValue("@NewOid", newOid);
        //    //    cmd2.ExecuteNonQuery();

        //    //    string insertNewOrderTime = "INSERT INTO orders (OrderDate) VALUES (@NewTime);";
        //    //    SqlCommand cmd3 = new SqlCommand(insertNewOrderTime, con);
        //    //    cmd3.Parameters.AddWithValue("@NewTime", DateTime.Now);
        //    //    cmd3.ExecuteNonQuery();


        //    //    orderID = newOid;
        //    //}
        //    //con.Close();

        //}


        private void btnCoffee_Click(object sender, EventArgs e)
        {
            QueryProd(1);
            btnCoffee.BackColor = Color.DarkGray;
            btnFizz.BackColor = Color.DimGray;
            btnTeaAndFlavorMilk.BackColor = Color.DimGray;
            btnDessert.BackColor = Color.DimGray;
        }

        private void btnFizz_Click(object sender, EventArgs e)
        {
            QueryProd(2);
            btnCoffee.BackColor = Color.DimGray;
            btnFizz.BackColor = Color.DarkGray;
            btnTeaAndFlavorMilk.BackColor = Color.DimGray;
            btnDessert.BackColor = Color.DimGray;
        }

        private void btnTeaAndFlavorMilk_Click(object sender, EventArgs e)
        {
            QueryProd(3);
            btnCoffee.BackColor = Color.DimGray;
            btnFizz.BackColor = Color.DimGray;
            btnTeaAndFlavorMilk.BackColor = Color.DarkGray;
            btnDessert.BackColor = Color.DimGray;
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            QueryProd(4);
            btnCoffee.BackColor = Color.DimGray;
            btnFizz.BackColor = Color.DimGray;
            btnTeaAndFlavorMilk.BackColor = Color.DimGray;
            btnDessert.BackColor = Color.DarkGray;
        }

        private void QueryProd(int List_ID)
        {
            listViewMenu.Clear();
            listPid.Clear();
            listProductName.Clear();
            listProductDesc.Clear();
            listPrice.Clear();

            imageListPrducts.Images.Clear();
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from products where List_ID = @SearchListID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchListID", List_ID);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                listPid.Add((int)reader["P_ID"]);
                listProductName.Add((string)reader["P_Name"]);
                listProductDesc.Add((string)reader["P_Desc"]);
                listPrice.Add((int)reader["Price"]);
                string image_name = (string)reader["P_Image"];
                string 完整圖檔路徑 = strImageDir + "\\" + image_name;
                Image img商品圖檔 = Image.FromFile(完整圖檔路徑);
                imageListPrducts.Images.Add(img商品圖檔);
            }
            reader.Close();
            con.Close();
            ShowlistView();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            QueryProd(1);
        }
        void ShowlistView()
        {
            listViewMenu.View = View.LargeIcon;//指定顯示模式 ->大圖  //LargeIcon(大圖版), SmallIcon(小圖版), List(列), Tile(固定高度,如果圖太大會被切掉)
            imageListPrducts.ImageSize = new Size(150, 150);//指定圖檔大小(最多256)
            listViewMenu.LargeImageList = imageListPrducts; //顯示大圖
            //listViewMenu.SmallImageList = imageListPrducts; //顯示小圖 50*50 40*40 30*30

            //索引值對應
            for (int i = 0; i < imageListPrducts.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem(); //ListView顯示單元
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]} {listPrice[i]}元";
                item.Font = new Font("微軟正黑體", 11, FontStyle.Regular);
                item.ForeColor = Color.Black;
                item.Tag = listPid[i]; //藏東西選Tag ->藏ID (不會顯示出來但可以儲存資訊
                listViewMenu.Items.Add(item);
            }
        }

        private void listViewMenu_ItemActivate(object sender, EventArgs e)
        {
            ProductDetail productDetail = new ProductDetail();
            productDetail.selectID = (int)listViewMenu.SelectedItems[0].Tag;
            //productDetail.getorderid = getorderid;
            productDetail.ShowProductDetail(productDetail.selectID);
            productDetail.pictureBoxAddShopping.Visible = true;
            productDetail.ShowDialog();
        }
        //public int getorderid = 0;


        private void btnGOShpping_Click(object sender, EventArgs e)
        {
            // 建立 ShoppingCar 表單
            ShoppingCar shoppingcar = new ShoppingCar();
            //shoppingcar.getorderid = getorderid;
            
            // 檢查是否存在 HomePage 的執行個體
            HomePage homepage = Application.OpenForms.OfType<HomePage>().FirstOrDefault();
            if (homepage != null)
            {
                // 將 ShoppingCar 表單加入 HomePage 的 panel2 中
                shoppingcar.TopLevel = false;
                shoppingcar.Dock = DockStyle.Fill;
                shoppingcar.getcid = getcid;
                homepage.panel2.Controls.Clear();
                homepage.panel2.Controls.Add(shoppingcar);
                shoppingcar.Show();
            }
        }
    }
}
