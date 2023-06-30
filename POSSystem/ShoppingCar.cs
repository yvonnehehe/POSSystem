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
    public partial class ShoppingCar : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";

        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listQuantity = new List<int>();
        List<int> listSubtotal = new List<int>();
        List<string> listSugar = new List<string>();
        List<string> listIce = new List<string>();
        List<bool> listEspresso = new List<bool>();
        List<int> listPID = new List<int>();
        List<int> listOID = new List<int>();
        List<int> listOrderDetailID = new List<int>();
        int sum;
        public int getcid { get; set; }
        public bool islogin { get; set; }

        public ShoppingCar()
        {
            InitializeComponent();
        }
        private void ShoppingCar_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            ReadOrderData();
            ShowListView();
        }
        //public int getorderid;
        private void ReadOrderData()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            //string strSQL = "SELECT * FROM orders WHERE O_ID = @OrderID";
            //SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@OrderID", getorderid);
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read() == true)
            //{
            //    listOrderID.Add((int)reader["O_ID"]);
            //    //listTotalPrice.Add((int)reader["TotalPrice"]); //未寫進總金額
            //}
            //reader.Close();

            // 使用 JOIN 子句合併 orderdetail 與 products 資料表
            string strSQL = @"SELECT  *
                                FROM orderdetail od
                                INNER JOIN products p ON od.P_ID = p.P_ID
                                WHERE od.O_ID is NULL";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@OrderID", getorderid);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                //listOID.Add((int)reader["O_ID"]);
                listOrderDetailID.Add((int)reader["OrderDetail_ID"]);
                listPID.Add((int)reader["P_ID"]);
                listQuantity.Add((int)reader["Quantity"]);
                listSubtotal.Add((int)reader["Subtotal"]);
                listSugar.Add((string)reader["Sugar"]);
                listIce.Add((string)reader["Ice"]);
                listEspresso.Add((bool)reader["Espresso"]);
                listProductName.Add((string)reader["P_Name"]);
                listPrice.Add((int)reader["Price"]);
            }
            reader.Close();
            con.Close();

        }

        public void ShowListView()
        {
            listViewProduct.Clear();
            listViewProduct.LargeImageList = null;
            listViewProduct.SmallImageList = null;
            listViewProduct.View = View.Details;
            //listViewProduct.Columns.Add("PID", 1);
            listViewProduct.Columns.Add("Name", 200);
            listViewProduct.Columns.Add("Price", 100);
            listViewProduct.Columns.Add("Quantity", 100);
            listViewProduct.Columns.Add("Sugar", 80);
            listViewProduct.Columns.Add("Ice", 80);
            listViewProduct.Columns.Add("Espresso", 100);
            listViewProduct.Columns.Add("Subtotal", 100);
            listViewProduct.GridLines = true;//顯示格線
            listViewProduct.FullRowSelect = true;//選到某選項就會整列反白
            for (int i = 0; i < listOrderDetailID.Count(); i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                listItem.Tag = listOrderDetailID[i];
                //listItem.Text = listPID[i].ToString();
                listItem.Text = listProductName[i];
                listItem.SubItems.Add(listPrice[i].ToString());
                listItem.SubItems.Add(listQuantity[i].ToString());
                listItem.SubItems.Add(listSugar[i]);
                listItem.SubItems.Add(listIce[i]);
                listItem.SubItems.Add(listEspresso[i].ToString());
                listItem.SubItems.Add(listSubtotal[i].ToString());
                listItem.ForeColor = Color.DarkBlue;
                listItem.BackColor = Color.LightGray;

                listViewProduct.Items.Add(listItem);
                sum += listSubtotal[i];
                labTotalPrice.Text = "TotalPrice  NT$ " + sum.ToString();
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            Menu menu = new Menu();
            menu.TopLevel = false;
            menu.Dock = DockStyle.None;
            homePage.panel2.Controls.Clear();
            homePage.panel2.Controls.Add(menu);
            menu.Show();
            homePage.Show();
            this.Hide();
        }

        private void listViewProduct_ItemActivate(object sender, EventArgs e)
        {
            ProductDetail productDetail = new ProductDetail();
            productDetail.ordertetailid = (int)listViewProduct.SelectedItems[0].Tag;
            //productDetail.shoppingoid = getorderid;
            productDetail.ReadOrderDetail(productDetail.ordertetailid);
            productDetail.btnAlter.Visible = true;
            productDetail.btnDetele.Visible = true;
            productDetail.ShowDialog();
            RefreshData();
        }
        void RefreshData()
        {
            sum = 0;
            listOID.Clear();
            listOrderDetailID.Clear();
            listPID.Clear();
            listProductName.Clear();
            listPrice.Clear();
            listProductName.Clear();
            listQuantity.Clear();
            listSugar.Clear();
            listIce.Clear();
            listSubtotal.Clear();
            listEspresso.Clear();
            ReadOrderData();
            ShowListView();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (sum > 0)
            {
                Checkout checkout = new Checkout();
                checkout.getcid = getcid;
                //login.getorderid = getorderid;
                checkout.getsum = sum;
                checkout.ShowDialog();
            }
            else
            {
                MessageBox.Show("未加入任何商品");
            }
        }
    }
}
