namespace InfoKioskProject
{
    partial class adminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLoginForm));
            this.adminUsernameLabel = new System.Windows.Forms.Label();
            this.adminUsernameTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordLabel = new System.Windows.Forms.Label();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminUsernameLabel
            // 
            this.adminUsernameLabel.AutoSize = true;
            this.adminUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adminUsernameLabel.Location = new System.Drawing.Point(8, 9);
            this.adminUsernameLabel.Name = "adminUsernameLabel";
            this.adminUsernameLabel.Size = new System.Drawing.Size(145, 20);
            this.adminUsernameLabel.TabIndex = 0;
            this.adminUsernameLabel.Text = "Корисничко име";
            // 
            // adminUsernameTextBox
            // 
            this.adminUsernameTextBox.Location = new System.Drawing.Point(12, 32);
            this.adminUsernameTextBox.Name = "adminUsernameTextBox";
            this.adminUsernameTextBox.Size = new System.Drawing.Size(314, 22);
            this.adminUsernameTextBox.TabIndex = 1;
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adminPasswordLabel.Location = new System.Drawing.Point(8, 74);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(79, 20);
            this.adminPasswordLabel.TabIndex = 2;
            this.adminPasswordLabel.Text = "Лозинка";
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Location = new System.Drawing.Point(12, 97);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.Size = new System.Drawing.Size(314, 22);
            this.adminPasswordTextBox.TabIndex = 3;
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.Location = new System.Drawing.Point(12, 150);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(314, 40);
            this.adminLoginButton.TabIndex = 4;
            this.adminLoginButton.Text = "ПРИЈАВИ СЕ";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            // 
            // adminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(342, 203);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.adminPasswordTextBox);
            this.Controls.Add(this.adminPasswordLabel);
            this.Controls.Add(this.adminUsernameTextBox);
            this.Controls.Add(this.adminUsernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АДМИНИСТРАТОР - ПРИЈАВА";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminUsernameLabel;
        private System.Windows.Forms.TextBox adminUsernameTextBox;
        private System.Windows.Forms.Label adminPasswordLabel;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.Button adminLoginButton;
    }
}