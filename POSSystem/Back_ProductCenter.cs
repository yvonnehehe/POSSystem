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
    public partial class Back_ProductCenter : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listPid = new List<int>();
        List<int> listListID = new List<int>();
        string strDBConnectionString = "";
        string strImageDir = @"..\productsimage";
        public int EID { get; set; }

        public Back_ProductCenter()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back_Center BC = new Back_Center();
            BC.EID = EID;
            this.Close();
            BC.Visible = true;
        }
        private void Back_ProductCenter_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            ReadProductData();
            ShowProductImage();
        }

        void ReadProductData()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from products";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read() == true)
            {
                listPid.Add((int)reader["P_ID"]);
                listProductName.Add((string)reader["P_Name"]);
                listPrice.Add((int)reader["Price"]);
                listListID.Add((int)reader["List_ID"]);
                string image_name = (string)reader["P_Image"];
                string 完整圖檔路徑 = strImageDir + "\\" + image_name;
                Image img商品圖檔 = Image.FromFile(完整圖檔路徑);
                imageList商品圖檔.Images.Add(img商品圖檔);
                count++;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"讀取{count}筆資料");
        }

        void ShowProductImage()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;//指定顯示模式 ->大圖  //LargeIcon(大圖版), SmallIcon(小圖版), List(列), Tile(固定高度,如果圖太大會被切掉)
            imageList商品圖檔.ImageSize = new Size(120, 120);//指定圖檔大小(最多256)
            listView商品展示.LargeImageList = imageList商品圖檔; //顯示大圖
            listView商品展示.SmallImageList = imageList商品圖檔; //顯示小圖 50*50 40*40 30*30

            //索引值對應
            for (int i = 0; i < imageList商品圖檔.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem(); //ListView顯示單元
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]} {listPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listPid[i]; //藏東西選Tag ->藏ID (不會顯示出來但可以儲存資訊
                listView商品展示.Items.Add(item);
            }
        }
        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            ShowProductImage();

        }
        void 顯示ListView列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("id", 100); //製作顯示欄位(欄位名稱,欄位寬度)
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("商品價格", 100);
            listView商品展示.Columns.Add("商品類別", 100);
            listView商品展示.GridLines = true;//顯示格線
            listView商品展示.FullRowSelect = true;//選到某選項就會整列反白
            for (int i = 0; i < listPid.Count; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                listItem.Tag = listPid[i];
                listItem.Text = listPid[i].ToString(); //第一欄是text 第二欄開始是SubItems
                listItem.SubItems.Add(listProductName[i]);
                listItem.SubItems.Add(listPrice[i].ToString());
                listItem.SubItems.Add(listListID[i].ToString());
                listItem.ForeColor = Color.DarkBlue;
                listItem.BackColor = Color.LightGray;

                listView商品展示.Items.Add(listItem);
            }

        }
        private void btn列表模式_Click(object sender, EventArgs e)
        {
            顯示ListView列表模式();
        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            Back_AddProduct back_AddProduct = new Back_AddProduct();
            back_AddProduct.ShowDialog();

        }
        void 重新載入資料()
        {
            listPid.Clear();
            listPrice.Clear();
            listProductName.Clear();
            imageList商品圖檔.Images.Clear();
            ReadProductData();
            if (listView商品展示.View == View.Details)
            {
                顯示ListView列表模式();
            }
            else
            {
                ShowProductImage();
            }
        }
        private void btn重新整理_Click(object sender, EventArgs e)
        {
            重新載入資料();

        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            Back_AddProduct back_AddProduct = new Back_AddProduct();
            back_AddProduct.selectID = (int)listView商品展示.SelectedItems[0].Tag;
            back_AddProduct.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn刪除商品_Click(object sender, EventArgs e)
        {
            if (listView商品展示.SelectedItems.Count > 0)
            {
                int selectID = (int)listView商品展示.SelectedItems[0].Tag;
                if (selectID > 0)
                {   //存進資料庫
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "Delete from products where P_ID = @selectID ;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@selectID", selectID);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show($"{rows}資料刪除成功");
                }
            }
            else
            {
                MessageBox.Show("未選取商品");
            }


        }
    }
}
