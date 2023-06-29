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
    public partial class Checkout : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public int sum;
        public int CID;
        List<int> listPoint = new List<int>();
        public Checkout()
        {
            InitializeComponent();
            labSum.Text = sum.ToString();
        }
        private void Checkout_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;
        }

        //我要找CID的Point
        void 讀取商品資料庫()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from customer where C_ID like @SearchCID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchCID", CID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                labePoint.Text = reader["Point"].ToString();
            }
            reader.Close();
            con.Close();
        }
    }
}
