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
        List<string> listProductName = new List<string>();
        List<int> listPrice = new List<int>();
        List<int> listQuantity = new List<int>();
        List<int> listSubtotal = new List<int>();
        List<string> listSugar = new List<string>();
        List<string> listIce = new List<string>();
        List<bool> listEspresso = new List<bool>();
        List<int> listPID = new List<int>();
        List<int> listOrderID = new List<int>();
        List<int> listTotalPrice = new List<int>();
        string strDBConnectionString = "";

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

            ReadOrderData(getorderid);
            ShowListView();

        }
        public int getorderid=0;
        public void ReadOrderData(int orderid)
        {
            getorderid = orderid;
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
            if (getorderid > 0)
            {
                string strSQL = @"SELECT  *
                                FROM orderdetail od
                                INNER JOIN products p ON od.P_ID = p.P_ID
                                WHERE od.O_ID = @OrderID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@OrderID", getorderid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() == true)
                {
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
            else
            {
                MessageBox.Show("找不到oid");
            }
        }

        public void ShowListView()
        {
            if (getorderid > 0)
            {
                listViewProduct.Clear();
                listViewProduct.LargeImageList = null;
                listViewProduct.SmallImageList = null;
                listViewProduct.View = View.Details;
                listViewProduct.Columns.Add("Name", 200);
                listViewProduct.Columns.Add("Price", 100);
                listViewProduct.Columns.Add("Quantity", 100);
                listViewProduct.Columns.Add("Sugar", 100);
                listViewProduct.Columns.Add("Ice", 100);
                listViewProduct.Columns.Add("Espresso", 100);
                listViewProduct.Columns.Add("Subtotal", 100);
                listViewProduct.GridLines = true;//顯示格線
                listViewProduct.FullRowSelect = true;//選到某選項就會整列反白
                for (int i = 0; i < listPID.Count ; i++)
                {
                    ListViewItem listItem = new ListViewItem();
                    listItem.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                    listItem.Tag = listPID[i];
                    //listItem.Text = listOrderID[i].ToString(); //第一欄是text 第二欄開始是SubItems
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
                }
            }
            else
            {
                MessageBox.Show("找不到showoid");
            }

        }



        private void listViewProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            Menu menu = new Menu();
            menu.TopLevel = false;
            menu.Dock = DockStyle.Fill;
            homePage.panel2.Controls.Clear();
            homePage.panel2.Controls.Add(menu);
            menu.Show();
            homePage.Show();
            this.Hide();
        }

    }
}
