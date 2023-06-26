using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POSSystem.EnterPage;

namespace POSSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackEnterPage_Click(object sender, EventArgs e)
        {
            this.Close();
            //Program.EnterPage.Show();
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.TopLevel = false;
            menu.Dock = DockStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(menu);
            menu.Show();

        }
    }
}
