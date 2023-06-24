namespace POSSystem
{
    partial class ShoppingCar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.labTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.labPrice = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnCupadd一 = new System.Windows.Forms.Button();
            this.btnCupLower = new System.Windows.Forms.Button();
            this.txtCup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labSugarAndIce = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(391, 283);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(395, 365);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(18, 20);
            this.labTotal.TabIndex = 2;
            this.labTotal.Text = "0";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(563, 366);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 3;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.Location = new System.Drawing.Point(437, 90);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(95, 24);
            this.labPrice.TabIndex = 55;
            this.labPrice.Text = "Sugar/Ice";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(437, 33);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(64, 24);
            this.labName.TabIndex = 54;
            this.labName.Text = "Name";
            // 
            // btnCupadd一
            // 
            this.btnCupadd一.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupadd一.Location = new System.Drawing.Point(543, 142);
            this.btnCupadd一.Name = "btnCupadd一";
            this.btnCupadd一.Size = new System.Drawing.Size(27, 34);
            this.btnCupadd一.TabIndex = 59;
            this.btnCupadd一.Text = "+";
            this.btnCupadd一.UseVisualStyleBackColor = true;
            // 
            // btnCupLower
            // 
            this.btnCupLower.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCupLower.Location = new System.Drawing.Point(624, 142);
            this.btnCupLower.Name = "btnCupLower";
            this.btnCupLower.Size = new System.Drawing.Size(27, 34);
            this.btnCupLower.TabIndex = 58;
            this.btnCupLower.Text = "-";
            this.btnCupLower.UseVisualStyleBackColor = true;
            // 
            // txtCup
            // 
            this.txtCup.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCup.Location = new System.Drawing.Point(576, 140);
            this.txtCup.Name = "txtCup";
            this.txtCup.Size = new System.Drawing.Size(42, 39);
            this.txtCup.TabIndex = 57;
            this.txtCup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(440, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 30);
            this.label4.TabIndex = 56;
            this.label4.Text = "cup";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(576, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(617, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 12);
            this.labelName.TabIndex = 61;
            this.labelName.Text = "label1";
            // 
            // labSugarAndIce
            // 
            this.labSugarAndIce.AutoSize = true;
            this.labSugarAndIce.Location = new System.Drawing.Point(617, 101);
            this.labSugarAndIce.Name = "labSugarAndIce";
            this.labSugarAndIce.Size = new System.Drawing.Size(33, 12);
            this.labSugarAndIce.TabIndex = 62;
            this.labSugarAndIce.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(321, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Total";
            // 
            // ShoppingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(675, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labSugarAndIce);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCupadd一);
            this.Controls.Add(this.btnCupLower);
            this.Controls.Add(this.txtCup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.listView1);
            this.Name = "ShoppingCar";
            this.Text = "ShoppingCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnCupadd一;
        private System.Windows.Forms.Button btnCupLower;
        private System.Windows.Forms.TextBox txtCup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labSugarAndIce;
        private System.Windows.Forms.Label label1;
    }
}