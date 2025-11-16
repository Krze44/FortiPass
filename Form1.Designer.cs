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
            System.Windows.Forms.Button btnCreateAccount;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.pageViewer = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtMasterPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accountCreation = new System.Windows.Forms.TabPage();
            this.btnAccountCreate = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblEmailSuffix = new System.Windows.Forms.Label();
            this.txtEmailSuffix = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.optionsEmail = new System.Windows.Forms.CheckedListBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.lblUserNameLength = new System.Windows.Forms.Label();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.txtUserNameLength = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.optionsUserName = new System.Windows.Forms.CheckedListBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.optionsPassword = new System.Windows.Forms.CheckedListBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.accountAdd = new System.Windows.Forms.TabPage();
            this.btnAddExistingAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddEmailSuffix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.accountView = new System.Windows.Forms.TabPage();
            this.accountTable = new System.Windows.Forms.DataGridView();
            this.lblNav = new System.Windows.Forms.Label();
            btnCreateAccount = new System.Windows.Forms.Button();
            this.pageViewer.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.accountCreation.SuspendLayout();
            this.accountAdd.SuspendLayout();
            this.accountView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCreateAccount.ForeColor = System.Drawing.Color.Black;
            btnCreateAccount.Location = new System.Drawing.Point(293, 51);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new System.Drawing.Size(136, 49);
            btnCreateAccount.TabIndex = 20;
            btnCreateAccount.Text = "Create";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += new System.EventHandler(this.btnAccountCreate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(862, 620);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAccount.Location = new System.Drawing.Point(435, 51);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(136, 49);
            this.btnAddAccount.TabIndex = 21;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.btnViewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccount.ForeColor = System.Drawing.Color.Black;
            this.btnViewAccount.Location = new System.Drawing.Point(577, 51);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(138, 49);
            this.btnViewAccount.TabIndex = 22;
            this.btnViewAccount.Text = "View";
            this.btnViewAccount.UseVisualStyleBackColor = false;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // pageViewer
            // 
            this.pageViewer.Controls.Add(this.tabLogin);
            this.pageViewer.Controls.Add(this.accountCreation);
            this.pageViewer.Controls.Add(this.accountAdd);
            this.pageViewer.Controls.Add(this.accountView);
            this.pageViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageViewer.HotTrack = true;
            this.pageViewer.ItemSize = new System.Drawing.Size(72, 25);
            this.pageViewer.Location = new System.Drawing.Point(43, 106);
            this.pageViewer.Name = "pageViewer";
            this.pageViewer.SelectedIndex = 0;
            this.pageViewer.Size = new System.Drawing.Size(912, 508);
            this.pageViewer.TabIndex = 24;
            this.pageViewer.SelectedIndexChanged += new System.EventHandler(this.pageViewer_SelectedIndexChanged);
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabLogin.Controls.Add(this.btnForgotPassword);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.txtMasterPassword);
            this.tabLogin.Controls.Add(this.label4);
            this.tabLogin.Location = new System.Drawing.Point(4, 29);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(904, 475);
            this.tabLogin.TabIndex = 3;
            this.tabLogin.Text = "Login";
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.ForeColor = System.Drawing.Color.Black;
            this.btnForgotPassword.Location = new System.Drawing.Point(551, 305);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(134, 49);
            this.btnForgotPassword.TabIndex = 27;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(248, 303);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 49);
            this.btnLogin.TabIndex = 26;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMasterPassword
            // 
            this.txtMasterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtMasterPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMasterPassword.ForeColor = System.Drawing.Color.White;
            this.txtMasterPassword.Location = new System.Drawing.Point(246, 224);
            this.txtMasterPassword.MaximumSize = new System.Drawing.Size(439, 30);
            this.txtMasterPassword.MinimumSize = new System.Drawing.Size(439, 30);
            this.txtMasterPassword.Name = "txtMasterPassword";
            this.txtMasterPassword.Size = new System.Drawing.Size(439, 15);
            this.txtMasterPassword.TabIndex = 1;
            this.txtMasterPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Your Master Password:";
            // 
            // accountCreation
            // 
            this.accountCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountCreation.Controls.Add(this.btnAccountCreate);
            this.accountCreation.Controls.Add(this.lblCompany);
            this.accountCreation.Controls.Add(this.txtCompany);
            this.accountCreation.Controls.Add(this.lblEmailSuffix);
            this.accountCreation.Controls.Add(this.txtEmailSuffix);
            this.accountCreation.Controls.Add(this.lblEmail);
            this.accountCreation.Controls.Add(this.optionsEmail);
            this.accountCreation.Controls.Add(this.txtEmail);
            this.accountCreation.Controls.Add(this.lblPasswordLength);
            this.accountCreation.Controls.Add(this.lblUserNameLength);
            this.accountCreation.Controls.Add(this.txtPasswordLength);
            this.accountCreation.Controls.Add(this.txtUserNameLength);
            this.accountCreation.Controls.Add(this.lblUserName);
            this.accountCreation.Controls.Add(this.optionsUserName);
            this.accountCreation.Controls.Add(this.txtUserName);
            this.accountCreation.Controls.Add(this.lblPassword);
            this.accountCreation.Controls.Add(this.optionsPassword);
            this.accountCreation.Controls.Add(this.txtPassword);
            this.accountCreation.ForeColor = System.Drawing.Color.White;
            this.accountCreation.Location = new System.Drawing.Point(4, 29);
            this.accountCreation.Name = "accountCreation";
            this.accountCreation.Padding = new System.Windows.Forms.Padding(3);
            this.accountCreation.Size = new System.Drawing.Size(904, 475);
            this.accountCreation.TabIndex = 0;
            this.accountCreation.Text = "Create";
            // 
            // btnAccountCreate
            // 
            this.btnAccountCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.btnAccountCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.btnAccountCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccountCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountCreate.ForeColor = System.Drawing.Color.Black;
            this.btnAccountCreate.Location = new System.Drawing.Point(778, 424);
            this.btnAccountCreate.Name = "btnAccountCreate";
            this.btnAccountCreate.Size = new System.Drawing.Size(108, 40);
            this.btnAccountCreate.TabIndex = 40;
            this.btnAccountCreate.Text = "Generate Account";
            this.btnAccountCreate.UseVisualStyleBackColor = false;
            this.btnAccountCreate.Click += new System.EventHandler(this.btnAccountCreate_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(295, 83);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(65, 16);
            this.lblCompany.TabIndex = 39;
            this.lblCompany.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompany.ForeColor = System.Drawing.Color.White;
            this.txtCompany.Location = new System.Drawing.Point(298, 102);
            this.txtCompany.MaximumSize = new System.Drawing.Size(500, 30);
            this.txtCompany.MinimumSize = new System.Drawing.Size(227, 22);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(227, 15);
            this.txtCompany.TabIndex = 38;
            // 
            // lblEmailSuffix
            // 
            this.lblEmailSuffix.AutoSize = true;
            this.lblEmailSuffix.Location = new System.Drawing.Point(466, 194);
            this.lblEmailSuffix.Name = "lblEmailSuffix";
            this.lblEmailSuffix.Size = new System.Drawing.Size(75, 16);
            this.lblEmailSuffix.TabIndex = 37;
            this.lblEmailSuffix.Text = "Email Suffix";
            // 
            // txtEmailSuffix
            // 
            this.txtEmailSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtEmailSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailSuffix.ForeColor = System.Drawing.Color.White;
            this.txtEmailSuffix.Location = new System.Drawing.Point(469, 213);
            this.txtEmailSuffix.MaximumSize = new System.Drawing.Size(88, 27);
            this.txtEmailSuffix.MinimumSize = new System.Drawing.Size(88, 19);
            this.txtEmailSuffix.Name = "txtEmailSuffix";
            this.txtEmailSuffix.Size = new System.Drawing.Size(88, 15);
            this.txtEmailSuffix.TabIndex = 36;
            this.txtEmailSuffix.Text = "@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(295, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            // 
            // optionsEmail
            // 
            this.optionsEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.optionsEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionsEmail.ForeColor = System.Drawing.Color.White;
            this.optionsEmail.FormattingEnabled = true;
            this.optionsEmail.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsEmail.Location = new System.Drawing.Point(298, 181);
            this.optionsEmail.Name = "optionsEmail";
            this.optionsEmail.Size = new System.Drawing.Size(165, 51);
            this.optionsEmail.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(298, 155);
            this.txtEmail.MaximumSize = new System.Drawing.Size(500, 30);
            this.txtEmail.MinimumSize = new System.Drawing.Size(227, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 15);
            this.txtEmail.TabIndex = 32;
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Location = new System.Drawing.Point(463, 405);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(110, 16);
            this.lblPasswordLength.TabIndex = 31;
            this.lblPasswordLength.Text = "Password Length";
            // 
            // lblUserNameLength
            // 
            this.lblUserNameLength.AutoSize = true;
            this.lblUserNameLength.Location = new System.Drawing.Point(466, 303);
            this.lblUserNameLength.Name = "lblUserNameLength";
            this.lblUserNameLength.Size = new System.Drawing.Size(113, 16);
            this.lblUserNameLength.TabIndex = 30;
            this.lblUserNameLength.Text = "Username Length";
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtPasswordLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordLength.ForeColor = System.Drawing.Color.White;
            this.txtPasswordLength.Location = new System.Drawing.Point(466, 424);
            this.txtPasswordLength.MaximumSize = new System.Drawing.Size(88, 25);
            this.txtPasswordLength.MinimumSize = new System.Drawing.Size(88, 18);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(88, 15);
            this.txtPasswordLength.TabIndex = 29;
            this.txtPasswordLength.Text = "8";
            // 
            // txtUserNameLength
            // 
            this.txtUserNameLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtUserNameLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameLength.ForeColor = System.Drawing.Color.White;
            this.txtUserNameLength.Location = new System.Drawing.Point(469, 322);
            this.txtUserNameLength.MaximumSize = new System.Drawing.Size(88, 25);
            this.txtUserNameLength.MinimumSize = new System.Drawing.Size(88, 18);
            this.txtUserNameLength.Name = "txtUserNameLength";
            this.txtUserNameLength.Size = new System.Drawing.Size(88, 15);
            this.txtUserNameLength.TabIndex = 28;
            this.txtUserNameLength.Text = "8";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(295, 247);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 16);
            this.lblUserName.TabIndex = 27;
            this.lblUserName.Text = "Username";
            // 
            // optionsUserName
            // 
            this.optionsUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.optionsUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionsUserName.ForeColor = System.Drawing.Color.White;
            this.optionsUserName.FormattingEnabled = true;
            this.optionsUserName.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsUserName.Location = new System.Drawing.Point(298, 289);
            this.optionsUserName.Name = "optionsUserName";
            this.optionsUserName.Size = new System.Drawing.Size(165, 51);
            this.optionsUserName.TabIndex = 26;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(298, 263);
            this.txtUserName.MaximumSize = new System.Drawing.Size(500, 30);
            this.txtUserName.MinimumSize = new System.Drawing.Size(227, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 15);
            this.txtUserName.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(292, 350);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // optionsPassword
            // 
            this.optionsPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.optionsPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionsPassword.ForeColor = System.Drawing.Color.White;
            this.optionsPassword.FormattingEnabled = true;
            this.optionsPassword.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsPassword.Location = new System.Drawing.Point(295, 394);
            this.optionsPassword.Name = "optionsPassword";
            this.optionsPassword.Size = new System.Drawing.Size(165, 51);
            this.optionsPassword.TabIndex = 22;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(295, 369);
            this.txtPassword.MaximumSize = new System.Drawing.Size(500, 30);
            this.txtPassword.MinimumSize = new System.Drawing.Size(227, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 15);
            this.txtPassword.TabIndex = 20;
            // 
            // accountAdd
            // 
            this.accountAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountAdd.Controls.Add(this.btnAddExistingAccount);
            this.accountAdd.Controls.Add(this.label1);
            this.accountAdd.Controls.Add(this.txtAddCompany);
            this.accountAdd.Controls.Add(this.label2);
            this.accountAdd.Controls.Add(this.txtAddEmailSuffix);
            this.accountAdd.Controls.Add(this.label3);
            this.accountAdd.Controls.Add(this.txtAddEmail);
            this.accountAdd.Controls.Add(this.label6);
            this.accountAdd.Controls.Add(this.txtAddUsername);
            this.accountAdd.Controls.Add(this.label7);
            this.accountAdd.Controls.Add(this.txtAddPassword);
            this.accountAdd.Location = new System.Drawing.Point(4, 29);
            this.accountAdd.Name = "accountAdd";
            this.accountAdd.Padding = new System.Windows.Forms.Padding(3);
            this.accountAdd.Size = new System.Drawing.Size(904, 475);
            this.accountAdd.TabIndex = 1;
            this.accountAdd.Text = "Add";
            // 
            // btnAddExistingAccount
            // 
            this.btnAddExistingAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(131)))));
            this.btnAddExistingAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddExistingAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExistingAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAddExistingAccount.Location = new System.Drawing.Point(750, 401);
            this.btnAddExistingAccount.Name = "btnAddExistingAccount";
            this.btnAddExistingAccount.Size = new System.Drawing.Size(120, 44);
            this.btnAddExistingAccount.TabIndex = 58;
            this.btnAddExistingAccount.Text = "Add Account";
            this.btnAddExistingAccount.UseVisualStyleBackColor = false;
            this.btnAddExistingAccount.Click += new System.EventHandler(this.btnAddExistingAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Company";
            // 
            // txtAddCompany
            // 
            this.txtAddCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtAddCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddCompany.ForeColor = System.Drawing.Color.White;
            this.txtAddCompany.Location = new System.Drawing.Point(328, 88);
            this.txtAddCompany.MaximumSize = new System.Drawing.Size(500, 30);
            this.txtAddCompany.MinimumSize = new System.Drawing.Size(227, 22);
            this.txtAddCompany.Name = "txtAddCompany";
            this.txtAddCompany.Size = new System.Drawing.Size(227, 15);
            this.txtAddCompany.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Email Suffix";
            // 
            // txtAddEmailSuffix
            // 
            this.txtAddEmailSuffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtAddEmailSuffix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddEmailSuffix.ForeColor = System.Drawing.Color.White;
            this.txtAddEmailSuffix.Location = new System.Drawing.Point(561, 163);
            this.txtAddEmailSuffix.MaximumSize = new System.Drawing.Size(100, 30);
            this.txtAddEmailSuffix.MinimumSize = new System.Drawing.Size(88, 22);
            this.txtAddEmailSuffix.Name = "txtAddEmailSuffix";
            this.txtAddEmailSuffix.Size = new System.Drawing.Size(88, 15);
            this.txtAddEmailSuffix.TabIndex = 54;
            this.txtAddEmailSuffix.Text = "@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtAddEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddEmail.ForeColor = System.Drawing.Color.White;
            this.txtAddEmail.Location = new System.Drawing.Point(328, 163);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(227, 22);
            this.txtAddEmail.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Username";
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtAddUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddUsername.ForeColor = System.Drawing.Color.White;
            this.txtAddUsername.Location = new System.Drawing.Point(329, 234);
            this.txtAddUsername.MaximumSize = new System.Drawing.Size(500, 30);
            this.txtAddUsername.MinimumSize = new System.Drawing.Size(227, 22);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(227, 15);
            this.txtAddUsername.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Password";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtAddPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddPassword.ForeColor = System.Drawing.Color.White;
            this.txtAddPassword.Location = new System.Drawing.Point(328, 317);
            this.txtAddPassword.MaximumSize = new System.Drawing.Size(500, 30);
            this.txtAddPassword.MinimumSize = new System.Drawing.Size(227, 22);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(227, 15);
            this.txtAddPassword.TabIndex = 41;
            this.txtAddPassword.UseSystemPasswordChar = true;
            // 
            // accountView
            // 
            this.accountView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountView.Controls.Add(this.accountTable);
            this.accountView.Location = new System.Drawing.Point(4, 29);
            this.accountView.Name = "accountView";
            this.accountView.Size = new System.Drawing.Size(904, 475);
            this.accountView.TabIndex = 2;
            this.accountView.Text = "View";
            // 
            // accountTable
            // 
            this.accountTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.accountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.accountTable.EnableHeadersVisualStyles = false;
            this.accountTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(160)))), ((int)(((byte)(161)))));
            this.accountTable.Location = new System.Drawing.Point(109, 38);
            this.accountTable.Name = "accountTable";
            this.accountTable.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.accountTable.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.accountTable.Size = new System.Drawing.Size(703, 412);
            this.accountTable.TabIndex = 0;
            // 
            // lblNav
            // 
            this.lblNav.AutoSize = true;
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNav.Location = new System.Drawing.Point(403, 9);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(182, 39);
            this.lblNav.TabIndex = 25;
            this.lblNav.Text = "Nav Menu";
            // 
            // FortiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.lblNav);
            this.Controls.Add(this.pageViewer);
            this.Controls.Add(this.btnViewAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(btnCreateAccount);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FortiPass";
            this.Text = "FortiPass";
            this.pageViewer.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.accountCreation.ResumeLayout(false);
            this.accountCreation.PerformLayout();
            this.accountAdd.ResumeLayout(false);
            this.accountAdd.PerformLayout();
            this.accountView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TabControl pageViewer;
        private System.Windows.Forms.TabPage accountCreation;
        private System.Windows.Forms.Label lblEmailSuffix;
        private System.Windows.Forms.TextBox txtEmailSuffix;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckedListBox optionsEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.Label lblUserNameLength;
        private System.Windows.Forms.TextBox txtPasswordLength;
        private System.Windows.Forms.TextBox txtUserNameLength;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.CheckedListBox optionsUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckedListBox optionsPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TabPage accountAdd;
        private System.Windows.Forms.TabPage accountView;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.DataGridView accountTable;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button btnAccountCreate;
        private System.Windows.Forms.Button btnAddExistingAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddEmailSuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TextBox txtMasterPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

