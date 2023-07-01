namespace POSSystem
{
    partial class S_SystemOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_SystemOff));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackEnterPage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(212, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "系統維護中";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.BackgroundImage = global::POSSystem.Properties.Resources.cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(768, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackEnterPage
            // 
            this.btnBackEnterPage.ActiveImage = null;
            this.btnBackEnterPage.AllowAnimations = true;
            this.btnBackEnterPage.AllowBuffering = false;
            this.btnBackEnterPage.AllowToggling = false;
            this.btnBackEnterPage.AllowZooming = true;
            this.btnBackEnterPage.AllowZoomingOnFocus = false;
            this.btnBackEnterPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackEnterPage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackEnterPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBackEnterPage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnBackEnterPage.ErrorImage")));
            this.btnBackEnterPage.FadeWhenInactive = false;
            this.btnBackEnterPage.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnBackEnterPage.Image = global::POSSystem.Properties.Resources.fi_rs_undo_alt;
            this.btnBackEnterPage.ImageActive = null;
            this.btnBackEnterPage.ImageLocation = null;
            this.btnBackEnterPage.ImageMargin = 10;
            this.btnBackEnterPage.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBackEnterPage.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnBackEnterPage.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnBackEnterPage.InitialImage")));
            this.btnBackEnterPage.Location = new System.Drawing.Point(748, 398);
            this.btnBackEnterPage.Name = "btnBackEnterPage";
            this.btnBackEnterPage.Rotation = 0;
            this.btnBackEnterPage.ShowActiveImage = true;
            this.btnBackEnterPage.ShowCursorChanges = true;
            this.btnBackEnterPage.ShowImageBorders = true;
            this.btnBackEnterPage.ShowSizeMarkers = false;
            this.btnBackEnterPage.Size = new System.Drawing.Size(40, 40);
            this.btnBackEnterPage.TabIndex = 7;
            this.btnBackEnterPage.ToolTipText = "";
            this.btnBackEnterPage.WaitOnLoad = false;
            this.btnBackEnterPage.Zoom = 10;
            this.btnBackEnterPage.ZoomSpeed = 10;
            this.btnBackEnterPage.Click += new System.EventHandler(this.btnBackEnterPage_Click);
            // 
            // S_SystemOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackEnterPage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "S_SystemOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S_SystemOff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.UI.WinForms.BunifuImageButton btnBackEnterPage;
    }
}