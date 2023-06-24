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

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            QueryProd(1);
        }

        private void btnFizz_Click(object sender, EventArgs e)
        {
            QueryProd(2);
        }

        private void btnTeaAndFlavorMilk_Click(object sender, EventArgs e)
        {
            QueryProd(3);
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            QueryProd(4);
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
        }
        void ShowlistView()
        {
            listViewMenu.View = View.LargeIcon;//指定顯示模式 ->大圖  //LargeIcon(大圖版), SmallIcon(小圖版), List(列), Tile(固定高度,如果圖太大會被切掉)
            imageListPrducts.ImageSize = new Size(120, 120);//指定圖檔大小(最多256)
            listViewMenu.LargeImageList = imageListPrducts; //顯示大圖
            listViewMenu.SmallImageList = imageListPrducts; //顯示小圖 50*50 40*40 30*30

            //索引值對應
            for (int i = 0; i < imageListPrducts.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem(); //ListView顯示單元
                item.ImageIndex = i;
                item.Text = $"{listProductName[i]} {listPrice[i]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Tag = listPid[i]; //藏東西選Tag ->藏ID (不會顯示出來但可以儲存資訊
                listViewMenu.Items.Add(item);
            }
        }

        private void listViewMenu_ItemActivate(object sender, EventArgs e)
        {
            ProductDetail productDetail = new ProductDetail();
            productDetail.selectID = (int)listViewMenu.SelectedItems[0].Tag;
            productDetail.ShowProductDetail(productDetail.selectID);
            productDetail.ShowDialog();
           
        }
    }
}
