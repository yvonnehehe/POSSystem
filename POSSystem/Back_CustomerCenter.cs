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
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnetionString = "";
        List<int> searchResultIDs = new List<int>();
        public int EID { get; set; }


        private void Back_CustomerCenter_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;

            strDBConnetionString = scsb.ConnectionString;

            //欄位預設值指定
            cboxSearchTag.Items.Add("C_Name");
            cboxSearchTag.Items.Add("Phone");
            cboxSearchTag.Items.Add("Address");
            cboxSearchTag.Items.Add("Email");
            cboxSearchTag.SelectedIndex = 0;

            產生會員資料列表DataGridView();

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
                    txtAccount.Text = reader["Account"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
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
            txtAccount.Clear();
            txtPassword.Clear();
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
                string strSQL = "update customer set C_Name = @NewName, Phone = @NewhPhone, Address = @NewAddress, Email = @NewEmail, Birth = @NewBirth, Point = @NewPoints, Account = @NewAccount, Password = @NewPassword where C_ID = @searchID;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txtCName.Text);
                cmd.Parameters.AddWithValue("@NewhPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth.Value);
                cmd.Parameters.AddWithValue("@NewAccount", txtAccount.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
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

                string strSQL = "insert into customer values(@NewName, @NewhPhone, @NewAddress, @NewEmail, @NewBirth, @NewPoints,@NewAccount,@NewPassword);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtCName.Text);
                cmd.Parameters.AddWithValue("@NewhPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth.Value);
                cmd.Parameters.AddWithValue("@NewAccount", txtAccount.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
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
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                //string strSQL = "delete from customer where C_ID=@searchID;";
                //SqlCommand cmd = new SqlCommand(strSQL, con);
                //cmd.Parameters.AddWithValue("@searchID", intID);

                string strSQL = "DELETE FROM Customer WHERE C_ID = @searchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);

                string strSQL2 = "UPDATE Orders SET C_ID = NULL WHERE C_ID = @searchID;";
                SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                cmd2.Parameters.AddWithValue("@searchID", intID);


                if (MessageBox.Show("確認刪除會員資料", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //int rows = cmd.ExecuteNonQuery();
                    //con.Close();
                    //MessageBox.Show($"會員資料刪除成功,{rows}筆資料受影響");


                    SqlTransaction transaction = con.BeginTransaction();
                    try
                    {
                        cmd2.Transaction = transaction;
                        int customerRowsAffected = cmd2.ExecuteNonQuery();

                        cmd.Transaction = transaction;
                        int ordersRowsAffected = cmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show($"會員資料刪除成功");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"刪除會員資料時出現錯誤：{ex.Message}");
                    }
                    finally
                    {
                        con.Close();
                    }

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
                    string strSQL = $"select * from customer where ( Birth > @BirthStart and Birth < @BirthEnd ) and ({str搜尋欄位名稱} like @SearchKeyword) and (Point > @PointStart and Point <= @PointEnd )  ";

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
                    cmd.Parameters.AddWithValue("@PointStart", txtPointstart.Text);
                    cmd.Parameters.AddWithValue("@PointEnd", txtPointEnd.Text);
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
                string strSQL = $"select * from customer where C_ID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                //指定參數賦予他的值
                cmd.Parameters.AddWithValue("@SearchID", selectedID);
                SqlDataReader reader = cmd.ExecuteReader();
                //reader只有一筆資料
                if (reader.Read() == true)
                {
                    txtID.Text = reader["C_ID"].ToString();
                    txtCName.Text = reader["C_Name"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    dtpBirth.Value = Convert.ToDateTime(reader["Birth"]);
                    txtPoint.Text = reader["Point"].ToString();
                    txtAccount.Text = reader["Account"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
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
            string strSQL = "select C_ID as 會員編號,C_Name as 姓名, Phone as 電話,Email, Point as 點數 from customer;";
            SqlCommand cmd = new SqlCommand(@strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader); //資料讀進去
                dgv會員列表.DataSource = dt; //取出資料
            }
            reader.Close();
            con.Close();
        }

        private void dgv會員列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Cell -> 儲存格 Click -> 點擊  DataGridViewCellEventArgs e e為儲存格事件 Rowindex列索引值
            if (e.RowIndex >= 0) //選擇某一列 就會>1
            {
                string strSelectedID = dgv會員列表.Rows[e.RowIndex].Cells[0].Value.ToString();//取得儲存格上面的值對應到的欄位[0]->ID
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
                    txtAccount.Text = reader["Account"].ToString();
                    txtPassword.Text = reader["Password"].ToString();

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back_Center BC = new Back_Center();
            BC.EID = EID;
            this.Close();
            BC.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            產生會員資料列表DataGridView();
        }
    }
}