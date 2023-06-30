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
        //int intID = 0; //先預設 之後要改
        public int getcid { get; set; }
        public bool islogin { get; set; }


        public MyMemberCenter()
        {
            InitializeComponent();
        }

        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnetionString = "";

        private void MyMemberCenter_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnetionString = scsb.ConnectionString;

            if (islogin == true)
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = $"select * from customer where C_ID like @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", getcid);
                SqlDataReader reader = cmd.ExecuteReader();
                //reader只有一筆資料
                if (reader.Read() == true)
                {
                    getcid = (int)reader["C_ID"];
                    txtCName.Text = reader["C_Name"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    dtpBirth.Value = Convert.ToDateTime(reader["Birth"]);
                    txtPoint.Text = reader["Point"].ToString();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("尚未登入");
            }

        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            //intID = Convert.ToInt32(txtID.Text);
            //Int32.TryParse(txtID.Text, out intID);
            if ((getcid > 0) && (txtCName.Text != "") && (txtPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();
                string strSQL = "update customer set C_Name = @NewName, Phone = @NewhPhone, Address = @NewAddress, Email = @NewEmail, Birth = @NewBirth where C_id = @searchID;";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", getcid);
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
                MessageBox.Show($"會員資料已修改");

            }

        }
    }
}
