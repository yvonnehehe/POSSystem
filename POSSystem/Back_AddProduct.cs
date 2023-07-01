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
    public partial class Back_AddProduct : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        string strImageDir = @"..\productsimage";

        public int selectID = 0;
        string image_modify_name = "";
        bool is修改圖檔 = false;

        public Back_AddProduct()
        {
            InitializeComponent();
        }

        private void Back_AddProduct_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString;

            if (selectID == 0)
            {//新增模式
                groupBox商品新增.Visible = true;
                groupBox商品修改.Visible = false;
            }
            else
            {//修改模式
                groupBox商品新增.Visible = false;
                groupBox商品修改.Visible = true;
            }
            ShowProductDetail();
        }
        void ShowProductDetail()
        {
            if (selectID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from products where P_ID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", selectID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txtID.Text = reader["P_ID"].ToString();
                    txt商品名稱.Text = reader["P_Name"].ToString();
                    txt商品價格.Text = reader["Price"].ToString();
                    txt商品描述.Text = reader["P_Desc"].ToString();
                    txtList.Text = reader["List_ID"].ToString();
                    //圖檔變動 上傳的圖檔以隨機命名產生檔名(不然會有重複)
                    image_modify_name = reader["P_Image"].ToString();
                    string 完整圖檔路徑 = strImageDir + "\\" + image_modify_name;
                    pictureBox商品圖檔.Image = Image.FromFile(完整圖檔路徑);
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn選取商品照片_修改_Click(object sender, EventArgs e)
        {
            選擇商品圖片();
        }

        private void btn儲存修改_修改_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {   //存進資料庫
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "UPDATE products SET P_Name=@NewPName, Price=@NewPrice, P_Desc=@NewPdesc, P_Image=@NewPimage, List_ID = @NewList where P_ID = @selectID ;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@selectID", selectID);
                cmd.Parameters.AddWithValue("@NewPName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewList", txtList.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_modify_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true) //確認圖片可以顯示才能存
                {
                    string 完整圖檔路徑 = strImageDir + "\\" + image_modify_name;
                    pictureBox商品圖檔.Image.Save(完整圖檔路徑); //先存檔
                    is修改圖檔 = false;
                }

                MessageBox.Show($"{rows}資料更新成功");
            }

        }

        private void btn選取商品照片_新增_Click(object sender, EventArgs e)
        {
            選擇商品圖片();

        }
        void 選擇商品圖片()
        {
            OpenFileDialog f = new OpenFileDialog();
            //檔案選取過濾器  ->  描述(可寫任一字串(提示))|*.副檔名;隔開
            //意思是按下去後 搜尋本機的照片只會搜尋的到這些副檔名的檔案
            f.Filter = "檔案類型(*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            DialogResult R = f.ShowDialog();
            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName); //f.fileName完整檔案路徑
                string 檔案副檔名 = System.IO.Path.GetExtension(f.SafeFileName).ToLower();
                //SafeFileName不包含路徑的檔名
                //ToLower副檔名通通變小寫

                //合成檔名 日期時間+4位數的隨機數1000~10000
                Random myRnd = new Random();
                image_modify_name = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + 檔案副檔名; ;
                is修改圖檔 = true;
                Console.WriteLine(image_modify_name);
            }
        }

        private void btn儲存商品_新增_Click(object sender, EventArgs e)
        {
            if ((txt商品名稱.Text != "") && (txt商品價格.Text != "") && (txt商品描述.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                //存進資料庫
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into products values (@NewPName, @NewPrice, @NewPdesc, @NewPimage,@NewList);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", txt商品描述.Text);
                cmd.Parameters.AddWithValue("@NewList", txtList.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_modify_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔 == true) //確認圖片可以顯示才能存
                {
                    string 完整圖檔路徑 = strImageDir + "\\" + image_modify_name;
                    pictureBox商品圖檔.Image.Save(完整圖檔路徑); //先存檔
                    is修改圖檔 = false;
                }

                MessageBox.Show($"{rows}資料新增成功");
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }

        }

        private void btn清空欄位_新增_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txt商品名稱.Clear();
            txt商品價格.Clear();
            txt商品描述.Clear();
            txtList.Clear();
            pictureBox商品圖檔.Image = null; //物件型式只能用null

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Back_ProductCenter BP = new Back_ProductCenter();
            this.Close();
        }
    }
}
