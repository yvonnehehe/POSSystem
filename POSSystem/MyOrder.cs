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
    public partial class MyOrder : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> listODID = new List<int>();
        List<int> listOID = new List<int>();
        List<string> listPM = new List<string>();
        List<int> listSubtotal = new List<int>();
        List<DateTime> listDate = new List<DateTime>();
        public int getcid { get; set; }
        public bool islogin { get; set; }

        public MyOrder()
        {
            InitializeComponent();
        }

        private void MyOrder_Load(object sender, EventArgs e)
        {
            //if(getcid > 0)
            //{
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
            ReadOrderData();
            if (islogin == true)
            {
                ShowListView();
            }
            else
            {
                MessageBox.Show("尚未登入");
            }
            //}
            //else
            //{ // TODO: 待寫未結帳之登入畫面
            //    MessageBox.Show("尚未登入");
            //}
        }

        public void ReadOrderData()
        {
            //SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            //scsb.DataSource = @".";
            //scsb.InitialCatalog = "IspanPersonalProject_POS";
            //scsb.IntegratedSecurity = true;
            //strDBConnectionString = scsb.ConnectionString;

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = @"SELECT  *
                             FROM orders as o inner join orderdetail as od on o.O_ID=od.O_ID
                             WHERE o.C_ID = @CID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@CID", getcid);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                listOID.Add((int)reader["O_ID"]);
                listODID.Add((int)reader["OrderDetail_ID"]);
                listDate.Add(Convert.ToDateTime(reader["OrderDate"]));
                listPM.Add(reader["PaymentMethod"].ToString());
                listSubtotal.Add((int)reader["Subtotal"]);
            }
            reader.Close();
            con.Close();

        }
        HashSet<int> processedOIDs = new HashSet<int>();
        public void ShowListView()
        {
            listViewOrder.Clear();
            listViewOrder.LargeImageList = null;
            listViewOrder.SmallImageList = null;
            listViewOrder.View = View.Details;
            //listViewProduct.Columns.Add("PID", 1);
            listViewOrder.Columns.Add("訂單編號", 80);
            listViewOrder.Columns.Add("訂單日期", 300);
            listViewOrder.Columns.Add("訂單金額", 200);
            listViewOrder.Columns.Add("支付方式", 200);
            listViewOrder.GridLines = true;//顯示格線
            listViewOrder.FullRowSelect = true;//選到某選項就會整列反白
            int count = 1;
            for (int i = 0; i < listOID.Count(); i++)
            {
                if (processedOIDs.Contains(listOID[i]))
                {
                    continue; // 如果已處理過該 OID，則跳過重複項目
                }
                ListViewItem listItem = new ListViewItem();
                listItem.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                listItem.Tag = listOID[i];
                //listItem.Text = listPID[i].ToString();
                listItem.Text =count.ToString();
                listItem.SubItems.Add(listDate[i].ToString());
                //int count = listSubtotal[i];
                int sum=0;
                for (int j = 0; j < listOID.Count(); j++)
                {
                    if (listOID[j] == listOID[i])
                    {
                        sum += listSubtotal[j];
                    }
                }
                listItem.SubItems.Add(sum.ToString());
                listItem.SubItems.Add(listPM[i].ToString());

                listItem.ForeColor = Color.DarkBlue;
                listItem.BackColor = Color.LightGray;
                listViewOrder.Items.Add(listItem);
                processedOIDs.Add(listOID[i]); // 將該 OID 標記為已處理
                count++;
            }
        }

    }
}
