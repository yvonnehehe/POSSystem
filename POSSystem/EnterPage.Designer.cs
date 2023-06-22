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
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterToOrder
            // 
            this.btnEnterToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterToOrder.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnEnterToOrder.Location = new System.Drawing.Point(327, 229);
            this.btnEnterToOrder.Name = "btnEnterToOrder";
            this.btnEnterToOrder.Size = new System.Drawing.Size(98, 82);
            this.btnEnterToOrder.TabIndex = 0;
            this.btnEnterToOrder.Text = "Enter\r\nto\r\nOrder";
            this.btnEnterToOrder.UseVisualStyleBackColor = true;
            // 
            // btnContentManagement
            // 
            this.btnContentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContentManagement.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContentManagement.Location = new System.Drawing.Point(639, 387);
            this.btnContentManagement.Name = "btnContentManagement";
            this.btnContentManagement.Size = new System.Drawing.Size(121, 51);
            this.btnContentManagement.TabIndex = 1;
            this.btnContentManagement.Text = "Content\r\nManagement";
            this.btnContentManagement.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.BackgroundImage = global::POSSystem.Properties.Resources.cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(738, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EnterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContentManagement);
            this.Controls.Add(this.btnEnterToOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterToOrder;
        private System.Windows.Forms.Button btnContentManagement;
        private System.Windows.Forms.Button btnExit;
    }
}

