namespace POSSystem
{
    partial class EnterPage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnterToOrder = new System.Windows.Forms.Button();
            this.btnContentManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterToOrder
            // 
            this.btnEnterToOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterToOrder.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnEnterToOrder.Location = new System.Drawing.Point(327, 229);
            this.btnEnterToOrder.Name = "btnEnterToOrder";
            this.btnEnterToOrder.Size = new System.Drawing.Size(98, 82);
            this.btnEnterToOrder.TabIndex = 0;
            this.btnEnterToOrder.Text = "Enter\r\nto\r\nOrder";
            this.btnEnterToOrder.UseVisualStyleBackColor = true;
            this.btnEnterToOrder.Click += new System.EventHandler(this.btnEnterToOrder_Click);
            // 
            // btnContentManagement
            // 
            this.btnContentManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContentManagement.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContentManagement.Location = new System.Drawing.Point(639, 387);
            this.btnContentManagement.Name = "btnContentManagement";
            this.btnContentManagement.Size = new System.Drawing.Size(121, 51);
            this.btnContentManagement.TabIndex = 1;
            this.btnContentManagement.Text = "Content\r\nManagement";
            this.btnContentManagement.UseVisualStyleBackColor = true;
            this.btnContentManagement.Click += new System.EventHandler(this.btnContentManagement_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 58);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.BackgroundImage = global::POSSystem.Properties.Resources.cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(747, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // EnterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContentManagement);
            this.Controls.Add(this.btnEnterToOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnterPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EnterPage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EnterPage_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterToOrder;
        private System.Windows.Forms.Button btnContentManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}

