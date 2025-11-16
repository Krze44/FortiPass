/*
 * Author - Justin Brayshaw
 * Date - 11/15/2025
 * Class - 80309
 * email - jbraysha@students.solano.edu
 * Desc - Local Password Manager Application
 * HC - I will conduct myself with honor and integrity at all times
 * AI - Entire Encryption/Decryption and Key Derivation portions of this code were generated with the assistance of AI. All other portions of this code were written by me without AI assistance.
 */


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
        // Account data structure
        public class Account {
            public string Company { get; set; }
            public string Email { get; set; }
            public string Username { get; set; }

            public string Password { get; set; }
        }
        // Root structure for JSON deserialization
        public class AccountRoot
        {
            public Dictionary<string, Account> Accounts { get; set; }
        }
        // User data structure
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
        // Initialize user data from config file
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
        // Refresh account table data
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
        // Initial setup
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
            // initialize password options
            bool passwordUseUpper = false;
            bool passwordUseNum = false;
            bool passwordUseSpecial = false;
            // if length is empty, set default
            if( txtPasswordLength.Text == "" ) { txtPasswordLength.Text = "8"; }
            uint passwordLength = Convert.ToUInt16(txtPasswordLength.Text);
            // set options
            if( optionsPassword.GetItemChecked(0) ) { passwordUseUpper = true; }
            if( optionsPassword.GetItemChecked(1) ) { passwordUseNum = true; }
            if( optionsPassword.GetItemChecked(2) ) { passwordUseSpecial = true; }
            byte n = 0;
            // ensure length is within bounds
            while( passwordLength < 8 || passwordLength > 255 ) {
                // if too many attempts, set default
                if( n > 200 ) { passwordLength = 16; break; }
                // modulus to bring into range
                passwordLength = (byte)( passwordLength % 16 );
                n++;
            }
            // generate password
            string password = PasswordGenerator.GeneratePassword((byte)passwordLength, passwordUseUpper, passwordUseNum, passwordUseSpecial);
            txtPassword.Text = password;
            return password;
        }

        private string GenerateUsername( ) {
            // initialize username options
            bool usernameUseUpper = false;
            bool usernameUseNum = false;
            bool usernameUseSpecial = false;
            //if length is empty, set default
            if( txtUserNameLength.Text == "" ) { txtUserNameLength.Text = "8"; }
            uint usernameLength = Convert.ToUInt16(txtUserNameLength.Text);
            byte n = 0;
            // ensure length is within bounds
            while( usernameLength < 8 || usernameLength > 255 ) {

                if( n > 200 ) { usernameLength = 16; break; }
                usernameLength = (byte)( usernameLength % 16 );
                n++;
            }
            // set options
            if( optionsUserName.GetItemChecked(0) ) { usernameUseUpper = true; }
            if( optionsUserName.GetItemChecked(1) ) { usernameUseNum = true; }
            if( optionsUserName.GetItemChecked(2) ) { usernameUseSpecial = true; }
            // generate username
            string username = UsernameGenerator.GenerateUserName((byte)usernameLength, usernameUseUpper, usernameUseNum, usernameUseSpecial);
            txtUserName.Text = username;
            return username;
        }

        private string GenerateEmail( ) {
            // initialize email options
            bool emailUseUpper = false;
            bool emailUseNum = false;
            bool emailUseSpecial = false;
            // get suffix
            string suffix = txtEmailSuffix.Text;
            // get length
            byte emailLength = NumberGenerator.GetRandomNumber(16);

            if( txtEmailSuffix.Text == "" ) { txtEmailSuffix.Text = "@gmail.com"; }
            // set options
            if( optionsEmail.GetItemChecked(0) ) { emailUseUpper = true; }
            if( optionsEmail.GetItemChecked(1) ) { emailUseNum = true; }
            if( optionsEmail.GetItemChecked(2) ) { emailUseSpecial = true; }
            // if suffix is empty, set default
            if( txtEmailSuffix.Text == "" ) { txtEmailSuffix.Text = "8"; }
            // generate email
            string email = EmailGenerator.GenerateEmail((byte)emailLength, emailUseUpper, emailUseNum, emailUseSpecial, suffix);
            // display result
            txtEmail.Text = email;
            return email;
        }

        private void btnAddAccount_Click( object sender, EventArgs e ) {
            // show add account tab if logged in
            if( user.IsLoggedIn ) {
                pageViewer.SelectedTab = accountAdd;
            }
            else {
                MessageBox.Show("Please login first!");
            }
        }

        private void btnViewAccount_Click( object sender, EventArgs e ) {
            // show account table if logged in
            if( user.IsLoggedIn ) {
                refreshAccountTable();
                pageViewer.SelectedTab = accountView;
            }
            else {
                MessageBox.Show("Please login first!");
            }
        }

        private void btnAccountCreate_Click( object sender, EventArgs e ) {
            // show account creation tab if logged in
            if( user.IsLoggedIn ) {
                pageViewer.SelectedTab = accountCreation;
            }
            else {
                MessageBox.Show("Please login first!");
            }
        }
        // Refresh account table on tab change
        private void pageViewer_SelectedIndexChanged( object sender, EventArgs e ) {
            if( user.IsLoggedIn ) {
                refreshAccountTable();
            }
            else if( pageViewer.SelectedTab == tabLogin ) {
                // do nothing, allow login
            }
            else {
                // force to login tab
                pageViewer.SelectedTab = tabLogin;
                MessageBox.Show("Please login first!");                
            }
        }

        private void btnAddExistingAccount_Click( object sender, EventArgs e ) {

            // get data from fields
            string email = txtAddEmail.Text + txtAddEmailSuffix.Text;
            string password = txtAddPassword.Text;
            string username = txtAddUsername.Text;
            string company = txtAddCompany.Text;
            // encrypt password
            string cipheredPassword = Encrypt(password, user.privateKey);
            // create account object
            Account account = new Account();
            account.Email = email;
            // Dont forget to save the encrypted password
            account.Password = cipheredPassword;
            account.Username = username;
            account.Company = company;
            // read existing json
            string jsonText = File.ReadAllText(@"..\..\data\accounts.json");
            AccountRoot data = JsonConvert.DeserializeObject<AccountRoot>(jsonText);
            // add new account
            data.Accounts[ company ] = account;
            // serialize back to json
            string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);
            // save to file
            File.WriteAllText(@"..\..\data\accounts.json", updatedJson);
            MessageBox.Show($"Account for {company} Added successfully");
            Thread.Sleep(100);
            // clear fields
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
            // check if first time user
            if( hashedPassword == user.MasterPassword && !( user.IsFirstTimeUser ) ) {
                user.IsLoggedIn = true;
                // Verified the possibility of key derivation from master password with AI
                // salt is stored in config file, use it to derive key
                using( var derivedBytes = new Rfc2898DeriveBytes(hashedPassword, Convert.FromBase64String(user.Salt), 100000) ) {
                    user.privateKey = derivedBytes.GetBytes(32);
                }
                MessageBox.Show("Login Successful!");
                // remove login tab
                pageViewer.TabPages.Remove(tabLogin);
                // switch to account view tab
                pageViewer.SelectedTab = accountView;
                // refresh account table
                refreshAccountTable();

            }
            // first time user setup
            else if( user.IsFirstTimeUser ) {
                // set master password
                user.MasterPassword = hashedPassword;
                MessageBox.Show("Master Password Set! Thanks for using Fortipass!");
                // generate salt
                byte[] salt = new byte[ 16 ];
                // ensure salt is 16 bytes
                while( salt.Length < 16) {
                    using( var rng = new RNGCryptoServiceProvider() ) {
                        rng.GetBytes(salt);
                    }
                }
                // store salt after converting to base64
                user.Salt = Convert.ToBase64String(salt);
                // Verified the possibility of key derivation from master password with AI
                using( var derivedBytes = new Rfc2898DeriveBytes(hashedPassword, salt, 100000) ) {
                    // same as above
                    user.privateKey = derivedBytes.GetBytes(32);

                }
                // update config file
                File.WriteAllLines(@"..\..\config.ini", new string[] { $"MasterPassword= {hashedPassword}", "IsFirstTimeUser= False", $"Salt= {user.Salt}" });
                // set logged in to true
                user.IsLoggedIn = true;
                // remove login tab
                pageViewer.TabPages.Remove(tabLogin);
                // switch to account view tab
                pageViewer.SelectedTab = accountView;
                // refresh account table
                refreshAccountTable();
            }
            else {
                MessageBox.Show("Incorrect Master Password. Please try again.");
                // clear master password field
                txtMasterPassword.Text = string.Empty;
            }
            
        }
    }
}
