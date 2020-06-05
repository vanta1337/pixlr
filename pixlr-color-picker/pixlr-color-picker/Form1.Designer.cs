namespace pixlr_color_picker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.darkModeLabel1 = new DarkModeLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.darkModeButton2 = new DarkModeButton();
            this.darkModeButton1 = new DarkModeButton();
            this.darkModeButton3 = new DarkModeButton();
            this.darkModePanel1 = new DarkMode.DarkModePanel();
            this.SuspendLayout();
            // 
            // darkModeLabel1
            // 
            this.darkModeLabel1.AutoSize = true;
            this.darkModeLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.darkModeLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeLabel1.Location = new System.Drawing.Point(12, 29);
            this.darkModeLabel1.Name = "darkModeLabel1";
            this.darkModeLabel1.Size = new System.Drawing.Size(136, 19);
            this.darkModeLabel1.TabIndex = 0;
            this.darkModeLabel1.Text = "pixlr - c# color picker";
            this.darkModeLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "hex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(57, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "rgb:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(57, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "pixel:";
            // 
            // darkModeButton2
            // 
            this.darkModeButton2.AutoSize = true;
            this.darkModeButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.darkModeButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.darkModeButton2.FlatAppearance.BorderSize = 0;
            this.darkModeButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.darkModeButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.darkModeButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkModeButton2.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.darkModeButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeButton2.Location = new System.Drawing.Point(16, 96);
            this.darkModeButton2.Name = "darkModeButton2";
            this.darkModeButton2.Size = new System.Drawing.Size(35, 22);
            this.darkModeButton2.TabIndex = 6;
            this.darkModeButton2.Text = "hex";
            this.darkModeButton2.UseVisualStyleBackColor = false;
            this.darkModeButton2.Click += new System.EventHandler(this.darkModeButton2_Click);
            // 
            // darkModeButton1
            // 
            this.darkModeButton1.AutoSize = true;
            this.darkModeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.darkModeButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.darkModeButton1.FlatAppearance.BorderSize = 0;
            this.darkModeButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.darkModeButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.darkModeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkModeButton1.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.darkModeButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeButton1.Location = new System.Drawing.Point(57, 96);
            this.darkModeButton1.Name = "darkModeButton1";
            this.darkModeButton1.Size = new System.Drawing.Size(35, 22);
            this.darkModeButton1.TabIndex = 7;
            this.darkModeButton1.Text = "rgb";
            this.darkModeButton1.UseVisualStyleBackColor = false;
            this.darkModeButton1.Click += new System.EventHandler(this.darkModeButton1_Click_1);
            // 
            // darkModeButton3
            // 
            this.darkModeButton3.AutoSize = true;
            this.darkModeButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.darkModeButton3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.darkModeButton3.FlatAppearance.BorderSize = 0;
            this.darkModeButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.darkModeButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.darkModeButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkModeButton3.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.darkModeButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.darkModeButton3.Location = new System.Drawing.Point(98, 96);
            this.darkModeButton3.Name = "darkModeButton3";
            this.darkModeButton3.Size = new System.Drawing.Size(35, 22);
            this.darkModeButton3.TabIndex = 8;
            this.darkModeButton3.Text = "info";
            this.darkModeButton3.UseVisualStyleBackColor = false;
            this.darkModeButton3.Click += new System.EventHandler(this.darkModeButton3_Click);
            // 
            // darkModePanel1
            // 
            this.darkModePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.darkModePanel1.Location = new System.Drawing.Point(16, 51);
            this.darkModePanel1.Name = "darkModePanel1";
            this.darkModePanel1.Size = new System.Drawing.Size(35, 39);
            this.darkModePanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(159, 120);
            this.Controls.Add(this.darkModePanel1);
            this.Controls.Add(this.darkModeButton3);
            this.Controls.Add(this.darkModeButton1);
            this.Controls.Add(this.darkModeButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.darkModeLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pixlr c# color picker | by vanta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkModeLabel darkModeLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DarkModeButton darkModeButton2;
        private DarkModeButton darkModeButton1;
        private DarkModeButton darkModeButton3;
        private DarkMode.DarkModePanel darkModePanel1;
    }
}

