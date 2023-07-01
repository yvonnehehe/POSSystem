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
    public partial class Back_EmpolyeesCenter : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnetionString = "";
        List<int> searchResultIDs = new List<int>();
        public int EID { get; set; }

        public Back_EmpolyeesCenter()
        {
            InitializeComponent();
        }

        private void dgvEList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //選擇某一列 就會>1
            {
                string strSelectedID = dgvEList.Rows[e.RowIndex].Cells[0].Value.ToString();
                int selectedID = 0;
                Int32.TryParse(strSelectedID, out selectedID);

                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from Employees where E_ID = @SearchID;"; 
                SqlCommand cmd = new SqlCommand(strSQL, con);
       
                cmd.Parameters.AddWithValue("@SearchID", selectedID); 
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true) 
                {
                    txtID.Text = reader["E_ID"].ToString(); 
                    txtEName.Text = reader["E_Name"].ToString();
                    txtAccount.Text = reader["E_Account"].ToString();
                    txtPassword.Text = reader["E_Password"].ToString();

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

        private void Back_EmpolyeesCenter_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;

            strDBConnetionString = scsb.ConnectionString;

            產生會員資料列表DataGridView();

        }
        void 產生會員資料列表DataGridView()
        {
            SqlConnection con = new SqlConnection(strDBConnetionString);
            con.Open();
            string strSQL = "select E_ID as 員工編號,E_Name as 姓名, E_Account as 帳號,E_Password as 密碼 from Employees;";
            SqlCommand cmd = new SqlCommand(@strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader); 
                dgvEList.DataSource = dt;
            }
            reader.Close();
            con.Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            清空欄位();
        }
        void 清空欄位()
        {
            txtID.Clear();
            txtEName.Clear();
            txtAccount.Clear();
            txtPassword.Clear();
        }

        private void btnDataUpdate_Click(object sender, EventArgs e)
        {
            int intID = 0; //查詢條件 可以衍伸到全部 因為沒有ID=0這個人
            //intID = Convert.ToInt32(txtID.Text);
            Int32.TryParse(txtID.Text, out intID);
            if ((intID > 0) && (txtEName.Text != "")) //後面兩個為欄位檢查
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = "update Employees set E_Name = @NewName, E_Account = @NewAccount, E_Password = @NewPassword where E_ID = @searchID;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);
                cmd.Parameters.AddWithValue("@NewName", txtEName.Text);
                cmd.Parameters.AddWithValue("@NewAccount", txtAccount.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"員工資料已修改");
            }
            else
            {
                MessageBox.Show("姓名必填");
            }

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (txtEName.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();

                string strSQL = "insert into Employees values(@NewName, @NewAccount, @NewPassword);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtEName.Text);
                cmd.Parameters.AddWithValue("@NewAccount", txtAccount.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"員工資料新增成功,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("姓名必填");
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
                string strSQL = "delete from Employees where E_ID=@searchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intID);

                if (MessageBox.Show("確認刪除員工資料", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"員工資料刪除成功,{rows}筆資料受影響");
                }
            }
            else
            {
                MessageBox.Show("ID必填");
            }

        }
    }
}
