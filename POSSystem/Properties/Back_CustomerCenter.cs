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

namespace POSSystem.Properties
{
    public partial class Back_CustomerCenter : Form
    {
        public Back_CustomerCenter()
        {
            InitializeComponent();
        }
        //欄位 方便存取
        //資料庫連線字串建立器
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();//資料庫連線字串建立
        string strDBConnetionString = ""; //資料庫連線字串
        List<int> searchResultIDs = new List<int>(); //用ID的搜尋結果儲存在這

        private void Back_CustomerCenter_Load(object sender, EventArgs e)
        {
            //建立資料庫連線字串 沒精靈只能自己來
            //DataSource 是伺服器名稱 @-忽略特殊符號
            scsb.DataSource = @"."; //伺服器名稱：. , localhost , 192.168.0.55 , 機器名稱 , DESKTOP-UQUJ8R9 , dbserver1/sq12019
            scsb.InitialCatalog = "IspanPersonalProject_POS"; //資料庫名稱
            scsb.IntegratedSecurity = true; //win驗證為true  如為SQLsever要設定flase

            strDBConnetionString = scsb.ConnectionString; //上面設定的內容都轉換成字串

            //欄位預設值指定
            cboxSearchTag.Items.Add("C_Name");
            cboxSearchTag.Items.Add("Phone");
            cboxSearchTag.Items.Add("Address");
            cboxSearchTag.Items.Add("Email");
            cboxSearchTag.SelectedIndex = 0;

            產生會員資料列表DataGridView();

        }

        private void btnDataCount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnetionString);//SQL元件 資料庫連線的物件
            con.Open();//開啟他
            string strSQL = "select top 500 * from customer;";//建立SQL語法 「select *」如有過多資料會當機
            SqlCommand cmd = new SqlCommand(strSQL, con);  //SQL語法
            SqlDataReader reader = cmd.ExecuteReader(); //SQL資料讀取器

