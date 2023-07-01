namespace POSSystem
{
    partial class Back_SystemCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Back_SystemCenter));
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState19 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState20 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState21 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState22 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState23 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState24 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState25 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState26 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState27 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            this.btnBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SystemOff = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderOff = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginOff = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.ActiveImage = null;
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBuffering = false;
            this.btnBack.AllowToggling = false;
            this.btnBack.AllowZooming = true;
            this.btnBack.AllowZoomingOnFocus = false;
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBack.ErrorImage")));
            this.btnBack.FadeWhenInactive = false;
            this.btnBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBack.Image = global::POSSystem.Properties.Resources.fi_rs_undo_alt;
            this.btnBack.ImageActive = null;
            this.btnBack.ImageLocation = null;
            this.btnBack.ImageMargin = 10;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBack.InitialImage")));
            this.btnBack.Location = new System.Drawing.Point(370, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 0;
            this.btnBack.ShowActiveImage = true;
            this.btnBack.ShowCursorChanges = true;
            this.btnBack.ShowImageBorders = true;
            this.btnBack.ShowSizeMarkers = false;
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.ToolTipText = "";
            this.btnBack.WaitOnLoad = false;
            this.btnBack.Zoom = 10;
            this.btnBack.ZoomSpeed = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(139, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "系統維護";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SystemOff);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OrderOff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LoginOff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(75, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // SystemOff
            // 
            this.SystemOff.Animation = 5;
            this.SystemOff.BackColor = System.Drawing.Color.Transparent;
            this.SystemOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SystemOff.BackgroundImage")));
            this.SystemOff.Checked = false;
            this.SystemOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SystemOff.InnerCirclePadding = 3;
            this.SystemOff.Location = new System.Drawing.Point(125, 130);
            this.SystemOff.Margin = new System.Windows.Forms.Padding(5);
            this.SystemOff.Name = "SystemOff";
            this.SystemOff.Size = new System.Drawing.Size(100, 23);
            this.SystemOff.TabIndex = 7;
            this.SystemOff.ThumbMargin = 3;
            toggleState19.BackColor = System.Drawing.Color.DarkGray;
            toggleState19.BackColorInner = System.Drawing.Color.White;
            toggleState19.BorderColor = System.Drawing.Color.DarkGray;
            toggleState19.BorderColorInner = System.Drawing.Color.White;
            toggleState19.BorderRadius = 17;
            toggleState19.BorderRadiusInner = 11;
            toggleState19.BorderThickness = 1;
            toggleState19.BorderThicknessInner = 1;
            this.SystemOff.ToggleStateDisabled = toggleState19;
            toggleState20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState20.BackColorInner = System.Drawing.Color.White;
            toggleState20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState20.BorderColorInner = System.Drawing.Color.White;
            toggleState20.BorderRadius = 17;
            toggleState20.BorderRadiusInner = 11;
            toggleState20.BorderThickness = 1;
            toggleState20.BorderThicknessInner = 1;
            this.SystemOff.ToggleStateOff = toggleState20;
            toggleState21.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState21.BackColorInner = System.Drawing.Color.White;
            toggleState21.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState21.BorderColorInner = System.Drawing.Color.White;
            toggleState21.BorderRadius = 17;
            toggleState21.BorderRadiusInner = 11;
            toggleState21.BorderThickness = 1;
            toggleState21.BorderThicknessInner = 1;
            this.SystemOff.ToggleStateOn = toggleState21;
            this.SystemOff.Value = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "網站關閉";
            // 
            // OrderOff
            // 
            this.OrderOff.Animation = 5;
            this.OrderOff.BackColor = System.Drawing.Color.Transparent;
            this.OrderOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderOff.BackgroundImage")));
            this.OrderOff.Checked = false;
            this.OrderOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderOff.InnerCirclePadding = 3;
            this.OrderOff.Location = new System.Drawing.Point(125, 83);
            this.OrderOff.Margin = new System.Windows.Forms.Padding(5);
            this.OrderOff.Name = "OrderOff";
            this.OrderOff.Size = new System.Drawing.Size(100, 23);
            this.OrderOff.TabIndex = 5;
            this.OrderOff.ThumbMargin = 3;
            toggleState22.BackColor = System.Drawing.Color.DarkGray;
            toggleState22.BackColorInner = System.Drawing.Color.White;
            toggleState22.BorderColor = System.Drawing.Color.DarkGray;
            toggleState22.BorderColorInner = System.Drawing.Color.White;
            toggleState22.BorderRadius = 17;
            toggleState22.BorderRadiusInner = 11;
            toggleState22.BorderThickness = 1;
            toggleState22.BorderThicknessInner = 1;
            this.OrderOff.ToggleStateDisabled = toggleState22;
            toggleState23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState23.BackColorInner = System.Drawing.Color.White;
            toggleState23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState23.BorderColorInner = System.Drawing.Color.White;
            toggleState23.BorderRadius = 17;
            toggleState23.BorderRadiusInner = 11;
            toggleState23.BorderThickness = 1;
            toggleState23.BorderThicknessInner = 1;
            this.OrderOff.ToggleStateOff = toggleState23;
            toggleState24.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState24.BackColorInner = System.Drawing.Color.White;
            toggleState24.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState24.BorderColorInner = System.Drawing.Color.White;
            toggleState24.BorderRadius = 17;
            toggleState24.BorderRadiusInner = 11;
            toggleState24.BorderThickness = 1;
            toggleState24.BorderThicknessInner = 1;
            this.OrderOff.ToggleStateOn = toggleState24;
            this.OrderOff.Value = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "暫停下單";
            // 
            // LoginOff
            // 
            this.LoginOff.Animation = 5;
            this.LoginOff.BackColor = System.Drawing.Color.Transparent;
            this.LoginOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginOff.BackgroundImage")));
            this.LoginOff.Checked = false;
            this.LoginOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginOff.InnerCirclePadding = 3;
            this.LoginOff.Location = new System.Drawing.Point(125, 37);
            this.LoginOff.Margin = new System.Windows.Forms.Padding(5);
            this.LoginOff.Name = "LoginOff";
            this.LoginOff.Size = new System.Drawing.Size(100, 23);
            this.LoginOff.TabIndex = 3;
            this.LoginOff.ThumbMargin = 3;
            toggleState25.BackColor = System.Drawing.Color.DarkGray;
            toggleState25.BackColorInner = System.Drawing.Color.White;
            toggleState25.BorderColor = System.Drawing.Color.DarkGray;
            toggleState25.BorderColorInner = System.Drawing.Color.White;
            toggleState25.BorderRadius = 17;
            toggleState25.BorderRadiusInner = 11;
            toggleState25.BorderThickness = 1;
            toggleState25.BorderThicknessInner = 1;
            this.LoginOff.ToggleStateDisabled = toggleState25;
            toggleState26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState26.BackColorInner = System.Drawing.Color.White;
            toggleState26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState26.BorderColorInner = System.Drawing.Color.White;
            toggleState26.BorderRadius = 17;
            toggleState26.BorderRadiusInner = 11;
            toggleState26.BorderThickness = 1;
            toggleState26.BorderThicknessInner = 1;
            this.LoginOff.ToggleStateOff = toggleState26;
            toggleState27.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState27.BackColorInner = System.Drawing.Color.White;
            toggleState27.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState27.BorderColorInner = System.Drawing.Color.White;
            toggleState27.BorderRadius = 17;
            toggleState27.BorderRadiusInner = 11;
            toggleState27.BorderThickness = 1;
            toggleState27.BorderThicknessInner = 1;
            this.LoginOff.ToggleStateOn = toggleState27;
            this.LoginOff.Value = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "暫停登入";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnExit.BackgroundImage = global::POSSystem.Properties.Resources.cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(390, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 11;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Back_SystemCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(419, 320);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Back_SystemCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back_SystemCenter";
            this.Load += new System.EventHandler(this.Back_SystemCenter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuToggleSwitch OrderOff;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuToggleSwitch LoginOff;
        private System.Windows.Forms.Label label2;
        public Bunifu.UI.WinForms.BunifuToggleSwitch SystemOff;
        private System.Windows.Forms.Button btnExit;
    }
}