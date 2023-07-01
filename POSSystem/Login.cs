using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSSystem
{
    public partial class Login : Form
    {
        //public int getorderid;
        //public int getsum;
        int CID;
        public bool islogin = false;
        string C_Name;
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
            scsb.IntegratedSecurity = true;

            strDBConnetionString = scsb.ConnectionString;
            gBox登入.Visible = true;
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
            if ((txtAcconunt_Add.Text != "") && (txtPassword_Add.Text != "") && (txtName_Add.Text != "") && (txtPhone_Add.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();

                string strSQL = "insert into customer (C_Name, Phone, Address, Email, Birth, Account, Password) values(@NewName, @NewhPhone, @NewAddress, @NewEmail, @NewBirth, @NewAccount, @NewPassword);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName_Add.Text);
                cmd.Parameters.AddWithValue("@NewhPhone", txtPhone_Add.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress_Add.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail_Add.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth_Add.Value);
                cmd.Parameters.AddWithValue("@NewAccount", txtAcconunt_Add.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword_Add.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料建立成功,前往登入吧!");
                gBox建立新會員.Visible = false;
                gBox登入.Visible = true;
            }
            else
            {
                MessageBox.Show("帳號,密碼,姓名,電話必填!");
            }
        }

        private void btn清空欄位_Click_1(object sender, EventArgs e)
        {
            txtAcconunt_Add.Text = "";
            txtPassword_Add.Text = "";
            txtName_Add.Text = "";
            txtPhone_Add.Text = "";
            txtAddress_Add.Text = "";
            txtEmail_Add.Text = "";
            dtpBirth_Add.Value = DateTime.Now;
        }

        void check()
        {
            if ((txtAcconunt_Login.Text != "") || (txtPassword_Login.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from customer where Account = @SearchAcconunt and Password = @SearchPassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchAcconunt", $"{txtAcconunt_Login.Text}");
                cmd.Parameters.AddWithValue("@SearchPassword", $"{txtPassword_Login.Text}");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    CID = (int)reader["C_ID"];
                    C_Name = reader["C_Name"].ToString();
                    //txtAcconunt_Login.Text = reader["Account"].ToString();
                    //txtPassword_Login.Text = reader["Password"].ToString();
                    islogin = true;
                }
                else
                {
                    MessageBox.Show("帳號密碼錯誤");
                    txtAcconunt_Login.Clear();
                    txtPassword_Login.Clear();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnLoginClick_1(object sender, EventArgs e)
        {
            check();
            if (islogin==true)
            {
                //islogin = true;
                MessageBox.Show($"welcome {C_Name} !");
                HomePage homepage = new HomePage();
                homepage.getcid = CID;
                homepage.islogin = islogin;
                homepage.Show();
                //Checkout checkout = new Checkout();
                //checkout.getsum = getsum;
                //checkout.CID = CID;

                this.Hide();
                //checkout.ShowDialog();
            }
            //else
            //{
            //    MessageBox.Show("尚未登入");
            //}
}

        private void btnGuests_Click(object sender, EventArgs e)
        {
            islogin = false;
            MessageBox.Show($"訪客登入成功");

            HomePage homepage = new HomePage();
            homepage.islogin = islogin;
            homepage.Show();

            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.EnterPage.Show();
        }
        bool isImageDisplayed = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isImageDisplayed)
            {
                pictureBox1.Image = Properties.Resources.cool_569584;
                txtPassword_Login.PasswordChar = '*';
                isImageDisplayed = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.happy_569501;
                txtPassword_Login.PasswordChar = '\0';
                isImageDisplayed = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isImageDisplayed)
            {
                pictureBox2.Image = Properties.Resources.cool_569584;
                txtPassword_Add.PasswordChar = '*';
                isImageDisplayed = false;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.happy_569501;
                txtPassword_Add.PasswordChar = '\0';
                isImageDisplayed = true;
            }
        }

        private void btn忘記密碼_Click(object sender, EventArgs e)
        {
            MessageBox.Show("請聯繫管理員");
        }
    }
}