            string strMsg = "";//把查詢結果全部塞到字串
            int count = 0; //筆數
            while (reader.Read() == true)  //read=有回傳值 每次讀一筆如果有資料就會回傳true
            {
                int id = Convert.ToInt32(reader["C_ID"]);  //reader[key]讀出來是object 要轉型態
                string 姓名 = reader["C_Name"].ToString();
                string 電話 = reader["Phone"].ToString();
                string email = reader["Email"].ToString();
                string 地址 = reader["Address"].ToString();
                DateTime 生日 = Convert.ToDateTime(reader["Birth"]);
                int 會員點數 = Convert.ToInt32(reader["Point"]);

                strMsg += $"{id}{姓名}{電話}{email}{地址}{生日}\n";
                count++;
            }
            strMsg += $"資料筆數:{count}";
            reader.Close();
            con.Close();//先進後出 要先關掉reader才能關con 不然會當掉
            MessageBox.Show(strMsg);

        }

        private void btnDataSelect_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "") //姓名欄位不能是空字串
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from customer where C_Name like @SearchName;"; //先放一個參數@
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //指定參數賦予他的值
                cmd.Parameters.AddWithValue("@SearchName", $"%{txtCName.Text}%"); //把參數值換回欄位名稱 這樣比較安全(SQL Injection漏洞) 帶進去的參數不能有SQL語法 不然會被入侵
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
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }
        void 清空欄位()
        {
            txtID.Clear();
            txtCName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPoint.Clear();
            dtpBirth.Value = DateTime.Now;
        }

        private void btnDataUpdate_Click(object sender, EventArgs e)
        {
            int intID = 0; //查詢條件 可以衍伸到全部 因為沒有ID=0這個人
            //intID = Convert.ToInt32(txtID.Text);
            Int32.TryParse(txtID.Text, out intID);
            if ((intID > 0) && (txtCName.Text != "") && (txtPhone.Text != "")) //後面兩個為欄位檢查
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = "update customer set C_Name = @NewName, Phone = @NewhPhone, Address = @NewAddress, Email = @NewEmail, Birth = @NewBirth, Point = @NewPoints where C_ID = @searchID;";

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

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if ((txtCName.Text != "") && (txtPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();

                string strSQL = "insert into customer values(@NewName, @NewhPhone, @NewAddress, @NewEmail, @NewBirth, @NewPoints);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtCName.Text);
                cmd.Parameters.AddWithValue("@NewhPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth.Value);
                int intPoints = 0;
                Int32.TryParse(txtPoint.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料新增成功,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("姓名,電話必填");
            }

        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            int intID = 0; //查詢條件 可以衍伸到全部 因為沒有ID=0這個人
            //intID = Convert.ToInt32(txtID.Text);
            Int32.TryParse(txtID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = "delete from customer where C_ID=@searchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);

                if (MessageBox.Show("確認刪除會員資料", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"會員資料刪除成功,{rows}筆資料受影響");
                }
            }
            else
            {
                MessageBox.Show("ID必填");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btnAvancedSearch_Click(object sender, EventArgs e)
        {
            {
                if (txtSearchTag.Text != "")
                {
                    //進階搜尋欄位清空
                    lboxAdvancedSearchResults.Items.Clear();
                    //搜尋結果也要清空
                    searchResultIDs.Clear();
                    string str搜尋欄位名稱 = cboxSearchTag.SelectedItem.ToString();
                    string sqlID查詢語法 = "select * from customer where C_ID = @SearchID";

                    SqlConnection con = new SqlConnection(strDBConnetionString);
                    con.Open();
                    string strSQL = $"select * from customer where ( Birth > @BirthStart and Birth < @BirthEnd ) and {str搜尋欄位名稱} like @SearchKeyword";

                    if (cboxSearchTag.SelectedItem.ToString().ToLower() == "C_ID")
                    {
                        strSQL = sqlID查詢語法;
                    }
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    if (cboxSearchTag.SelectedItem.ToString().ToLower() == "C_ID")
                    {
                        int intID = 0;
                        Int32.TryParse(txtSearchTag.Text, out intID);
                        cmd.Parameters.AddWithValue("@searchID", intID);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txtSearchTag.Text}%");
                    }
                    cmd.Parameters.AddWithValue("@BirthStart", dtpBirthStart.Value);
                    cmd.Parameters.AddWithValue("@BirthEnd", dtpBirthEnd.Value);
                    SqlDataReader reader = cmd.ExecuteReader();


                    int count = 0;
                    while (reader.Read() == true)
                    {
                        searchResultIDs.Add((int)reader["C_ID"]);
                        lboxAdvancedSearchResults.Items.Add($"{reader["C_ID"]} {reader["C_Name"]} {reader["Phone"]}");
                        count++;
                    }
                    if (count == 0)
                    {
                        MessageBox.Show("查無此人");
                    }
                    reader.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("請輸入搜尋關鍵字");
                }

            }
        }

        private void lboxAdvancedSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxAdvancedSearchResults.SelectedIndex >= 0)
            {
                int selectedID = searchResultIDs[lboxAdvancedSearchResults.SelectedIndex]; //參考265

                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from customer where C_ID = @SearchID;"; //先放一個參數@
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //指定參數賦予他的值
                cmd.Parameters.AddWithValue("@SearchID", selectedID); //把參數值換回欄位名稱 這樣比較安全(SQL Injection漏洞) 帶進去的參數不能有SQL語法 不然會被入侵
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
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }

        }
        void 產生會員資料列表DataGridView()
        {
            SqlConnection con = new SqlConnection(strDBConnetionString);
            con.Open();
            string strSQL = "select C_ID as 會員編號, C_Name as 姓名, Phone as 電話, Email as 電子郵件 from customer;";
            SqlCommand cmd = new SqlCommand(@strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            //檢測reader有沒有資料
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader); //資料讀進去
                dgvCustomerList.DataSource = dt; //取出資料
            }
            reader.Close();
            con.Close();
        }

        private void dgv會員列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Cell -> 儲存格 Click -> 點擊  DataGridViewCellEventArgs e e為儲存格事件 Rowindex列索引值
            if (e.RowIndex >= 0) //選擇某一列 就會>1
            {
                string strSelectedID = dgvCustomerList.Rows[e.RowIndex].Cells[0].Value.ToString();//取得儲存格上面的值對應到的欄位[0]->ID
                int selectedID = 0;
                Int32.TryParse(strSelectedID, out selectedID);

                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from customer where C_ID = @SearchID;"; //先放一個參數@
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //指定參數賦予他的值
                cmd.Parameters.AddWithValue("@SearchID", selectedID); //把參數值換回欄位名稱 這樣比較安全(SQL Injection漏洞) 帶進去的參數不能有SQL語法 不然會被入侵
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
                    清空欄位();
                }
                reader.Close();
                con.Close();

            }
        }
    }
}