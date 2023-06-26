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
    public partial class CreateMember : Form
    {
        public CreateMember()
        {
            InitializeComponent();
        }
        //欄位 方便存取
        //資料庫連線字串建立器
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();//資料庫連線字串建立
        string strDBConnetionString = ""; //資料庫連線字串

        private void btnCreatMember_Click(object sender, EventArgs e)
        {
            if ((txtCName.Text != "") && (txtPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnetionString);
                con.Open();

                string strSQL = "insert into customer (C_Name, Phone, Address, Email, Birth) values(@NewName, @NewhPhone, @NewAddress, @NewEmail, @NewBirth);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtCName.Text);
                cmd.Parameters.AddWithValue("@NewhPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth.Value);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"會員資料新增成功,{rows}筆資料受影響");
            }
            else
            {
                MessageBox.Show("姓名,電話必填");
            }

        }

        private void CreateMember_Load(object sender, EventArgs e)
        {
            //建立資料庫連線字串 沒精靈只能自己來
            //DataSource 是伺服器名稱 @-忽略特殊符號
            scsb.DataSource = @"."; //伺服器名稱：. , localhost , 192.168.0.55 , 機器名稱 , DESKTOP-UQUJ8R9 , dbserver1/sq12019
            scsb.InitialCatalog = "IspanPersonalProject_POS"; //資料庫名稱
            scsb.IntegratedSecurity = true; //win驗證為true  如為SQLsever要設定flase

            strDBConnetionString = scsb.ConnectionString; //上面設定的內容都轉換成字串
        }
    }
}
