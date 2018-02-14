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
            this.adminUsernameLabel.Location = new System.Drawing.Point(6, 7);
            this.adminUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminUsernameLabel.Name = "adminUsernameLabel";
            this.adminUsernameLabel.Size = new System.Drawing.Size(116, 17);
            this.adminUsernameLabel.TabIndex = 0;
            this.adminUsernameLabel.Text = "Корисничко име";
            // 
            // adminUsernameTextBox
            // 
            this.adminUsernameTextBox.Location = new System.Drawing.Point(9, 26);
            this.adminUsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adminUsernameTextBox.Name = "adminUsernameTextBox";
            this.adminUsernameTextBox.Size = new System.Drawing.Size(236, 20);
            this.adminUsernameTextBox.TabIndex = 1;
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adminPasswordLabel.Location = new System.Drawing.Point(6, 60);
            this.adminPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(64, 17);
            this.adminPasswordLabel.TabIndex = 2;
            this.adminPasswordLabel.Text = "Лозинка";
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Location = new System.Drawing.Point(9, 79);
            this.adminPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.PasswordChar = '*';
            this.adminPasswordTextBox.Size = new System.Drawing.Size(236, 20);
            this.adminPasswordTextBox.TabIndex = 3;
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginButton.Location = new System.Drawing.Point(9, 123);
            this.adminLoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(236, 32);
            this.adminLoginButton.TabIndex = 4;
            this.adminLoginButton.Text = "ПРИЈАВИ СЕ";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // adminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(256, 166);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.adminPasswordTextBox);
            this.Controls.Add(this.adminPasswordLabel);
            this.Controls.Add(this.adminUsernameTextBox);
            this.Controls.Add(this.adminUsernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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