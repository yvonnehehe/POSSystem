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
using static POSSystem.Back_Center;


namespace POSSystem
{
    public partial class Back_OrderCenter : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnetionString = "";
        public Back_OrderCenter()
        {
            InitializeComponent();
        }
        private void Back_OrderCenter_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;

            strDBConnetionString = scsb.ConnectionString;
            產生訂單資料列表DataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back_Center BC = new Back_Center();
            this.Close();
            BC.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0) //選擇某一列 就會>1
            //{
            //    string strSelectedID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//取得儲存格上面的值對應到的欄位[0]->ID
            //    int selectedID = 0;
            //    Int32.TryParse(strSelectedID, out selectedID);

            //    SqlConnection con = new SqlConnection(strDBConnetionString);
            //    con.Open();
            //    string strSQL = $"select * from persons where id = @SearchID;"; //先放一個參數@
            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    //指定參數賦予他的值
            //    cmd.Parameters.AddWithValue("@SearchID", selectedID); //把參數值換回欄位名稱 這樣比較安全(SQL Injection漏洞) 帶進去的參數不能有SQL語法 不然會被入侵
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    reader只有一筆資料
            //    if (reader.Read() == true) //只有搜尋一筆資料不用外迴圈
            //    {
            //        txtID.Text = reader["id"].ToString();  //reader[key]讀出來是object 要轉型態
            //        txt姓名.Text = reader["姓名"].ToString();
            //        txt電話.Text = reader["電話"].ToString();
            //        txtEmail.Text = reader["email"].ToString();
            //        txt地址.Text = reader["地址"].ToString();
            //        dtp生日.Value = Convert.ToDateTime(reader["生日"]);
            //        chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
            //        txt點數.Text = reader["點數"].ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("查無此人");
            //        清空欄位();
            //    }
            //    reader.Close();
            //    con.Close();
            //}
        }
        void 產生訂單資料列表DataGridView()
        {

            SqlConnection con = new SqlConnection(strDBConnetionString);
            con.Open();
            string strSQL = "select O_ID as 訂單編號, C_ID as 客戶編號, OrderDate as 訂單時間, PaymentMethod as 支付方式 from Orders;";
            SqlCommand cmd = new SqlCommand(@strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows == true)
            //{
            //    DataTable dt = new DataTable();
            //    dt.Load(reader); //資料讀進去
            //    dataGridView1.DataSource = dt; //取出資料
            //    // 檢查欄位並設定訪客字串

            //}
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("訂單編號");
                dt.Columns.Add("客戶編號");
                dt.Columns.Add("訂單時間");
                dt.Columns.Add("支付方式");

                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["訂單編號"] = reader["訂單編號"];

                    // 判斷C_ID是否為 NULL，如果是為訪客
                    if (reader["客戶編號"] == DBNull.Value)
                    {
                        row["客戶編號"] = "訪客";
                    }
                    else
                    {
                        row["客戶編號"] = reader["客戶編號"];
                    }

                    row["訂單時間"] = reader["訂單時間"];
                    row["支付方式"] = reader["支付方式"];
                    dt.Rows.Add(row);
                }
                dataGridView1.DataSource = dt;
            }
            reader.Close();
            con.Close();
            dataGridView1.Columns["訂單時間"].Width = 200;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

