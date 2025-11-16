using FortiPass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public class AccountRoot
        {
            public Dictionary<string, Account> Accounts { get; set; }
        }
        public class UserData {
            public string MasterPassword { get; set; }
            public bool IsFirstTimeUser { get; set; }

            public bool IsLoggedIn { get; set; }

            public byte[] privateKey { get; set; }
            
            public string Salt { get; set; }
        }

        UserData user = new UserData();

        public FortiPass()
        {
            InitializeComponent();
            init();
            userInit();

        }

        public void ForgotPassword( ) {
            // not implemented yet
        }

        // entire thing is AI generated, I dont know exactly how it works
        public string Encrypt( string plainText, byte[] key ) {
            using( Aes aes = Aes.Create() ) {
                aes.Key = key;
                aes.GenerateIV();

                using( var ms = new MemoryStream() ) {
                    ms.Write(aes.IV, 0, aes.IV.Length);
                    using( var encryptor = aes.CreateEncryptor(aes.Key, aes.IV) )
                    using( var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write) ) {
                        using( var sw = new StreamWriter(cs) ) {
                            sw.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }



        // entire thing is AI generated, I dont know exactly how it works
        public string Decrypt(string cipherText, byte[] key ) {
            byte[] fullCipher = Convert.FromBase64String(cipherText);
            using( Aes aes = Aes.Create() ) {
                aes.Key = key;
                byte[] iv = new byte[aes.BlockSize / 8];
                Array.Copy(fullCipher, iv, iv.Length);
                byte[] cipher = new byte[fullCipher.Length - iv.Length];      
                Array.Copy(fullCipher, iv.Length, cipher, 0, cipher.Length);
                aes.IV = iv;
                using( var decryptor = aes.CreateDecryptor(aes.Key, aes.IV) )
                using( var ms = new MemoryStream(cipher) )
                using( var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read) )
                using( var sr = new StreamReader(cs) ) {
                    return sr.ReadToEnd();
                }
            }
        }

        public void userInit() {
            string[] rawData = File.ReadAllLines(@"..\..\config.ini");
            string[] cleanedData = new string[ 2 ];

            foreach( var line in rawData ) {
                if( line.StartsWith("MasterPassword= ") ) {
                    cleanedData[ 0 ] = line.Replace("MasterPassword= ", "").Trim();
                    user.MasterPassword = cleanedData[ 0 ];
                }
                else if( line.StartsWith("IsFirstTimeUser= ") ) {

                    cleanedData[ 1 ] = line.Replace("IsFirstTimeUser= ", "").Trim();
                    user.IsFirstTimeUser = bool.Parse(cleanedData[ 1 ].ToLower().Trim());
                }
                else if( line.StartsWith("Salt= ") ) {

                    user.Salt = line.Replace("Salt=", "").Trim();
                }
            }
        }

        public void refreshAccountTable() {
            string jsonText = File.ReadAllText(@"..\..\data\accounts.json");
            AccountRoot data = JsonConvert.DeserializeObject<AccountRoot>(jsonText);

            foreach( var kvp in data.Accounts ) {
                kvp.Value.Company = kvp.Key;
                kvp.Value.Password = Decrypt(kvp.Value.Password.Trim(), user.privateKey);
            }
            accountTable.DataSource = data.Accounts.Values.ToList();
            accountTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void init() {
            optionsPassword.CheckOnClick = true;
            optionsUserName.CheckOnClick = true;
            optionsEmail.CheckOnClick = true;
            MessageBox.Show("Welcome to FortiPass! Don't Forget to enter/create your master Password!!");
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
            if( txtPasswordLength.Text == "" ) { txtPasswordLength.Text = "8"; }
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
            if( txtEmailSuffix.Text == "" ) { txtEmailSuffix.Text = "8"; }

            string email = EmailGenerator.GenerateEmail((byte)emailLength, emailUseUpper, emailUseNum, emailUseSpecial, suffix);
            txtEmail.Text = email;
            return email;
        }

        private void button1_Click( object sender, EventArgs e ) {
            if( user.IsLoggedIn ) {
                pageViewer.SelectedTab = accountCreation;
            }
            else {
                MessageBox.Show("Please login first!");
            }
                
        }

        private void btnAddAccount_Click( object sender, EventArgs e ) {
            
            if( user.IsLoggedIn ) {
                pageViewer.SelectedTab = accountAdd;
            }
            else {
                MessageBox.Show("Please login first!");
            }
        }

        private void btnViewAccount_Click( object sender, EventArgs e ) {
            if( user.IsLoggedIn ) {
                refreshAccountTable();
                pageViewer.SelectedTab = accountView;
            }
            else {
                MessageBox.Show("Please login first!");
            }
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
            string cipheredPassword = Encrypt(password, user.privateKey);

            Account account = new Account();
            account.Email = email;
            account.Password = cipheredPassword;
            account.Username = username;
            account.Company = company;
            txtPassword.Text = cipheredPassword;

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
            if( user.IsLoggedIn ) {
                refreshAccountTable();
            }
            else if( pageViewer.SelectedTab == tabLogin ) {
                // do nothing, allow login
            }
            else {
                pageViewer.SelectedTab = tabLogin;
                MessageBox.Show("Please login first!");                
            }
        }

        private void btnAddExistingAccount_Click( object sender, EventArgs e ) {

           
            string email = txtAddEmail.Text + txtAddEmailSuffix.Text;
            string password = txtAddPassword.Text;
            string username = txtAddUsername.Text;
            string company = txtAddCompany.Text;
            string cipheredPassword = Encrypt(password, user.privateKey);

            Account account = new Account();
            account.Email = email;
            account.Password = cipheredPassword;
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

        private void btnLogin_Click( object sender, EventArgs e ) {
            string plainTextPassword = txtMasterPassword.Text;
            string hashedPassword = "";
            // hash the password
            using( SHA256 sha256 = SHA256.Create() ) {
                byte[] bytes = sha256.ComputeHash( Encoding.UTF8.GetBytes(plainTextPassword) );
                hashedPassword = Convert.ToBase64String(bytes);
            }        

            if (hashedPassword == user.MasterPassword && ! (user.IsFirstTimeUser) ) { 
                user.IsLoggedIn = true;
                // Verified the possibility of key derivation from master password with AI
                using( var derivedBytes = new Rfc2898DeriveBytes(hashedPassword, Convert.FromBase64String(user.Salt), 100000) ) {
                    user.privateKey = derivedBytes.GetBytes(32); // 256 bits key
                }
                MessageBox.Show("Login Successful!");
                pageViewer.TabPages.Remove(tabLogin);
                pageViewer.SelectedTab = accountView;
                refreshAccountTable();

            }
            else if( user.IsFirstTimeUser ) {
                user.MasterPassword = hashedPassword;            
                MessageBox.Show("Master Password Set! Thanks for using Fortipass!");
                byte[] salt = new byte[ 16 ];
                while (salt.Length < 16) {
                    using( var rng = new RNGCryptoServiceProvider() ) {
                        rng.GetBytes(salt);
                    }
                }         
                user.Salt = Convert.ToBase64String(salt);
                // Verified the possibility of key derivation from master password with AI
                using( var derivedBytes = new Rfc2898DeriveBytes(hashedPassword, salt, 100000) ) {
                    user.privateKey = derivedBytes.GetBytes(32); // 256 bits key

                }
                File.WriteAllLines(@"..\..\config.ini", new string[] { $"MasterPassword= {hashedPassword}", "IsFirstTimeUser= False", $"Salt= {user.Salt}" });
                user.IsLoggedIn = true;
                pageViewer.TabPages.Remove(tabLogin);
                pageViewer.SelectedTab = accountView;
                refreshAccountTable();
            }
            else {
                MessageBox.Show("Incorrect Master Password. Please try again.");
                txtMasterPassword.Text = string.Empty;
            }
            
        }
    }
}
