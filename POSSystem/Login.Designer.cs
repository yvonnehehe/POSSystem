namespace POSSystem
{
    partial class Login
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
            this.gBox登入 = new System.Windows.Forms.GroupBox();
            this.txtPhone_Login = new System.Windows.Forms.TextBox();
            this.txtName_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn會員搜尋 = new System.Windows.Forms.Button();
            this.btn結帳 = new System.Windows.Forms.Button();
            this.gBox建立新會員 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btnCreatMember = new System.Windows.Forms.Button();
            this.dtpBirth_Add = new System.Windows.Forms.DateTimePicker();
            this.txtPhone_Add = new System.Windows.Forms.TextBox();
            this.txtAddress_Add = new System.Windows.Forms.TextBox();
            this.txtEmail_Add = new System.Windows.Forms.TextBox();
            this.txtName_Add = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn建立新會員 = new System.Windows.Forms.Button();
            this.gBox登入.SuspendLayout();
            this.gBox建立新會員.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox登入
            // 
            this.gBox登入.Controls.Add(this.txtPhone_Login);
            this.gBox登入.Controls.Add(this.txtName_Login);
            this.gBox登入.Controls.Add(this.label1);
            this.gBox登入.Controls.Add(this.label7);
            this.gBox登入.Controls.Add(this.btn會員搜尋);
            this.gBox登入.Location = new System.Drawing.Point(12, 90);
            this.gBox登入.Name = "gBox登入";
            this.gBox登入.Size = new System.Drawing.Size(217, 284);
            this.gBox登入.TabIndex = 47;
            this.gBox登入.TabStop = false;
            this.gBox登入.Text = "登入";
            this.gBox登入.Visible = false;
            // 
            // txtPhone_Login
            // 
            this.txtPhone_Login.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone_Login.Location = new System.Drawing.Point(59, 93);
            this.txtPhone_Login.Name = "txtPhone_Login";
            this.txtPhone_Login.Size = new System.Drawing.Size(152, 29);
            this.txtPhone_Login.TabIndex = 49;
            // 
            // txtName_Login
            // 
            this.txtName_Login.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName_Login.Location = new System.Drawing.Point(59, 55);
            this.txtName_Login.Name = "txtName_Login";
            this.txtName_Login.Size = new System.Drawing.Size(152, 29);
            this.txtName_Login.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "電話";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "姓名";
            // 
            // btn會員搜尋
            // 
            this.btn會員搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員搜尋.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn會員搜尋.Location = new System.Drawing.Point(59, 135);
            this.btn會員搜尋.Margin = new System.Windows.Forms.Padding(6);
            this.btn會員搜尋.Name = "btn會員搜尋";
            this.btn會員搜尋.Size = new System.Drawing.Size(108, 33);
            this.btn會員搜尋.TabIndex = 47;
            this.btn會員搜尋.Text = "會員搜尋";
            this.btn會員搜尋.UseVisualStyleBackColor = true;
            this.btn會員搜尋.Click += new System.EventHandler(this.btn會員搜尋_Click_1);
            // 
            // btn結帳
            // 
            this.btn結帳.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn結帳.Location = new System.Drawing.Point(191, 392);
            this.btn結帳.Margin = new System.Windows.Forms.Padding(6);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(108, 33);
            this.btn結帳.TabIndex = 52;
            this.btn結帳.Text = "結帳";
            this.btn結帳.UseVisualStyleBackColor = true;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click_1);
            // 
            // gBox建立新會員
            // 
            this.gBox建立新會員.Controls.Add(this.btn清空欄位);
            this.gBox建立新會員.Controls.Add(this.btnCreatMember);
            this.gBox建立新會員.Controls.Add(this.dtpBirth_Add);
            this.gBox建立新會員.Controls.Add(this.txtPhone_Add);
            this.gBox建立新會員.Controls.Add(this.txtAddress_Add);
            this.gBox建立新會員.Controls.Add(this.txtEmail_Add);
            this.gBox建立新會員.Controls.Add(this.txtName_Add);
            this.gBox建立新會員.Controls.Add(this.label6);
            this.gBox建立新會員.Controls.Add(this.label5);
            this.gBox建立新會員.Controls.Add(this.label4);
            this.gBox建立新會員.Controls.Add(this.label3);
            this.gBox建立新會員.Controls.Add(this.label2);
            this.gBox建立新會員.Location = new System.Drawing.Point(240, 90);
            this.gBox建立新會員.Name = "gBox建立新會員";
            this.gBox建立新會員.Size = new System.Drawing.Size(264, 284);
            this.gBox建立新會員.TabIndex = 48;
            this.gBox建立新會員.TabStop = false;
            this.gBox建立新會員.Text = "建立新會員";
            this.gBox建立新會員.Visible = false;
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn清空欄位.Location = new System.Drawing.Point(144, 236);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(6);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(95, 31);
            this.btn清空欄位.TabIndex = 53;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click_1);
            // 
            // btnCreatMember
            // 
            this.btnCreatMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreatMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreatMember.Location = new System.Drawing.Point(44, 236);
            this.btnCreatMember.Name = "btnCreatMember";
            this.btnCreatMember.Size = new System.Drawing.Size(91, 31);
            this.btnCreatMember.TabIndex = 52;
            this.btnCreatMember.Text = "新增資料";
            this.btnCreatMember.UseVisualStyleBackColor = true;
            this.btnCreatMember.Click += new System.EventHandler(this.btnCreatMember_Click);
            // 
            // dtpBirth_Add
            // 
            this.dtpBirth_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpBirth_Add.Location = new System.Drawing.Point(62, 177);
            this.dtpBirth_Add.Name = "dtpBirth_Add";
            this.dtpBirth_Add.Size = new System.Drawing.Size(177, 29);
            this.dtpBirth_Add.TabIndex = 49;
            this.dtpBirth_Add.Value = new System.DateTime(1999, 7, 7, 0, 0, 0, 0);
            // 
            // txtPhone_Add
            // 
            this.txtPhone_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone_Add.Location = new System.Drawing.Point(62, 61);
            this.txtPhone_Add.Name = "txtPhone_Add";
            this.txtPhone_Add.Size = new System.Drawing.Size(177, 29);
            this.txtPhone_Add.TabIndex = 43;
            // 
            // txtAddress_Add
            // 
            this.txtAddress_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress_Add.Location = new System.Drawing.Point(62, 99);
            this.txtAddress_Add.Name = "txtAddress_Add";
            this.txtAddress_Add.Size = new System.Drawing.Size(177, 29);
            this.txtAddress_Add.TabIndex = 45;
            // 
            // txtEmail_Add
            // 
            this.txtEmail_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail_Add.Location = new System.Drawing.Point(62, 136);
            this.txtEmail_Add.Name = "txtEmail_Add";
            this.txtEmail_Add.Size = new System.Drawing.Size(177, 29);
            this.txtEmail_Add.TabIndex = 47;
            // 
            // txtName_Add
            // 
            this.txtName_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName_Add.Location = new System.Drawing.Point(62, 23);
            this.txtName_Add.Name = "txtName_Add";
            this.txtName_Add.Size = new System.Drawing.Size(177, 29);
            this.txtName_Add.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(9, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(9, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(9, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "電話";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "姓名";
            // 
            // btn登入
            // 
            this.btn登入.Location = new System.Drawing.Point(151, 26);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(75, 23);
            this.btn登入.TabIndex = 49;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn建立新會員
            // 
            this.btn建立新會員.Location = new System.Drawing.Point(255, 26);
            this.btn建立新會員.Name = "btn建立新會員";
            this.btn建立新會員.Size = new System.Drawing.Size(99, 23);
            this.btn建立新會員.TabIndex = 50;
            this.btn建立新會員.Text = "還不是會員?";
            this.btn建立新會員.UseVisualStyleBackColor = true;
            this.btn建立新會員.Click += new System.EventHandler(this.btn建立新會員_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(516, 460);
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.btn建立新會員);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.gBox建立新會員);
            this.Controls.Add(this.gBox登入);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateMember";
            this.Load += new System.EventHandler(this.CreateMember_Load);
            this.gBox登入.ResumeLayout(false);
            this.gBox登入.PerformLayout();
            this.gBox建立新會員.ResumeLayout(false);
            this.gBox建立新會員.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn結帳;
        private System.Windows.Forms.TextBox txtPhone_Login;
        private System.Windows.Forms.TextBox txtName_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn會員搜尋;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btnCreatMember;
        private System.Windows.Forms.DateTimePicker dtpBirth_Add;
        private System.Windows.Forms.TextBox txtPhone_Add;
        private System.Windows.Forms.TextBox txtAddress_Add;
        private System.Windows.Forms.TextBox txtEmail_Add;
        private System.Windows.Forms.TextBox txtName_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn建立新會員;
        public System.Windows.Forms.GroupBox gBox登入;
        public System.Windows.Forms.GroupBox gBox建立新會員;
    }
}