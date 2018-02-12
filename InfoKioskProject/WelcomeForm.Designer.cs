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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.studentLoginButton = new System.Windows.Forms.Button();
            this.FFpictureBox = new System.Windows.Forms.PictureBox();
            this.UISpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FFpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UISpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(164, 16);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(334, 100);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Добро дошли на Инфо киоск!\r\n\r\nУниверзитет у Источном Сарајеву\r\nФилозофски факулте" +
    "т Пале";
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.Location = new System.Drawing.Point(16, 158);
            this.adminLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(307, 60);
            this.adminLoginButton.TabIndex = 3;
            this.adminLoginButton.Text = "АДМИНИСТРАТОР";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLoginButton.Location = new System.Drawing.Point(356, 158);
            this.studentLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Size = new System.Drawing.Size(307, 60);
            this.studentLoginButton.TabIndex = 4;
            this.studentLoginButton.Text = "СТУДЕНТ";
            this.studentLoginButton.UseVisualStyleBackColor = true;
            // 
            // FFpictureBox
            // 
            this.FFpictureBox.Image = global::InfoKioskProject.Properties.Resources.ffuis_logo;
            this.FFpictureBox.Location = new System.Drawing.Point(529, 16);
            this.FFpictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.FFpictureBox.Name = "FFpictureBox";
            this.FFpictureBox.Size = new System.Drawing.Size(133, 123);
            this.FFpictureBox.TabIndex = 1;
            this.FFpictureBox.TabStop = false;
            // 
            // UISpictureBox
            // 
            this.UISpictureBox.Image = global::InfoKioskProject.Properties.Resources.UES_Logo;
            this.UISpictureBox.Location = new System.Drawing.Point(17, 16);
            this.UISpictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.UISpictureBox.Name = "UISpictureBox";
            this.UISpictureBox.Size = new System.Drawing.Size(133, 123);
            this.UISpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UISpictureBox.TabIndex = 0;
            this.UISpictureBox.TabStop = false;
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(679, 235);
            this.Controls.Add(this.studentLoginButton);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.FFpictureBox);
            this.Controls.Add(this.UISpictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Button studentLoginButton;
    }
}

