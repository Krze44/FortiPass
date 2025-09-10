namespace FortiPass
{
    partial class FortiPass
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.optionsPassword = new System.Windows.Forms.CheckedListBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.optionsUserName = new System.Windows.Forms.CheckedListBox();
            this.btnGenerateUserName = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserNameLength = new System.Windows.Forms.TextBox();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.lblUserNameLength = new System.Windows.Forms.Label();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.lblEmailSuffix = new System.Windows.Forms.Label();
            this.txtEmailSuffix = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.optionsEmail = new System.Windows.Forms.CheckedListBox();
            this.btnGenerateEmail = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(654, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(228, 310);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(498, 361);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePassword.TabIndex = 3;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // optionsPassword
            // 
            this.optionsPassword.FormattingEnabled = true;
            this.optionsPassword.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsPassword.Location = new System.Drawing.Point(228, 335);
            this.optionsPassword.Name = "optionsPassword";
            this.optionsPassword.Size = new System.Drawing.Size(165, 49);
            this.optionsPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(225, 293);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(225, 189);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Username";
            // 
            // optionsUserName
            // 
            this.optionsUserName.FormattingEnabled = true;
            this.optionsUserName.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsUserName.Location = new System.Drawing.Point(228, 231);
            this.optionsUserName.Name = "optionsUserName";
            this.optionsUserName.Size = new System.Drawing.Size(165, 49);
            this.optionsUserName.TabIndex = 8;
            // 
            // btnGenerateUserName
            // 
            this.btnGenerateUserName.Location = new System.Drawing.Point(498, 257);
            this.btnGenerateUserName.Name = "btnGenerateUserName";
            this.btnGenerateUserName.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateUserName.TabIndex = 7;
            this.btnGenerateUserName.Text = "Generate";
            this.btnGenerateUserName.UseVisualStyleBackColor = true;
            this.btnGenerateUserName.Click += new System.EventHandler(this.btnGenerateUserName_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(228, 205);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtUserNameLength
            // 
            this.txtUserNameLength.Location = new System.Drawing.Point(399, 260);
            this.txtUserNameLength.Name = "txtUserNameLength";
            this.txtUserNameLength.Size = new System.Drawing.Size(88, 20);
            this.txtUserNameLength.TabIndex = 10;
            this.txtUserNameLength.Text = "8";
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(399, 364);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(88, 20);
            this.txtPasswordLength.TabIndex = 11;
            this.txtPasswordLength.Text = "8";
            // 
            // lblUserNameLength
            // 
            this.lblUserNameLength.AutoSize = true;
            this.lblUserNameLength.Location = new System.Drawing.Point(396, 244);
            this.lblUserNameLength.Name = "lblUserNameLength";
            this.lblUserNameLength.Size = new System.Drawing.Size(91, 13);
            this.lblUserNameLength.TabIndex = 12;
            this.lblUserNameLength.Text = "Username Length";
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Location = new System.Drawing.Point(399, 348);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(89, 13);
            this.lblPasswordLength.TabIndex = 13;
            this.lblPasswordLength.Text = "Password Length";
            // 
            // lblEmailSuffix
            // 
            this.lblEmailSuffix.AutoSize = true;
            this.lblEmailSuffix.Location = new System.Drawing.Point(396, 120);
            this.lblEmailSuffix.Name = "lblEmailSuffix";
            this.lblEmailSuffix.Size = new System.Drawing.Size(61, 13);
            this.lblEmailSuffix.TabIndex = 19;
            this.lblEmailSuffix.Text = "Email Suffix";
            // 
            // txtEmailSuffix
            // 
            this.txtEmailSuffix.Location = new System.Drawing.Point(399, 136);
            this.txtEmailSuffix.Name = "txtEmailSuffix";
            this.txtEmailSuffix.Size = new System.Drawing.Size(88, 20);
            this.txtEmailSuffix.TabIndex = 18;
            this.txtEmailSuffix.Text = "@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(225, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // optionsEmail
            // 
            this.optionsEmail.FormattingEnabled = true;
            this.optionsEmail.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsEmail.Location = new System.Drawing.Point(228, 107);
            this.optionsEmail.Name = "optionsEmail";
            this.optionsEmail.Size = new System.Drawing.Size(165, 49);
            this.optionsEmail.TabIndex = 16;
            // 
            // btnGenerateEmail
            // 
            this.btnGenerateEmail.Location = new System.Drawing.Point(498, 133);
            this.btnGenerateEmail.Name = "btnGenerateEmail";
            this.btnGenerateEmail.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateEmail.TabIndex = 15;
            this.btnGenerateEmail.Text = "Generate";
            this.btnGenerateEmail.UseVisualStyleBackColor = true;
            this.btnGenerateEmail.Click += new System.EventHandler(this.btnGenerateEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // FortiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmailSuffix);
            this.Controls.Add(this.txtEmailSuffix);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.optionsEmail);
            this.Controls.Add(this.btnGenerateEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPasswordLength);
            this.Controls.Add(this.lblUserNameLength);
            this.Controls.Add(this.txtPasswordLength);
            this.Controls.Add(this.txtUserNameLength);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.optionsUserName);
            this.Controls.Add(this.btnGenerateUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.optionsPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnExit);
            this.Name = "FortiPass";
            this.Text = "FortiPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.CheckedListBox optionsPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckedListBox optionsUserName;
        private System.Windows.Forms.Button btnGenerateUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserNameLength;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.Label lblUserNameLength;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.Label lblEmailSuffix;
        private System.Windows.Forms.TextBox txtEmailSuffix;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckedListBox optionsEmail;
        private System.Windows.Forms.Button btnGenerateEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

