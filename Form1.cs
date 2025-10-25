using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FortiPass;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace FortiPass
{
    public partial class FortiPass : Form
    {
        public class Account {
            public string Company { get; set; }
            public string Email { get; set; }
            public string Username { get; set; }

            public string Password { get; set; }
        }
        public class AccountRoot {
            public Dictionary<string, Account> Accounts { get; set; }
        }
        public FortiPass()
        {
            InitializeComponent();
            optionsPassword.CheckOnClick = true;
            optionsUserName.CheckOnClick = true;
            optionsEmail.CheckOnClick = true;
            string jsonText = File.ReadAllText(@"..\..\data\accounts.json");
            AccountRoot data = JsonConvert.DeserializeObject<AccountRoot>(jsonText);

            foreach( var kvp in data.Accounts ) {
                kvp.Value.Company = kvp.Key;
            }
            accountTable.DataSource = data.Accounts.Values.ToList();
            accountTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Form1_load(object sender,  EventArgs e)
        {
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
            txtEmail.Enabled = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string GeneratePassword( ) {
            bool passwordUseUpper = false;
            bool passwordUseNum = false;
            bool passwordUseSpecial = false;
            if( txtPassword.Text == "" ) { txtPasswordLength.Text = "8"; }
            uint passwordLength = Convert.ToUInt16(txtPasswordLength.Text);
            if( optionsPassword.GetItemChecked(0) ) { passwordUseUpper = true; }
            if( optionsPassword.GetItemChecked(1) ) { passwordUseNum = true; }
            if( optionsPassword.GetItemChecked(2) ) { passwordUseSpecial = true; }
            byte n = 0;
            while( passwordLength < 8 || passwordLength > 255 ) {

                if( n > 200 ) { passwordLength = 16; break; }
                passwordLength = (byte)( passwordLength % 16 );
                n++;
            }
            string password = PasswordGenerator.GeneratePassword((byte)passwordLength, passwordUseUpper, passwordUseNum, passwordUseSpecial);
            txtPassword.Text = password;
            return password;
        }

        private string GenerateUsername( ) {
            bool usernameUseUpper = false;
            bool usernameUseNum = false;
            bool usernameUseSpecial = false;
            if( txtUserNameLength.Text == "" ) { txtUserNameLength.Text = "8"; }
            uint usernameLength = Convert.ToUInt16(txtUserNameLength.Text);
            byte n = 0;
            while( usernameLength < 8 || usernameLength > 255 ) {

                if( n > 200 ) { usernameLength = 16; break; }
                usernameLength = (byte)( usernameLength % 16 );
                n++;
            }
            if( optionsUserName.GetItemChecked(0) ) { usernameUseUpper = true; }
            if( optionsUserName.GetItemChecked(1) ) { usernameUseNum = true; }
            if( optionsUserName.GetItemChecked(2) ) { usernameUseSpecial = true; }
            string username = UsernameGenerator.GenerateUserName((byte)usernameLength, usernameUseUpper, usernameUseNum, usernameUseSpecial);
            txtUserName.Text = username;
            return username;
        }

        private string GenerateEmail( ) {
            bool emailUseUpper = false;
            bool emailUseNum = false;
            bool emailUseSpecial = false;
            string suffix = txtEmailSuffix.Text;
            byte emailLength = NumberGenerator.GetRandomNumber(16);
            if( txtEmailSuffix.Text == "" ) { txtEmailSuffix.Text = "@gmail.com"; }
            if( optionsEmail.GetItemChecked(0) ) { emailUseUpper = true; }
            if( optionsEmail.GetItemChecked(1) ) { emailUseNum = true; }
            if( optionsEmail.GetItemChecked(2) ) { emailUseSpecial = true; }
            byte n = 0;
            while( emailLength < 8 || emailLength > 255 ) {

                if( n > 200 ) { emailLength = 16; break; }
                emailLength = (byte)( emailLength % 16 );
                n++;
            }
            string email = EmailGenerator.GenerateEmail(emailLength, emailUseUpper, emailUseNum, emailUseSpecial, suffix);
            txtEmail.Text = email;
            return email;
        }

        private void button1_Click( object sender, EventArgs e ) {
            pageViewer.SelectedTab = accountCreation;
        }

        private void btnAddAccount_Click( object sender, EventArgs e ) {
            pageViewer.SelectedTab = accountAdd;
        }

        private void btnViewAccount_Click( object sender, EventArgs e ) {
            pageViewer.SelectedTab = accountView;
            string jsonText = File.ReadAllText(@"..\..\data\accounts.json");
            AccountRoot data = JsonConvert.DeserializeObject<AccountRoot>(jsonText);

            foreach( var kvp in data.Accounts ) {
                kvp.Value.Company = kvp.Key;
            }
            accountTable.DataSource = data.Accounts.Values.ToList();
            accountTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAccountCreate_Click( object sender, EventArgs e ) {
            string email = txtEmail.Text;
            if(  txtEmail.Text == String.Empty  ) {
                email = GenerateEmail();
            }
            else {
                email = txtEmail.Text + txtEmailSuffix.Text;
            }
            
            string password = GeneratePassword();
            string username = GenerateUsername();
            string company = txtCompany.Text;

            Account account = new Account();
            account.Email = email;
            account.Password = password;
            account.Username = username;
            account.Company = company;

            string jsonText = File.ReadAllText(@"..\..\data\accounts.json");
            AccountRoot data = JsonConvert.DeserializeObject<AccountRoot>(jsonText);

            data.Accounts[company] = account;

            string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(@"..\..\data\accounts.json", updatedJson);
            MessageBox.Show($"Account for {company} created successfully");
            Thread.Sleep(100);
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompany.Text = string.Empty;
        }

        private void pageViewer_SelectedIndexChanged( object sender, EventArgs e ) {
            string jsonText = File.ReadAllText(@"..\..\data\accounts.json");
            AccountRoot data = JsonConvert.DeserializeObject<AccountRoot>(jsonText);

            foreach( var kvp in data.Accounts ) {
                kvp.Value.Company = kvp.Key;
            }
            accountTable.DataSource = data.Accounts.Values.ToList();
            accountTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAddExistingAccount_Click( object sender, EventArgs e ) {

            string email = txtAddEmail.Text + txtAddEmailSuffix.Text;
            string password = txtAddPassword.Text;
            string username = txtAddUsername.Text;
            string company = txtAddCompany.Text;

            Account account = new Account();
            account.Email = email;
            account.Password = password;
            account.Username = username;
            account.Company = company;

            string jsonText = File.ReadAllText(@"..\..\data\accounts.json");
            AccountRoot data = JsonConvert.DeserializeObject<AccountRoot>(jsonText);

            data.Accounts[ company ] = account;

            string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(@"..\..\data\accounts.json", updatedJson);
            MessageBox.Show($"Account for {company} Added successfully");
            Thread.Sleep(100);
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompany.Text = string.Empty;
        }
    }
}
