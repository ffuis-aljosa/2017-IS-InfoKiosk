namespace InfoKioskProject
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
            this.UISpictureBox = new System.Windows.Forms.PictureBox();
            this.FFpictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.studentLoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UISpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFpictureBox)).BeginInit();
            this.SuspendLayout();
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
            // FFpictureBox
            // 
            this.FFpictureBox.Image = global::InfoKioskProject.Properties.Resources.ffuis_logo;
            this.FFpictureBox.Location = new System.Drawing.Point(397, 13);
            this.FFpictureBox.Name = "FFpictureBox";
            this.FFpictureBox.Size = new System.Drawing.Size(100, 100);
            this.FFpictureBox.TabIndex = 1;
            this.FFpictureBox.TabStop = false;
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
            // adminLoginButton
            // 
            this.adminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.Location = new System.Drawing.Point(12, 128);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(230, 49);
            this.adminLoginButton.TabIndex = 3;
            this.adminLoginButton.Text = "АДМИНИСТРАТОР";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLoginButton.Location = new System.Drawing.Point(267, 128);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Size = new System.Drawing.Size(230, 49);
            this.studentLoginButton.TabIndex = 4;
            this.studentLoginButton.Text = "СТУДЕНТ";
            this.studentLoginButton.UseVisualStyleBackColor = true;
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 191);
            this.Controls.Add(this.studentLoginButton);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.FFpictureBox);
            this.Controls.Add(this.UISpictureBox);
            this.Name = "welcomeForm";
            this.Text = "ФФУИС - ИНФО КИОСК";
            ((System.ComponentModel.ISupportInitialize)(this.UISpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UISpictureBox;
        private System.Windows.Forms.PictureBox FFpictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Button studentLoginButton;
    }
}

