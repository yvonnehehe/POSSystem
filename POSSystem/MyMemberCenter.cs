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
    public partial class MyMemberCenter : Form
    {
        int intID = 0; //先預設 之後要改

        public MyMemberCenter()
        {
            InitializeComponent();
        }
        //欄位 方便存取
        //資料庫連線字串建立器
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();//資料庫連線字串建立
        string strDBConnetionString = ""; //資料庫連線字串

        private void MyMemberCenter_Load(object sender, EventArgs e)
        {
            txtID.Text = "1";
            //建立資料庫連線字串 沒精靈只能自己來
            //DataSource 是伺服器名稱 @-忽略特殊符號
            scsb.DataSource = @"."; //伺服器名稱：. , localhost , 192.168.0.55 , 機器名稱 , DESKTOP-UQUJ8R9 , dbserver1/sq12019
            scsb.InitialCatalog = "IspanPersonalProject_POS"; //資料庫名稱
            scsb.IntegratedSecurity = true; //win驗證為true  如為SQLsever要設定flase

            strDBConnetionString = scsb.ConnectionString; //上面設定的內容都轉換成字串
                                                          //姓名搜尋 只能查一筆資料!!
            if (txtID.Text != "") //姓名欄位不能是空字串
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from customer where C_ID like @SearchID;"; //先放一個參數@
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //指定參數賦予他的值
                cmd.Parameters.AddWithValue("@SearchID", $"%{txtID.Text}%"); //把參數值換回欄位名稱 這樣比較安全(SQL Injection漏洞) 帶進去的參數不能有SQL語法 不然會被入侵
                SqlDataReader reader = cmd.ExecuteReader();
                //reader只有一筆資料
                if (reader.Read() == true) //只有搜尋一筆資料不用外迴圈
                {
                    txtID.Text = reader["C_ID"].ToString();  //reader[key]讀出來是object 要轉型態
                    txtCName.Text = reader["C_Name"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    dtpBirth.Value = Convert.ToDateTime(reader["Birth"]);
                    txtPoint.Text = reader["Point"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            //intID = Convert.ToInt32(txtID.Text);
            Int32.TryParse(txtID.Text, out intID);
            if ((intID > 0) && (txtCName.Text != "") && (txtPhone.Text != "")) //後面兩個為欄位檢查
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = "update customer set C_Name = @NewName, Phone = @NewhPhone, Address = @NewAddress, Email = @NewEmail, Birth = @NewBirth where C_id = @searchID;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txtCName.Text);
                cmd.Parameters.AddWithValue("@NewhPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth.Value);
                int intPoints = 0;
                Int32.TryParse(txtPoint.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);

                int rows = cmd.ExecuteNonQuery(); //ExecuteNonQuery-只執行不查詢 回傳你執行的語法所影響的筆數
                con.Close();
                MessageBox.Show($"會員資料已修改, {rows}筆資料受影響");

            }

        }
    }
}
