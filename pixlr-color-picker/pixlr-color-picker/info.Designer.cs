namespace pixlr_color_picker
{
    partial class info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info));
            this.darkModeLabel2 = new DarkModeLabel();
            this.darkModeLabel3 = new DarkModeLabel();
            this.darkModeLabel5 = new DarkModeLabel();
            this.darkModeLabel4 = new DarkModeLabel();
            this.SuspendLayout();
            // 
            // darkModeLabel2
            // 
            this.darkModeLabel2.AutoSize = true;
            this.darkModeLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.darkModeLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeLabel2.Location = new System.Drawing.Point(1, 52);
            this.darkModeLabel2.Name = "darkModeLabel2";
            this.darkModeLabel2.Size = new System.Drawing.Size(107, 19);
            this.darkModeLabel2.TabIndex = 2;
            this.darkModeLabel2.Text = "github: vantaxyz";
            this.darkModeLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // darkModeLabel3
            // 
            this.darkModeLabel3.AutoSize = true;
            this.darkModeLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.darkModeLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeLabel3.Location = new System.Drawing.Point(1, 71);
            this.darkModeLabel3.Name = "darkModeLabel3";
            this.darkModeLabel3.Size = new System.Drawing.Size(127, 19);
            this.darkModeLabel3.TabIndex = 3;
            this.darkModeLabel3.Text = "discord: vanta#0001";
            this.darkModeLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // darkModeLabel5
            // 
            this.darkModeLabel5.AutoSize = true;
            this.darkModeLabel5.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.darkModeLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeLabel5.Location = new System.Drawing.Point(1, 33);
            this.darkModeLabel5.Name = "darkModeLabel5";
            this.darkModeLabel5.Size = new System.Drawing.Size(42, 19);
            this.darkModeLabel5.TabIndex = 5;
            this.darkModeLabel5.Text = "build:";
            this.darkModeLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // darkModeLabel4
            // 
            this.darkModeLabel4.AutoSize = true;
            this.darkModeLabel4.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.darkModeLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeLabel4.Location = new System.Drawing.Point(1, 90);
            this.darkModeLabel4.Name = "darkModeLabel4";
            this.darkModeLabel4.Size = new System.Drawing.Size(165, 19);
            this.darkModeLabel4.TabIndex = 6;
            this.darkModeLabel4.Text = "hold alt to capture a pixel ";
            this.darkModeLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(167, 120);
            this.Controls.Add(this.darkModeLabel4);
            this.Controls.Add(this.darkModeLabel5);
            this.Controls.Add(this.darkModeLabel3);
            this.Controls.Add(this.darkModeLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.Name = "info";
            this.Text = "pixlr  c# color picker | info";
            this.Load += new System.EventHandler(this.info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkModeLabel darkModeLabel2;
        private DarkModeLabel darkModeLabel3;
        private DarkModeLabel darkModeLabel5;
        private DarkModeLabel darkModeLabel4;
    }
}