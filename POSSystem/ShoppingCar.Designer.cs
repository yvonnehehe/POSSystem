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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCar));
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.groupBoxIce = new System.Windows.Forms.GroupBox();
            this.rBtnIce0 = new System.Windows.Forms.RadioButton();
            this.rBtnIce40 = new System.Windows.Forms.RadioButton();
            this.rBtnIce80 = new System.Windows.Forms.RadioButton();
            this.rBtnIce100 = new System.Windows.Forms.RadioButton();
            this.groupBoxSugar = new System.Windows.Forms.GroupBox();
            this.rBtnSugar0 = new System.Windows.Forms.RadioButton();
            this.rBtnSugar40 = new System.Windows.Forms.RadioButton();
            this.rBtnSugar80 = new System.Windows.Forms.RadioButton();
            this.rBtnSugar100 = new System.Windows.Forms.RadioButton();
            this.labName = new System.Windows.Forms.Label();
            this.btnQadd一 = new System.Windows.Forms.Button();
            this.btnQLower = new System.Windows.Forms.Button();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.labePrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ImageButtonbtnCheckout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxIce.SuspendLayout();
            this.groupBoxSugar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewProduct
            // 
            this.listViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.listViewProduct.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(45, 24);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(398, 322);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(458, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(458, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Quantity";
            // 
            // btnAlter
            // 
            this.btnAlter.BackColor = System.Drawing.Color.Gray;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAlter.Location = new System.Drawing.Point(628, 297);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(71, 48);
            this.btnAlter.TabIndex = 60;
            this.btnAlter.Text = "修改";
            this.btnAlter.UseVisualStyleBackColor = false;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labTotalPrice.Location = new System.Drawing.Point(370, 373);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(109, 25);
            this.labTotalPrice.TabIndex = 63;
            this.labTotalPrice.Text = "Total Price";
            // 
            // groupBoxIce
            // 
            this.groupBoxIce.Controls.Add(this.rBtnIce0);
            this.groupBoxIce.Controls.Add(this.rBtnIce40);
            this.groupBoxIce.Controls.Add(this.rBtnIce80);
            this.groupBoxIce.Controls.Add(this.rBtnIce100);
            this.groupBoxIce.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIce.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxIce.Location = new System.Drawing.Point(458, 168);
            this.groupBoxIce.Name = "groupBoxIce";
            this.groupBoxIce.Size = new System.Drawing.Size(241, 71);
            this.groupBoxIce.TabIndex = 68;
            this.groupBoxIce.TabStop = false;
            this.groupBoxIce.Text = "Ice";
            // 
            // rBtnIce0
            // 
            this.rBtnIce0.AutoSize = true;
            this.rBtnIce0.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnIce0.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnIce0.Location = new System.Drawing.Point(194, 29);
            this.rBtnIce0.Name = "rBtnIce0";
            this.rBtnIce0.Size = new System.Drawing.Size(43, 23);
            this.rBtnIce0.TabIndex = 61;
            this.rBtnIce0.TabStop = true;
            this.rBtnIce0.Text = "0%";
            this.rBtnIce0.UseVisualStyleBackColor = true;
            // 
            // rBtnIce40
            // 
            this.rBtnIce40.AutoSize = true;
            this.rBtnIce40.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnIce40.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnIce40.Location = new System.Drawing.Point(133, 29);
            this.rBtnIce40.Name = "rBtnIce40";
            this.rBtnIce40.Size = new System.Drawing.Size(50, 23);
            this.rBtnIce40.TabIndex = 60;
            this.rBtnIce40.TabStop = true;
            this.rBtnIce40.Text = "40%";
            this.rBtnIce40.UseVisualStyleBackColor = true;
            // 
            // rBtnIce80
            // 
            this.rBtnIce80.AutoSize = true;
            this.rBtnIce80.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnIce80.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnIce80.Location = new System.Drawing.Point(72, 29);
            this.rBtnIce80.Name = "rBtnIce80";
            this.rBtnIce80.Size = new System.Drawing.Size(50, 23);
            this.rBtnIce80.TabIndex = 59;
            this.rBtnIce80.TabStop = true;
            this.rBtnIce80.Text = "80%";
            this.rBtnIce80.UseVisualStyleBackColor = true;
            // 
            // rBtnIce100
            // 
            this.rBtnIce100.AutoSize = true;
            this.rBtnIce100.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnIce100.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnIce100.Location = new System.Drawing.Point(6, 29);
            this.rBtnIce100.Name = "rBtnIce100";
            this.rBtnIce100.Size = new System.Drawing.Size(54, 23);
            this.rBtnIce100.TabIndex = 58;
            this.rBtnIce100.TabStop = true;
            this.rBtnIce100.Text = "100%";
            this.rBtnIce100.UseVisualStyleBackColor = true;
            // 
            // groupBoxSugar
            // 
            this.groupBoxSugar.Controls.Add(this.rBtnSugar0);
            this.groupBoxSugar.Controls.Add(this.rBtnSugar40);
            this.groupBoxSugar.Controls.Add(this.rBtnSugar80);
            this.groupBoxSugar.Controls.Add(this.rBtnSugar100);
            this.groupBoxSugar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSugar.ForeColor = System.Drawing.Color.Gray;
            this.groupBoxSugar.Location = new System.Drawing.Point(458, 86);
            this.groupBoxSugar.Name = "groupBoxSugar";
            this.groupBoxSugar.Size = new System.Drawing.Size(238, 72);
            this.groupBoxSugar.TabIndex = 67;
            this.groupBoxSugar.TabStop = false;
            this.groupBoxSugar.Text = "Sugar";
            // 
            // rBtnSugar0
            // 
            this.rBtnSugar0.AutoSize = true;
            this.rBtnSugar0.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSugar0.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnSugar0.Location = new System.Drawing.Point(194, 29);
            this.rBtnSugar0.Name = "rBtnSugar0";
            this.rBtnSugar0.Size = new System.Drawing.Size(43, 23);
            this.rBtnSugar0.TabIndex = 65;
            this.rBtnSugar0.TabStop = true;
            this.rBtnSugar0.Text = "0%";
            this.rBtnSugar0.UseVisualStyleBackColor = true;
            // 
            // rBtnSugar40
            // 
            this.rBtnSugar40.AutoSize = true;
            this.rBtnSugar40.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSugar40.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnSugar40.Location = new System.Drawing.Point(133, 29);
            this.rBtnSugar40.Name = "rBtnSugar40";
            this.rBtnSugar40.Size = new System.Drawing.Size(50, 23);
            this.rBtnSugar40.TabIndex = 64;
            this.rBtnSugar40.TabStop = true;
            this.rBtnSugar40.Text = "40%";
            this.rBtnSugar40.UseVisualStyleBackColor = true;
            // 
            // rBtnSugar80
            // 
            this.rBtnSugar80.AutoSize = true;
            this.rBtnSugar80.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSugar80.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnSugar80.Location = new System.Drawing.Point(72, 29);
            this.rBtnSugar80.Name = "rBtnSugar80";
            this.rBtnSugar80.Size = new System.Drawing.Size(50, 23);
            this.rBtnSugar80.TabIndex = 63;
            this.rBtnSugar80.TabStop = true;
            this.rBtnSugar80.Text = "80%";
            this.rBtnSugar80.UseVisualStyleBackColor = true;
            // 
            // rBtnSugar100
            // 
            this.rBtnSugar100.AutoSize = true;
            this.rBtnSugar100.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSugar100.ForeColor = System.Drawing.SystemColors.Control;
            this.rBtnSugar100.Location = new System.Drawing.Point(6, 29);
            this.rBtnSugar100.Name = "rBtnSugar100";
            this.rBtnSugar100.Size = new System.Drawing.Size(54, 23);
            this.rBtnSugar100.TabIndex = 62;
            this.rBtnSugar100.TabStop = true;
            this.rBtnSugar100.Text = "100%";
            this.rBtnSugar100.UseVisualStyleBackColor = true;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.SystemColors.Control;
            this.labName.Location = new System.Drawing.Point(546, 24);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 19);
            this.labName.TabIndex = 69;
            this.labName.Text = "Name";
            // 
            // btnQadd一
            // 
            this.btnQadd一.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQadd一.Location = new System.Drawing.Point(564, 253);
            this.btnQadd一.Name = "btnQadd一";
            this.btnQadd一.Size = new System.Drawing.Size(39, 27);
            this.btnQadd一.TabIndex = 72;
            this.btnQadd一.Text = "+";
            this.btnQadd一.UseVisualStyleBackColor = true;
            // 
            // btnQLower
            // 
            this.btnQLower.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLower.Location = new System.Drawing.Point(660, 253);
            this.btnQLower.Name = "btnQLower";
            this.btnQLower.Size = new System.Drawing.Size(39, 27);
            this.btnQLower.TabIndex = 71;
            this.btnQLower.Text = "-";
            this.btnQLower.UseVisualStyleBackColor = true;
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(609, 253);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(45, 27);
            this.txtQ.TabIndex = 70;
            this.txtQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labePrice
            // 
            this.labePrice.AutoSize = true;
            this.labePrice.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labePrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labePrice.Location = new System.Drawing.Point(546, 55);
            this.labePrice.Name = "labePrice";
            this.labePrice.Size = new System.Drawing.Size(36, 19);
            this.labePrice.TabIndex = 74;
            this.labePrice.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(458, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(546, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(458, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 75;
            this.label5.Text = "Subtotal";
            // 
            // ImageButtonbtnCheckout
            // 
            this.ImageButtonbtnCheckout.ActiveImage = null;
            this.ImageButtonbtnCheckout.AllowAnimations = true;
            this.ImageButtonbtnCheckout.AllowBuffering = false;
            this.ImageButtonbtnCheckout.AllowToggling = false;
            this.ImageButtonbtnCheckout.AllowZooming = true;
            this.ImageButtonbtnCheckout.AllowZoomingOnFocus = false;
            this.ImageButtonbtnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonbtnCheckout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButtonbtnCheckout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonbtnCheckout.ErrorImage")));
            this.ImageButtonbtnCheckout.FadeWhenInactive = false;
            this.ImageButtonbtnCheckout.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ImageButtonbtnCheckout.Image = global::POSSystem.Properties.Resources.fi_rr_shopping_cart_check;
            this.ImageButtonbtnCheckout.ImageActive = null;
            this.ImageButtonbtnCheckout.ImageLocation = null;
            this.ImageButtonbtnCheckout.ImageMargin = 10;
            this.ImageButtonbtnCheckout.ImageSize = new System.Drawing.Size(42, 34);
            this.ImageButtonbtnCheckout.ImageZoomSize = new System.Drawing.Size(52, 44);
            this.ImageButtonbtnCheckout.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImageButtonbtnCheckout.InitialImage")));
            this.ImageButtonbtnCheckout.Location = new System.Drawing.Point(647, 364);
            this.ImageButtonbtnCheckout.Name = "ImageButtonbtnCheckout";
            this.ImageButtonbtnCheckout.Rotation = 0;
            this.ImageButtonbtnCheckout.ShowActiveImage = true;
            this.ImageButtonbtnCheckout.ShowCursorChanges = true;
            this.ImageButtonbtnCheckout.ShowImageBorders = true;
            this.ImageButtonbtnCheckout.ShowSizeMarkers = false;
            this.ImageButtonbtnCheckout.Size = new System.Drawing.Size(52, 44);
            this.ImageButtonbtnCheckout.TabIndex = 79;
            this.ImageButtonbtnCheckout.ToolTipText = "";
            this.ImageButtonbtnCheckout.WaitOnLoad = false;
            this.ImageButtonbtnCheckout.Zoom = 10;
            this.ImageButtonbtnCheckout.ZoomSpeed = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::POSSystem.Properties.Resources.fi_rr_undo;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 10;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(42, 34);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(52, 44);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(45, 364);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(52, 44);
            this.bunifuImageButton1.TabIndex = 78;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::POSSystem.Properties.Resources.fi_rr_caret_right;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // ShoppingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(733, 420);
            this.Controls.Add(this.ImageButtonbtnCheckout);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQadd一);
            this.Controls.Add(this.btnQLower);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.groupBoxIce);
            this.Controls.Add(this.groupBoxSugar);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingCar";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.ShoppingCar_Load);
            this.groupBoxIce.ResumeLayout(false);
            this.groupBoxIce.PerformLayout();
            this.groupBoxSugar.ResumeLayout(false);
            this.groupBoxSugar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.GroupBox groupBoxIce;
        private System.Windows.Forms.RadioButton rBtnIce0;
        private System.Windows.Forms.RadioButton rBtnIce40;
        private System.Windows.Forms.RadioButton rBtnIce80;
        private System.Windows.Forms.RadioButton rBtnIce100;
        private System.Windows.Forms.GroupBox groupBoxSugar;
        private System.Windows.Forms.RadioButton rBtnSugar0;
        private System.Windows.Forms.RadioButton rBtnSugar40;
        private System.Windows.Forms.RadioButton rBtnSugar80;
        private System.Windows.Forms.RadioButton rBtnSugar100;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnQadd一;
        private System.Windows.Forms.Button btnQLower;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label labePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonbtnCheckout;
    }
}