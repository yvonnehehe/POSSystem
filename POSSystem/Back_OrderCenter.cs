﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POSSystem.Back_Center;


namespace POSSystem
{
    public partial class Back_OrderCenter : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnetionString = "";
        public int EID { get; set; }

        public Back_OrderCenter()
        {
            InitializeComponent();
        }
        private void Back_OrderCenter_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;

            strDBConnetionString = scsb.ConnectionString;
            產生訂單資料列表DataGridView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back_Center BC = new Back_Center();
            BC.EID = EID;
            this.Close();
            BC.Visible = true;
        }

        void 產生訂單資料列表DataGridView()
        {
            dgvOList.Columns.Clear();
            SqlConnection con = new SqlConnection(strDBConnetionString);
            con.Open();
            //string strSQL = "select O_ID as 訂單編號, C_ID as 客戶編號, OrderDate as 訂單時間, PaymentMethod as 支付方式 from Orders;";
            string strSQL = "SELECT od.O_ID AS 訂單編號, o.C_ID AS 客戶編號, SUM(od.Subtotal) AS 訂單金額, o.OrderDate AS 訂單時間, o.PaymentMethod AS 支付方式 FROM Orders AS o INNER JOIN OrderDetail AS od ON o.O_ID = od.O_ID GROUP BY od.O_ID, o.C_ID, o.OrderDate, o.PaymentMethod;";
            SqlCommand cmd = new SqlCommand(@strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("訂單編號");
                dt.Columns.Add("客戶編號");
                dt.Columns.Add("訂單金額");
                dt.Columns.Add("訂單時間");
                dt.Columns.Add("支付方式");

                int totalAmount = 0; //統計總金額

                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["訂單編號"] = reader["訂單編號"];

                    // 判斷C_ID是否為 NULL，如果是為訪客
                    if (reader["客戶編號"] == DBNull.Value)
                    {
                        row["客戶編號"] = "訪客";
                    }
                    else
                    {
                        row["客戶編號"] = reader["客戶編號"];
                    }
                    int subtotal = (int)reader["訂單金額"];
                    row["訂單金額"] = subtotal;
                    //row["訂單金額"] = reader["訂單金額"];
                    row["訂單時間"] = reader["訂單時間"];
                    row["支付方式"] = reader["支付方式"];
                    dt.Rows.Add(row);
                    totalAmount += subtotal;
                }
                dgvOList.DataSource = dt;
                labTotalPrice.Text = "營業額統計 NT$ " + totalAmount.ToString();

            }
            reader.Close();
            con.Close();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Modify";
            btn.HeaderText = "操作";
            btn.DefaultCellStyle.NullValue = "修改";
            dgvOList.Columns.Add(btn);

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.Name = "del";
            btn2.HeaderText = "操作";
            btn2.DefaultCellStyle.NullValue = "删除";
            dgvOList.Columns.Add(btn2);

            dgvOList.Columns["訂單時間"].Width = 200;

        }

        private void dgvOList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvOList.Columns[e.ColumnIndex].Name == "Modify")
            {
                //點第一行btn
                //int index = dgvOList.SelectedCells[0].RowIndex;
                //int index = dgvOList.SelectedCells[0].RowIndex;
                //var oid = (int)dgvOList.Rows[e.RowIndex].Cells["訂單編號"].Value;
                if (int.TryParse(dgvOList.Rows[e.RowIndex].Cells["訂單編號"].Value.ToString(), out int oid))
                {
                    //var CID = dgvOList.Rows[oid].Cells[1].Value;
                    //var PM = dgvOList.Rows[oid].Cells[3].Value;
                    var CID = dgvOList.Rows[e.RowIndex].Cells[1].Value;
                    var PM = dgvOList.Rows[e.RowIndex].Cells[4].Value;
                    //int rowIndex = e.RowIndex; // 獲取所選行的索引值
                    //找到所在的行列
                    //
                    if (oid > 0)
                    {

                        SqlConnection con = new SqlConnection(strDBConnetionString);
                        con.Open();
                        string strSQL = "update orders set C_ID = @NewCID, PaymentMethod = @NewPM where O_ID = @searchID;";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@searchID", oid);
                        cmd.Parameters.AddWithValue("@NewCID", CID);
                        cmd.Parameters.AddWithValue("@NewPM", PM);

                        int rows = cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"訂單資料已修改, {rows}筆資料受影響");
                        產生訂單資料列表DataGridView();
                    }
                }
            }
            else if (this.dgvOList.Columns[e.ColumnIndex].Name == "del")
            {
                //
                if (int.TryParse(dgvOList.Rows[e.RowIndex].Cells["訂單編號"].Value.ToString(), out int oid))
                {
                    SqlConnection con = new SqlConnection(strDBConnetionString);
                    con.Open();
                    string strSQL = "DELETE od FROM Orders as o inner JOIN OrderDetail as od ON o.O_ID = od.O_ID WHERE o.O_ID = @searchID;";
                    string strSQL2 = "DELETE FROM orders WHERE O_ID = @searchID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd.Parameters.AddWithValue("@searchID", oid);
                    cmd2.Parameters.AddWithValue("@searchID", oid);

                    if (MessageBox.Show("確認刪除訂單資料", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rows = cmd.ExecuteNonQuery();
                        int rows2 = cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show($"訂單資料刪除成功");
                        產生訂單資料列表DataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("欄位必選");
                }

                ////
                //MessageBox.Show("del");

            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvOList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0) //選擇某一列 就會>1
            //{
            //    string strSelectedID = dgvOList.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    int selectedID = 0;
            //    Int32.TryParse(strSelectedID, out selectedID);

            //    SqlConnection con = new SqlConnection(strDBConnetionString);
            //    con.Open();
            //    string strSQL = $"select * from Orders where O_ID = @SearchID;";
            //    SqlCommand cmd = new SqlCommand(strSQL, con);

            //    cmd.Parameters.AddWithValue("@SearchID", selectedID);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read() == true)
            //    {
            //        txtOID.Text = reader["O_ID"].ToString();
            //        txtCID.Text = reader["C_ID"].ToString();
            //        txtT.Text = reader["OrderDate"].ToString();
            //        txtPM.Text = reader["PaymentMethod"].ToString();

            //    }
            //    else
            //    {
            //        MessageBox.Show("查無此訂單");
            //        清空欄位();
            //    }
            //    reader.Close();
            //    con.Close();
            //}
        }
            //void 清空欄位()
            //{
            //    txtOID.Clear();
            //    txtCID.Clear();
            //    txtT.Clear();
            //    txtPM.Clear();
            //}

        

        //private void btnDataUpdate_Click(object sender, EventArgs e)
        //{
        //    int intID = 0; //查詢條件 可以衍伸到全部 因為沒有ID=0這個人
        //    //intID = Convert.ToInt32(txtID.Text);
        //    Int32.TryParse(txtOID.Text, out intID);
        //    if (intID > 0) //後面兩個為欄位檢查
        //    {
        //        SqlConnection con = new SqlConnection(strDBConnetionString);
        //        con.Open();
        //        string strSQL = "update orders set C_ID = @NewCID, PaymentMethod = @NewPM where O_ID = @searchID;";

        //        SqlCommand cmd = new SqlCommand(strSQL, con);
        //        cmd.Parameters.AddWithValue("@searchID", intID);
        //        cmd.Parameters.AddWithValue("@NewCID", txtCID.Text);
        //        cmd.Parameters.AddWithValue("@NewPM", txtPM.Text);

        //        int rows = cmd.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show($"訂單資料已修改, {rows}筆資料受影響");
        //    }

        //}

        //private void btnDeleteData_Click(object sender, EventArgs e)
        //{
        //    int intID = 0;
        //    Int32.TryParse(txtOID.Text, out intID);

        //    if (intID > 0)
        //    {
        //        SqlConnection con = new SqlConnection(strDBConnetionString);
        //        con.Open();
        //        string strSQL = "DELETE od FROM Orders as o inner JOIN OrderDetail as od ON o.O_ID = od.O_ID WHERE o.O_ID = @searchID;";
        //        string strSQL2 = "DELETE FROM orders WHERE O_ID = @searchID";
        //        SqlCommand cmd = new SqlCommand(strSQL, con);
        //        SqlCommand cmd2 = new SqlCommand(strSQL2, con);
        //        cmd.Parameters.AddWithValue("@searchID", intID);
        //        cmd2.Parameters.AddWithValue("@searchID", intID);

        //        if (MessageBox.Show("確認刪除訂單資料", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            int rows = cmd.ExecuteNonQuery();
        //            int rows2 = cmd2.ExecuteNonQuery();
        //            con.Close();
        //            MessageBox.Show($"訂單資料刪除成功");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("OID必填");
        //    }

        //}

        private void btn重新整理_Click(object sender, EventArgs e)
        {
            產生訂單資料列表DataGridView();
        }

        //private void dgvOList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //Back_OrderDetail OD = new Back_OrderDetail();
        //    //OD.getoid = (int)dgvOList.SelectedItems[0].Tag;
        //    //OD.ShowDialog();
        //    if (dgvOList.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dgvOList.SelectedRows[0];
        //        int oid = (int)selectedRow.Cells["訂單編號"].Value;
        //        Back_OrderDetail OD = new Back_OrderDetail();
        //        OD.getoid = oid;
        //        OD.ShowDialog();
        //        產生訂單資料列表DataGridView();
        //    }

        //    // 獲取選取的單元格
        //    if (dgvOList.SelectedCells.Count > 0)
        //    {
        //        DataGridViewCell selectedCell = dgvOList.SelectedCells[0];
        //        int oid = (int)dgvOList.Rows[selectedCell.RowIndex].Cells["訂單編號"].Value;
        //        Back_OrderDetail OD = new Back_OrderDetail();
        //        OD.getoid = oid;
        //        OD.ShowDialog();
        //        產生訂單資料列表DataGridView();
        //    }
        //}

        private void dgvOList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvOList.Rows[e.RowIndex];
                //    int oid = (int)selectedRow.Cells["訂單編號"].Value;

                //    Back_OrderDetail OD = new Back_OrderDetail();
                //    OD.getoid = oid;
                //    OD.ShowDialog();

                //    產生訂單資料列表DataGridView();
                //}
                int oid;
                if (int.TryParse(selectedRow.Cells["訂單編號"].Value.ToString(), out oid))
                {
                    Back_OrderDetail OD = new Back_OrderDetail();
                    OD.getoid = oid;
                    OD.ShowDialog();
                }
                else
                {
                    MessageBox.Show("無效的訂單編號");

                }
            }
        }

    }
}

