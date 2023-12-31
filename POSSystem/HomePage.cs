﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POSSystem.EnterPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSSystem
{
    public partial class HomePage : Form
    {
        //private bool isOrderCreated = false; // 追蹤訂單是否已創建

        public HomePage()
        {
            InitializeComponent();
            //if (!isOrderCreated)
            //{
            //    NewOrderID(orderID);
            //    isOrderCreated = true;
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //關閉表單會刪除orderid=null的訂單
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "IspanPersonalProject_POS";
            scsb.IntegratedSecurity = true;
            string strDBConnectionString = scsb.ConnectionString;

            using (SqlConnection con = new SqlConnection(strDBConnectionString))
            {
                con.Open();

                string deleteQuery = "DELETE FROM orderdetail WHERE O_ID IS NULL";

                using (SqlCommand command = new SqlCommand(deleteQuery, con))
                {
                    command.ExecuteNonQuery();
                }
            }
            Application.Exit();
        }

        private void btnBackEnterPage_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.EnterPage.Show();
        }

        //讓滑鼠點到panl3時可以拖曳視窗
        private bool isDragging = false;
        private Point dragStartPosition;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPosition = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Form form = FindForm();
                Point currentPosition = form.PointToScreen(e.Location);
                currentPosition.Offset(-dragStartPosition.X, -dragStartPosition.Y);
                form.Location = currentPosition;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        //拖曳視窗結束

        //改變視窗大小
        bool isMouseDown = false; //表示滑鼠是否在按下的狀態 
        MouseDirection direction = MouseDirection.None;//MouseDirection拖動方向
        public enum MouseDirection //拖動方向設定
        {
            Herizontal,//水平，只改變寬度
            Vertical,//垂直，只改變高度
            Declining,//斜角，同時改變寬和高
            None//不拖動
        }

        private void HomePage_MouseMove(object sender, MouseEventArgs e)
        {
            //調整大小
            //如果按下，同時有方向箭頭->调整大小
            if (isMouseDown && direction != MouseDirection.None)
            {
                //設定好方向後，執行下面方法，改變視窗大小  
                ResizeWindow();
                return;
            }

            //滑鼠拖曳過程中，座標在改变 
            //當滑鼠移動時X坐標距離視窗右邊缘5像素以内且Y坐標距離下邊缘也在5像素以内時，要將鼠標變傾斜的箭頭形狀，同時拖曳方向direction變為MouseDirection.Declining 
            if (e.Location.X >= this.Width - 5 && e.Location.Y > this.Height - 5)
            {
                this.Cursor = Cursors.SizeNWSE;
                direction = MouseDirection.Declining;
            }
            //當滑鼠移動時X坐標距離視窗右邊缘5像素以内时，要將鼠標變為傾斜的箭頭形狀，同時拖曳方向direction變為MouseDirection.Herizontal
            else if (e.Location.X >= this.Width - 5)
            {
                this.Cursor = Cursors.SizeWE;
                direction = MouseDirection.Herizontal;
            }
            //當滑鼠移動時Y坐標距離視窗右邊缘5像素以内时，要將鼠標變為傾斜的箭頭形狀，同時拖曳方向direction變為MouseDirection.Herizontal
            else if (e.Location.Y >= this.Height - 5)
            {
                this.Cursor = Cursors.SizeNS;
                direction = MouseDirection.Vertical;

            }
            //其他區域鼠標均為單向箭頭
            else
                this.Cursor = Cursors.Arrow;
        }

        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void HomePage_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            direction = MouseDirection.None;
        }
        void ResizeWindow()
        {
            //只有在滑鼠按下時才能拖曳改變視窗大小，如果不作判斷，那滑鼠放開或按下时，視窗都可以被改變 
            if (!isMouseDown)
                return;
            //MousePosition的参考點是螢幕的左上角，表示滑鼠目前相對於螢幕左上角的座標this.left和this.top的参考點也是螢幕
            if (direction == MouseDirection.Declining)
            {
                this.Cursor = Cursors.SizeNWSE;
                //改變視窗寬高
                this.Width = MousePosition.X - this.Left;
                this.Height = MousePosition.Y - this.Top;
            }
            if (direction == MouseDirection.Herizontal)
            {
                this.Cursor = Cursors.SizeWE;
                this.Width = MousePosition.X - this.Left;
            }
            else if (direction == MouseDirection.Vertical)
            {
                this.Cursor = Cursors.SizeNS;
                this.Height = MousePosition.Y - this.Top;
            }
            else
                this.Cursor = Cursors.Arrow;
        }


        private void btnGoShoppingCar_Click(object sender, EventArgs e)
        {
            ShoppingCar shoppingcar = new ShoppingCar();
            //shoppingcar.getorderid = orderID;//給oid
            shoppingcar.getcid = getcid;
            shoppingcar.TopLevel = false;
            shoppingcar.Dock = DockStyle.Fill;
            shoppingcar.islogin = islogin;
            panel2.Controls.Clear();
            panel2.Controls.Add(shoppingcar);
            shoppingcar.Show();
        }
        //建立新訂單
        //int orderID;

        //public void NewOrderID(int newOid)
        //{
        //    SqlConnectionStringBuilder scsb2 = new SqlConnectionStringBuilder();
        //    scsb2.DataSource = @".";
        //    scsb2.InitialCatalog = "IspanPersonalProject_POS";
        //    scsb2.IntegratedSecurity = true;
        //    string strDBConnectionString2 = scsb2.ConnectionString;

        //    SqlConnection con = new SqlConnection(strDBConnectionString2);
        //    con.Open();

        //    if (orderID == 0) //檢查是否已經有一個訂單進行中，如果沒有則創建新的訂單
        //    {
        //        string getMaxOid = "SELECT MAX(O_ID) FROM orders;";
        //        SqlCommand cmd = new SqlCommand(getMaxOid, con);
        //        int maxOid = 0;

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                if (!reader.IsDBNull(0))
        //                {
        //                    maxOid = reader.GetInt32(0);
        //                }
        //            }
        //        }
        //        newOid = maxOid + 1;

        //        string insertNewOrder = "INSERT INTO orders (O_ID,OrderDate) VALUES (@NewOid,@NewTime);";
        //        SqlCommand cmd2 = new SqlCommand(insertNewOrder, con);
        //        cmd2.Parameters.AddWithValue("@NewOid", newOid);
        //        cmd2.Parameters.AddWithValue("@NewTime", DateTime.Now);
        //        cmd2.ExecuteNonQuery();
        //        orderID = newOid;
        //    }
        //    con.Close();
        //}

        private void btnEnterMenu_Click(object sender, EventArgs e) //待刪除
        {
            Menu menu = new Menu();
            //menu.getorderid = orderID;//給oid

            menu.TopLevel = false;
            menu.Dock = DockStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(menu);
            menu.Show();
        }

        public void btnGoMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.TopLevel = false;
            menu.getcid = getcid;
            menu.islogin = islogin;
            menu.Dock = DockStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(menu);
            menu.Show();
        }

        public void btnGoMyOrder_Click(object sender, EventArgs e)
        {
            MyOrder myOrder = new MyOrder();
            myOrder.getcid = getcid;//給oid
            myOrder.TopLevel = false;
            myOrder.Dock = DockStyle.None;
            myOrder.islogin = islogin;
            panel2.Controls.Clear();
            panel2.Controls.Add(myOrder);
            myOrder.Show();
        }
        public int getcid { get; set; }
        //public void showmyorder(int CID)
        //{
        //    MyOrder myOrder = new MyOrder();
        //    //menu.getorderid = orderID;//給oid
        //    myOrder.getcid = CID;
        //    myOrder.TopLevel = false;
        //    myOrder.Dock = DockStyle.None;
        //    panel2.Controls.Clear();
        //    panel2.Controls.Add(myOrder);
        //    myOrder.Show();
        //}
        public bool islogin { get; set; }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Menu menu= new Menu();
            menu.TopLevel = false;
            menu.getcid = getcid;
            menu.islogin = islogin;
            menu.Dock = DockStyle.None;
            panel2.Controls.Add(menu);
            menu.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            MyMemberCenter mymc = new MyMemberCenter();
            mymc.TopLevel = false;
            mymc.getcid = getcid;
            mymc.islogin = islogin;
            mymc.Dock = DockStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(mymc);
            mymc.Show();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            SystemCenter SC = new SystemCenter();
            SC.TopLevel = false;
            SC.Dock = DockStyle.None;
            SC.getcid = getcid;
            panel2.Controls.Clear();
            panel2.Controls.Add(SC);
            SC.Show();
        }
    }
}

