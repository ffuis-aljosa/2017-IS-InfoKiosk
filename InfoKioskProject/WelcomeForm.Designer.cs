﻿namespace InfoKioskProject
{
    partial class welcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.FFpictureBox = new System.Windows.Forms.PictureBox();
            this.UISpictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FFpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UISpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(123, 13);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(268, 80);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Добро дошли на Инфо киоск!\r\n\r\nУниверзитет у Источном Сарајеву\r\nФилозофски факулте" +
    "т Пале";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(12, 128);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(230, 49);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "ПРИЈАВА";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // FFpictureBox
            // 
            this.FFpictureBox.Image = global::InfoKioskProject.Properties.Resources.ffuis_logo;
            this.FFpictureBox.Location = new System.Drawing.Point(397, 13);
            this.FFpictureBox.Name = "FFpictureBox";
            this.FFpictureBox.Size = new System.Drawing.Size(100, 100);
            this.FFpictureBox.TabIndex = 1;
            this.FFpictureBox.TabStop = false;
            // 
            // UISpictureBox
            // 
            this.UISpictureBox.Image = global::InfoKioskProject.Properties.Resources.UES_Logo;
            this.UISpictureBox.Location = new System.Drawing.Point(13, 13);
            this.UISpictureBox.Name = "UISpictureBox";
            this.UISpictureBox.Size = new System.Drawing.Size(100, 100);
            this.UISpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UISpictureBox.TabIndex = 0;
            this.UISpictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(267, 128);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(230, 49);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "ИЗЛАЗ";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(509, 191);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.FFpictureBox);
            this.Controls.Add(this.UISpictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "welcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ФФУИС - ИНФО КИОСК";
            ((System.ComponentModel.ISupportInitialize)(this.FFpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UISpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UISpictureBox;
        private System.Windows.Forms.PictureBox FFpictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button closeButton;
    }
}

