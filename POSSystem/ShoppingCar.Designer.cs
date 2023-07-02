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
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.btnCheckout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewProduct
            // 
            this.listViewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewProduct.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listViewProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(45, 24);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(777, 373);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.ItemActivate += new System.EventHandler(this.listViewProduct_ItemActivate);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labTotalPrice.Location = new System.Drawing.Point(350, 423);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(205, 33);
            this.labTotalPrice.TabIndex = 63;
            this.labTotalPrice.Text = "TotalPrice  NT$ ";
            // 
            // btnCheckout
            // 
            this.btnCheckout.ActiveImage = null;
            this.btnCheckout.AllowAnimations = true;
            this.btnCheckout.AllowBuffering = false;
            this.btnCheckout.AllowToggling = false;
            this.btnCheckout.AllowZooming = true;
            this.btnCheckout.AllowZoomingOnFocus = false;
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.ErrorImage")));
            this.btnCheckout.FadeWhenInactive = false;
            this.btnCheckout.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCheckout.Image = global::POSSystem.Properties.Resources.fi_rr_shopping_cart_check;
            this.btnCheckout.ImageActive = null;
            this.btnCheckout.ImageLocation = null;
            this.btnCheckout.ImageMargin = 10;
            this.btnCheckout.ImageSize = new System.Drawing.Size(42, 34);
            this.btnCheckout.ImageZoomSize = new System.Drawing.Size(52, 44);
            this.btnCheckout.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.InitialImage")));
            this.btnCheckout.Location = new System.Drawing.Point(770, 423);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Rotation = 0;
            this.btnCheckout.ShowActiveImage = true;
            this.btnCheckout.ShowCursorChanges = true;
            this.btnCheckout.ShowImageBorders = true;
            this.btnCheckout.ShowSizeMarkers = false;
            this.btnCheckout.Size = new System.Drawing.Size(52, 44);
            this.btnCheckout.TabIndex = 79;
            this.btnCheckout.ToolTipText = "";
            this.btnCheckout.WaitOnLoad = false;
            this.btnCheckout.Zoom = 10;
            this.btnCheckout.ZoomSpeed = 10;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = global::POSSystem.Properties.Resources.fi_rr_undo;
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 10;
            this.btnBack.ImageSize = new System.Drawing.Size(42, 34);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(52, 44);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(45, 423);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(52, 44);
            this.btnBack.TabIndex = 78;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 10;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::POSSystem.Properties.Resources.fi_rr_caret_right;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 45);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(848, 482);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.listViewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShoppingCar";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.ShoppingCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private Bunifu.UI.WinForms.BunifuImageButton btnCheckout;
    }
}