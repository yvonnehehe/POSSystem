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
            this.ImageButtonbtnCheckout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.listViewProduct.Size = new System.Drawing.Size(654, 322);
            this.listViewProduct.TabIndex = 0;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.ItemActivate += new System.EventHandler(this.listViewProduct_ItemActivate);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labTotalPrice.Location = new System.Drawing.Point(370, 388);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(109, 25);
            this.labTotalPrice.TabIndex = 63;
            this.labTotalPrice.Text = "Total Price";
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
            this.ImageButtonbtnCheckout.Location = new System.Drawing.Point(647, 379);
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
            this.btnBack.Location = new System.Drawing.Point(45, 379);
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
            this.ClientSize = new System.Drawing.Size(733, 431);
            this.Controls.Add(this.ImageButtonbtnCheckout);
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
        private Bunifu.UI.WinForms.BunifuImageButton ImageButtonbtnCheckout;
    }
}