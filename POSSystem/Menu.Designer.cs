namespace POSSystem
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnFizz = new System.Windows.Forms.Button();
            this.btnTeaAndFlavorMilk = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.imageListPrducts = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGOShpping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.DarkGray;
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.Location = new System.Drawing.Point(40, 19);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(75, 30);
            this.btnCoffee.TabIndex = 1;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnFizz
            // 
            this.btnFizz.BackColor = System.Drawing.Color.DarkGray;
            this.btnFizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFizz.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFizz.Location = new System.Drawing.Point(116, 19);
            this.btnFizz.Name = "btnFizz";
            this.btnFizz.Size = new System.Drawing.Size(75, 30);
            this.btnFizz.TabIndex = 2;
            this.btnFizz.Text = "Fizz";
            this.btnFizz.UseVisualStyleBackColor = false;
            this.btnFizz.Click += new System.EventHandler(this.btnFizz_Click);
            // 
            // btnTeaAndFlavorMilk
            // 
            this.btnTeaAndFlavorMilk.BackColor = System.Drawing.Color.DarkGray;
            this.btnTeaAndFlavorMilk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeaAndFlavorMilk.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeaAndFlavorMilk.Location = new System.Drawing.Point(191, 19);
            this.btnTeaAndFlavorMilk.Name = "btnTeaAndFlavorMilk";
            this.btnTeaAndFlavorMilk.Size = new System.Drawing.Size(130, 30);
            this.btnTeaAndFlavorMilk.TabIndex = 3;
            this.btnTeaAndFlavorMilk.Text = "Tea and Flavor Milk";
            this.btnTeaAndFlavorMilk.UseVisualStyleBackColor = false;
            this.btnTeaAndFlavorMilk.Click += new System.EventHandler(this.btnTeaAndFlavorMilk_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.DarkGray;
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDessert.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.Location = new System.Drawing.Point(322, 19);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(75, 30);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = false;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // listViewMenu
            // 
            this.listViewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.listViewMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(41, 48);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(756, 362);
            this.listViewMenu.TabIndex = 5;
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            this.listViewMenu.ItemActivate += new System.EventHandler(this.listViewMenu_ItemActivate);
            // 
            // imageListPrducts
            // 
            this.imageListPrducts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPrducts.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListPrducts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::POSSystem.Properties.Resources.fi_rr_caret_right;
            this.pictureBox1.Location = new System.Drawing.Point(-39, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGOShpping
            // 
            this.btnGOShpping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGOShpping.BackgroundImage = global::POSSystem.Properties.Resources.fi_rr_shopping_cart;
            this.btnGOShpping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGOShpping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGOShpping.FlatAppearance.BorderSize = 0;
            this.btnGOShpping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGOShpping.ForeColor = System.Drawing.Color.Transparent;
            this.btnGOShpping.Location = new System.Drawing.Point(747, 416);
            this.btnGOShpping.Name = "btnGOShpping";
            this.btnGOShpping.Size = new System.Drawing.Size(50, 40);
            this.btnGOShpping.TabIndex = 8;
            this.btnGOShpping.UseVisualStyleBackColor = true;
            this.btnGOShpping.Click += new System.EventHandler(this.btnGOShpping_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(827, 458);
            this.Controls.Add(this.btnGOShpping);
            this.Controls.Add(this.listViewMenu);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnTeaAndFlavorMilk);
            this.Controls.Add(this.btnFizz);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnFizz;
        private System.Windows.Forms.Button btnTeaAndFlavorMilk;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.ImageList imageListPrducts;
        private System.Windows.Forms.Button btnGOShpping;
    }
}