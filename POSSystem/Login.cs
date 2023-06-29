﻿using System;
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
    public partial class Login : Form
    {
        public int getorderid;
        int CID;

        public Login()
        {
            InitializeComponent();
        }
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();//資料庫連線字串建立
        string strDBConnetionString = ""; //資料庫連線字串

        private void CreateMember_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true; //win驗證為true  如為SQLsever要設定flase

            strDBConnetionString = scsb.ConnectionString; //上面設定的內容都轉換成字串
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            gBox建立新會員.Visible = false;
            gBox登入.Visible = true;
        }

        private void btn建立新會員_Click(object sender, EventArgs e)
        {
            gBox登入.Visible = false;
            gBox建立新會員.Visible = true;
        }

        private void btnCreatMember_Click(object sender, EventArgs e)
        {
            if ((txtName_Add.Text != "") && (txtPhone_Add.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();

                string strSQL = "insert into customer (C_Name, Phone, Address, Email, Birth) values(@NewName, @NewhPhone, @NewAddress, @NewEmail, @NewBirth);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName_Add.Text);
                cmd.Parameters.AddWithValue("@NewhPhone", txtPhone_Add.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress_Add.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail_Add.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth_Add.Value);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"{rows}筆會員資料新增成功,前往登入吧!");
                gBox建立新會員.Visible = false;
                gBox登入.Visible = true;
            }
            else
            {
                MessageBox.Show("姓名,電話必填");
            }
        }

        private void btn清空欄位_Click_1(object sender, EventArgs e)
        {
            txtName_Add.Text = "";
            txtPhone_Add.Text = "";
            txtAddress_Add.Text = "";
            txtEmail_Add.Text = "";
            dtpBirth_Add.Value = DateTime.Now;

        }

        private void btn會員搜尋_Click_1(object sender, EventArgs e)
        {
            if ((txtName_Login.Text != "") && (txtPhone_Login.Text != "")) //姓名欄位不能是空字串
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from customer where C_Name like @SearchName;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", $"{txtName_Login.Text}");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    CID = (int)reader["C_ID"];
                    txtName_Login.Text = reader["C_Name"].ToString();
                    txtPhone_Login.Text = reader["Phone"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                    txtName_Login.Clear();
                    txtPhone_Login.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn結帳_Click_1(object sender, EventArgs e)
        {
            if ((txtName_Login.Text != "") && (txtPhone_Login.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();

                string strSQL = "UPDATE orders SET C_ID = @cid WHERE O_ID = @oid;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@oid", getorderid);
                cmd.Parameters.AddWithValue("@cid", CID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員登入成功");
                Checkout checkout = new Checkout();
                checkout.CID= CID;
                checkout.ShowDialog();

            }
            else
            {
                MessageBox.Show("姓名,電話必填");
            }


        }
    }
}