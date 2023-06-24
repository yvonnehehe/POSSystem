﻿namespace POSSystem
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCoffee
            // 
            this.btnCoffee.Location = new System.Drawing.Point(63, 19);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(75, 23);
            this.btnCoffee.TabIndex = 1;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnFizz
            // 
            this.btnFizz.Location = new System.Drawing.Point(183, 19);
            this.btnFizz.Name = "btnFizz";
            this.btnFizz.Size = new System.Drawing.Size(75, 23);
            this.btnFizz.TabIndex = 2;
            this.btnFizz.Text = "Fizz";
            this.btnFizz.UseVisualStyleBackColor = true;
            this.btnFizz.Click += new System.EventHandler(this.btnFizz_Click);
            // 
            // btnTeaAndFlavorMilk
            // 
            this.btnTeaAndFlavorMilk.Location = new System.Drawing.Point(313, 19);
            this.btnTeaAndFlavorMilk.Name = "btnTeaAndFlavorMilk";
            this.btnTeaAndFlavorMilk.Size = new System.Drawing.Size(115, 23);
            this.btnTeaAndFlavorMilk.TabIndex = 3;
            this.btnTeaAndFlavorMilk.Text = "Tea and Flavor Milk";
            this.btnTeaAndFlavorMilk.UseVisualStyleBackColor = true;
            this.btnTeaAndFlavorMilk.Click += new System.EventHandler(this.btnTeaAndFlavorMilk_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Location = new System.Drawing.Point(471, 19);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(75, 23);
            this.btnDessert.TabIndex = 4;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // listViewMenu
            // 
            this.listViewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(63, 48);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(653, 355);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(741, 440);
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
    }
}