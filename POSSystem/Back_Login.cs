using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POSSystem
{
    public partial class Back_Login : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnetionString = "";
        bool islogin = false;
        string EName;
        int EID;
        public Back_Login()
        {
            InitializeComponent();
        }

        private void Back_Login_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;

            strDBConnetionString = scsb.ConnectionString;
        }
        public bool isSystemOFF { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            check();
            if (islogin == true)
            {
                if (isSystemOFF == true)
                {
                    Back_Center back_center = new Back_Center();
                    back_center.isSystemOFF = true;
                    back_center.EID = EID;
                    back_center.Show();
                    this.Hide();
                }
                else
                {
                    Back_Center back_center = new Back_Center();
                    back_center.EID = EID;
                    back_center.Show();
                    this.Hide();
                }
            }

        }
        void check()
        {
            if ((txtAcconunt_Login.Text != "") || (txtPassword_Login.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from Employees where E_Account = @SearchAcconunt and E_Password = @SearchPassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchAcconunt", $"{txtAcconunt_Login.Text}");
                cmd.Parameters.AddWithValue("@SearchPassword", $"{txtPassword_Login.Text}");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    EName = reader["E_Name"].ToString();
                    EID = (int)reader["E_ID"];
                    islogin = true;
                    MessageBox.Show($"{EName}進來了!");
                }
                else
                {
                    MessageBox.Show("帳號密碼錯誤");
                }
                reader.Close();
                con.Close();
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.EnterPage.Show();
        }

        private void btn忘記密碼_Click(object sender, EventArgs e)
        {
            MessageBox.Show("問店長");
        }
    }
}
