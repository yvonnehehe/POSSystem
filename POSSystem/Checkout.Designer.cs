namespace POSSystem
{
    partial class Checkout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labSum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labePoint = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsePoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCash);
            this.groupBox1.Controls.Add(this.btnCard);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(246, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請選擇結帳方式";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnCash.BackgroundImage = global::POSSystem.Properties.Resources.comment_dollar;
            this.btnCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Location = new System.Drawing.Point(118, 37);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(79, 54);
            this.btnCash.TabIndex = 3;
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackgroundImage = global::POSSystem.Properties.Resources.fi_rs_credit_card;
            this.btnCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Location = new System.Drawing.Point(31, 37);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(69, 54);
            this.btnCard.TabIndex = 2;
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "訂單總金額為";
            // 
            // labSum
            // 
            this.labSum.AutoSize = true;
            this.labSum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labSum.Location = new System.Drawing.Point(185, 37);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(71, 20);
            this.labSum.TabIndex = 4;
            this.labSum.Text = "NT$ 000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(103, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "點數";
            // 
            // labePoint
            // 
            this.labePoint.AutoSize = true;
            this.labePoint.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labePoint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labePoint.Location = new System.Drawing.Point(185, 76);
            this.labePoint.Name = "labePoint";
            this.labePoint.Size = new System.Drawing.Size(41, 20);
            this.labePoint.TabIndex = 6;
            this.labePoint.Text = "點數";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(71, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "點數折抵";
            // 
            // txtUsePoint
            // 
            this.txtUsePoint.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUsePoint.Location = new System.Drawing.Point(189, 110);
            this.txtUsePoint.Name = "txtUsePoint";
            this.txtUsePoint.Size = new System.Drawing.Size(100, 29);
            this.txtUsePoint.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(103, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "結帳金額為";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labTotal.Location = new System.Drawing.Point(103, 261);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(71, 20);
            this.labTotal.TabIndex = 10;
            this.labTotal.Text = "NT$ 000";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(507, 316);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsePoint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labePoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labePoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsePoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labTotal;
    }
}