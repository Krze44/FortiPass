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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.pageViewer = new System.Windows.Forms.TabControl();
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
            this.accountView = new System.Windows.Forms.TabPage();
            this.accountTable = new System.Windows.Forms.DataGridView();
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
            btnCreateAccount = new System.Windows.Forms.Button();
            this.pageViewer.SuspendLayout();
            this.accountCreation.SuspendLayout();
            this.accountAdd.SuspendLayout();
            this.accountView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new System.Drawing.Point(654, 68);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new System.Drawing.Size(136, 49);
            btnCreateAccount.TabIndex = 20;
            btnCreateAccount.Text = "Create";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(654, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(654, 123);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(136, 49);
            this.btnAddAccount.TabIndex = 21;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(652, 178);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(138, 49);
            this.btnViewAccount.TabIndex = 22;
            this.btnViewAccount.Text = "View";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // pageViewer
            // 
            this.pageViewer.Controls.Add(this.accountCreation);
            this.pageViewer.Controls.Add(this.accountAdd);
            this.pageViewer.Controls.Add(this.accountView);
            this.pageViewer.Location = new System.Drawing.Point(39, 37);
            this.pageViewer.Name = "pageViewer";
            this.pageViewer.SelectedIndex = 0;
            this.pageViewer.Size = new System.Drawing.Size(596, 401);
            this.pageViewer.TabIndex = 24;
            this.pageViewer.SelectedIndexChanged += new System.EventHandler(this.pageViewer_SelectedIndexChanged);
            // 
            // accountCreation
            // 
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
            this.accountCreation.Location = new System.Drawing.Point(4, 22);
            this.accountCreation.Name = "accountCreation";
            this.accountCreation.Padding = new System.Windows.Forms.Padding(3);
            this.accountCreation.Size = new System.Drawing.Size(588, 375);
            this.accountCreation.TabIndex = 0;
            this.accountCreation.Text = "Create";
            this.accountCreation.UseVisualStyleBackColor = true;
            // 
            // btnAccountCreate
            // 
            this.btnAccountCreate.Location = new System.Drawing.Point(471, 334);
            this.btnAccountCreate.Name = "btnAccountCreate";
            this.btnAccountCreate.Size = new System.Drawing.Size(100, 28);
            this.btnAccountCreate.TabIndex = 40;
            this.btnAccountCreate.Text = "Create Account";
            this.btnAccountCreate.UseVisualStyleBackColor = true;
            this.btnAccountCreate.Click += new System.EventHandler(this.btnAccountCreate_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(147, 33);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 39;
            this.lblCompany.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(153, 49);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(228, 20);
            this.txtCompany.TabIndex = 38;
            // 
            // lblEmailSuffix
            // 
            this.lblEmailSuffix.AutoSize = true;
            this.lblEmailSuffix.Location = new System.Drawing.Point(321, 127);
            this.lblEmailSuffix.Name = "lblEmailSuffix";
            this.lblEmailSuffix.Size = new System.Drawing.Size(61, 13);
            this.lblEmailSuffix.TabIndex = 37;
            this.lblEmailSuffix.Text = "Email Suffix";
            // 
            // txtEmailSuffix
            // 
            this.txtEmailSuffix.Location = new System.Drawing.Point(324, 143);
            this.txtEmailSuffix.Name = "txtEmailSuffix";
            this.txtEmailSuffix.Size = new System.Drawing.Size(88, 20);
            this.txtEmailSuffix.TabIndex = 36;
            this.txtEmailSuffix.Text = "@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(150, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            // 
            // optionsEmail
            // 
            this.optionsEmail.FormattingEnabled = true;
            this.optionsEmail.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsEmail.Location = new System.Drawing.Point(153, 114);
            this.optionsEmail.Name = "optionsEmail";
            this.optionsEmail.Size = new System.Drawing.Size(165, 49);
            this.optionsEmail.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 20);
            this.txtEmail.TabIndex = 32;
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Location = new System.Drawing.Point(324, 326);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(89, 13);
            this.lblPasswordLength.TabIndex = 31;
            this.lblPasswordLength.Text = "Password Length";
            // 
            // lblUserNameLength
            // 
            this.lblUserNameLength.AutoSize = true;
            this.lblUserNameLength.Location = new System.Drawing.Point(321, 222);
            this.lblUserNameLength.Name = "lblUserNameLength";
            this.lblUserNameLength.Size = new System.Drawing.Size(91, 13);
            this.lblUserNameLength.TabIndex = 30;
            this.lblUserNameLength.Text = "Username Length";
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(324, 342);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(88, 20);
            this.txtPasswordLength.TabIndex = 29;
            this.txtPasswordLength.Text = "8";
            // 
            // txtUserNameLength
            // 
            this.txtUserNameLength.Location = new System.Drawing.Point(324, 238);
            this.txtUserNameLength.Name = "txtUserNameLength";
            this.txtUserNameLength.Size = new System.Drawing.Size(88, 20);
            this.txtUserNameLength.TabIndex = 28;
            this.txtUserNameLength.Text = "8";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(150, 167);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 27;
            this.lblUserName.Text = "Username";
            // 
            // optionsUserName
            // 
            this.optionsUserName.FormattingEnabled = true;
            this.optionsUserName.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsUserName.Location = new System.Drawing.Point(153, 209);
            this.optionsUserName.Name = "optionsUserName";
            this.optionsUserName.Size = new System.Drawing.Size(165, 49);
            this.optionsUserName.TabIndex = 26;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(153, 183);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(227, 20);
            this.txtUserName.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(150, 271);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // optionsPassword
            // 
            this.optionsPassword.FormattingEnabled = true;
            this.optionsPassword.Items.AddRange(new object[] {
            "Use Uppercase Letters",
            "Use Numbers",
            "Use Special Characters"});
            this.optionsPassword.Location = new System.Drawing.Point(153, 313);
            this.optionsPassword.Name = "optionsPassword";
            this.optionsPassword.Size = new System.Drawing.Size(165, 49);
            this.optionsPassword.TabIndex = 22;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 288);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(227, 20);
            this.txtPassword.TabIndex = 20;
            // 
            // accountAdd
            // 
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
            this.accountAdd.Location = new System.Drawing.Point(4, 22);
            this.accountAdd.Name = "accountAdd";
            this.accountAdd.Padding = new System.Windows.Forms.Padding(3);
            this.accountAdd.Size = new System.Drawing.Size(588, 375);
            this.accountAdd.TabIndex = 1;
            this.accountAdd.Text = "Add";
            this.accountAdd.UseVisualStyleBackColor = true;
            // 
            // accountView
            // 
            this.accountView.Controls.Add(this.accountTable);
            this.accountView.Location = new System.Drawing.Point(4, 22);
            this.accountView.Name = "accountView";
            this.accountView.Size = new System.Drawing.Size(588, 375);
            this.accountView.TabIndex = 2;
            this.accountView.Text = "View";
            this.accountView.UseVisualStyleBackColor = true;
            // 
            // accountTable
            // 
            this.accountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTable.Enabled = false;
            this.accountTable.Location = new System.Drawing.Point(2, 1);
            this.accountTable.Name = "accountTable";
            this.accountTable.Size = new System.Drawing.Size(585, 377);
            this.accountTable.TabIndex = 0;
            // 
            // btnAddExistingAccount
            // 
            this.btnAddExistingAccount.Location = new System.Drawing.Point(482, 341);
            this.btnAddExistingAccount.Name = "btnAddExistingAccount";
            this.btnAddExistingAccount.Size = new System.Drawing.Size(100, 28);
            this.btnAddExistingAccount.TabIndex = 58;
            this.btnAddExistingAccount.Text = "Add Account";
            this.btnAddExistingAccount.UseVisualStyleBackColor = true;
            this.btnAddExistingAccount.Click += new System.EventHandler(this.btnAddExistingAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Company";
            // 
            // txtAddCompany
            // 
            this.txtAddCompany.Location = new System.Drawing.Point(152, 109);
            this.txtAddCompany.Name = "txtAddCompany";
            this.txtAddCompany.Size = new System.Drawing.Size(228, 20);
            this.txtAddCompany.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Email Suffix";
            // 
            // txtAddEmailSuffix
            // 
            this.txtAddEmailSuffix.Location = new System.Drawing.Point(385, 149);
            this.txtAddEmailSuffix.Name = "txtAddEmailSuffix";
            this.txtAddEmailSuffix.Size = new System.Drawing.Size(88, 20);
            this.txtAddEmailSuffix.TabIndex = 54;
            this.txtAddEmailSuffix.Text = "@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(152, 148);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(227, 20);
            this.txtAddEmail.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Username";
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Location = new System.Drawing.Point(152, 187);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(227, 20);
            this.txtAddUsername.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Password";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(152, 227);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(227, 20);
            this.txtAddPassword.TabIndex = 41;
            // 
            // FortiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pageViewer);
            this.Controls.Add(this.btnViewAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(btnCreateAccount);
            this.Name = "FortiPass";
            this.Text = "FortiPass";
            this.pageViewer.ResumeLayout(false);
            this.accountCreation.ResumeLayout(false);
            this.accountCreation.PerformLayout();
            this.accountAdd.ResumeLayout(false);
            this.accountAdd.PerformLayout();
            this.accountView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).EndInit();
            this.ResumeLayout(false);

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
    }
}

