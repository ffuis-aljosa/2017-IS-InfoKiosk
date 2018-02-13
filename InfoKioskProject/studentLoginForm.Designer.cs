namespace InfoKioskProject
{
    partial class studentLoginForm
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
            this.studentUsernameLabel = new System.Windows.Forms.Label();
            this.studentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.studentPasswordLabel = new System.Windows.Forms.Label();
            this.studentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.studentLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentUsernameLabel
            // 
            this.studentUsernameLabel.AutoSize = true;
            this.studentUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentUsernameLabel.Location = new System.Drawing.Point(6, 7);
            this.studentUsernameLabel.Name = "studentUsernameLabel";
            this.studentUsernameLabel.Size = new System.Drawing.Size(93, 16);
            this.studentUsernameLabel.TabIndex = 0;
            this.studentUsernameLabel.Text = "Број индекса";
            // 
            // studentUsernameTextBox
            // 
            this.studentUsernameTextBox.Location = new System.Drawing.Point(9, 26);
            this.studentUsernameTextBox.Name = "studentUsernameTextBox";
            this.studentUsernameTextBox.Size = new System.Drawing.Size(236, 20);
            this.studentUsernameTextBox.TabIndex = 1;
            // 
            // studentPasswordLabel
            // 
            this.studentPasswordLabel.AutoSize = true;
            this.studentPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPasswordLabel.Location = new System.Drawing.Point(6, 60);
            this.studentPasswordLabel.Name = "studentPasswordLabel";
            this.studentPasswordLabel.Size = new System.Drawing.Size(64, 16);
            this.studentPasswordLabel.TabIndex = 2;
            this.studentPasswordLabel.Text = "Лозинка";
            // 
            // studentPasswordTextBox
            // 
            this.studentPasswordTextBox.Location = new System.Drawing.Point(9, 79);
            this.studentPasswordTextBox.Name = "studentPasswordTextBox";
            this.studentPasswordTextBox.PasswordChar = '*';
            this.studentPasswordTextBox.Size = new System.Drawing.Size(236, 20);
            this.studentPasswordTextBox.TabIndex = 3;
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLoginButton.Location = new System.Drawing.Point(9, 123);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Size = new System.Drawing.Size(236, 32);
            this.studentLoginButton.TabIndex = 4;
            this.studentLoginButton.Text = "ПРИЈАВИ СЕ";
            this.studentLoginButton.UseVisualStyleBackColor = true;
            // 
            // studentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(256, 166);
            this.Controls.Add(this.studentLoginButton);
            this.Controls.Add(this.studentPasswordTextBox);
            this.Controls.Add(this.studentPasswordLabel);
            this.Controls.Add(this.studentUsernameTextBox);
            this.Controls.Add(this.studentUsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "studentLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТУДЕНТ - ПРИЈАВА";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentUsernameLabel;
        private System.Windows.Forms.TextBox studentUsernameTextBox;
        private System.Windows.Forms.Label studentPasswordLabel;
        private System.Windows.Forms.TextBox studentPasswordTextBox;
        private System.Windows.Forms.Button studentLoginButton;
    }
}