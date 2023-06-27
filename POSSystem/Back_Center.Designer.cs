namespace POSSystem
{
    partial class Back_Center
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn系統維護 = new System.Windows.Forms.Button();
            this.btn會員資料維護 = new System.Windows.Forms.Button();
            this.btn商品維護 = new System.Windows.Forms.Button();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn系統維護
            // 
            this.btn系統維護.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn系統維護.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn系統維護.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn系統維護.Location = new System.Drawing.Point(283, 220);
            this.btn系統維護.Margin = new System.Windows.Forms.Padding(6);
            this.btn系統維護.Name = "btn系統維護";
            this.btn系統維護.Size = new System.Drawing.Size(256, 198);
            this.btn系統維護.TabIndex = 9;
            this.btn系統維護.Text = "系統維護";
            this.btn系統維護.UseVisualStyleBackColor = false;
            this.btn系統維護.Click += new System.EventHandler(this.btn系統維護_Click);
            // 
            // btn會員資料維護
            // 
            this.btn會員資料維護.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn會員資料維護.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn會員資料維護.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料維護.Location = new System.Drawing.Point(15, 220);
            this.btn會員資料維護.Margin = new System.Windows.Forms.Padding(6);
            this.btn會員資料維護.Name = "btn會員資料維護";
            this.btn會員資料維護.Size = new System.Drawing.Size(256, 198);
            this.btn會員資料維護.TabIndex = 8;
            this.btn會員資料維護.Text = "會員資料維護";
            this.btn會員資料維護.UseVisualStyleBackColor = false;
            this.btn會員資料維護.Click += new System.EventHandler(this.btn會員資料維護_Click);
            // 
            // btn商品維護
            // 
            this.btn商品維護.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn商品維護.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn商品維護.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品維護.Location = new System.Drawing.Point(283, 10);
            this.btn商品維護.Margin = new System.Windows.Forms.Padding(6);
            this.btn商品維護.Name = "btn商品維護";
            this.btn商品維護.Size = new System.Drawing.Size(256, 198);
            this.btn商品維護.TabIndex = 7;
            this.btn商品維護.Text = "商品維護";
            this.btn商品維護.UseVisualStyleBackColor = false;
            this.btn商品維護.Click += new System.EventHandler(this.btn商品維護_Click);
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn訂單管理.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn訂單管理.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(15, 10);
            this.btn訂單管理.Margin = new System.Windows.Forms.Padding(6);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(256, 198);
            this.btn訂單管理.TabIndex = 6;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // Back_Center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn系統維護);
            this.Controls.Add(this.btn會員資料維護);
            this.Controls.Add(this.btn商品維護);
            this.Controls.Add(this.btn訂單管理);
            this.Name = "Back_Center";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackCenter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn系統維護;
        private System.Windows.Forms.Button btn會員資料維護;
        private System.Windows.Forms.Button btn商品維護;
        private System.Windows.Forms.Button btn訂單管理;
    }
}