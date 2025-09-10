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

namespace FortiPass
{
    public partial class FortiPass : Form
    {
        public FortiPass()
        {
            InitializeComponent();
            optionsPassword.CheckOnClick = true;
            optionsUserName.CheckOnClick = true;
            optionsEmail.CheckOnClick = true;
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

        private void btnGeneratePassword_Click( object sender, EventArgs e ) {
            bool useUpper = false;
            bool useNum = false;
            bool useSpecial = false;
            if( txtPassword.Text == "" ) { txtPasswordLength.Text = "8";  }
            uint length = Convert.ToUInt16(txtPasswordLength.Text);
            if( optionsPassword.GetItemChecked(0) ) { useUpper = true; }
            if( optionsPassword.GetItemChecked(1) ) { useNum = true; }
            if( optionsPassword.GetItemChecked(2) ) { useSpecial = true; }
            byte n = 0;
            while( length < 8 || length > 255 ) {

                if( n > 200 ) { length = 16; break; }
                length = (byte)( length % 16 );
                n++;
            }
            txtPassword.Text = PasswordGenerator.GeneratePassword((byte)length, useUpper, useNum, useSpecial);
        }

        private void btnGenerateUserName_Click( object sender, EventArgs e ) {
            bool useUpper = false;
            bool useNum = false;
            bool useSpecial = false;
            if( txtUserNameLength.Text == "" ) { txtUserNameLength.Text = "8"; }
            uint length = Convert.ToUInt16(txtUserNameLength.Text);
            byte n = 0;
            while( length < 8 || length > 255 ) {

                if( n > 200 ) { length = 16; break; }
                length = (byte)( length % 16 );
                n++;
            }
            if( optionsUserName.GetItemChecked(0) ) { useUpper = true; }
            if( optionsUserName.GetItemChecked(1) ) { useNum = true; }
            if( optionsUserName.GetItemChecked(2) ) { useSpecial = true; }
            txtUserName.Text = UsernameGenerator.GenerateUserName((byte)length, useUpper, useNum, useSpecial);
        }

        private void btnGenerateEmail_Click( object sender, EventArgs e ) {
            bool useUpper = false;
            bool useNum = false;
            bool useSpecial = false;
            string suffix = txtEmailSuffix.Text;
            byte length = NumberGenerator.GetRandomNumber(16);
            if ( txtEmailSuffix.Text == "") { txtEmailSuffix.Text = "@gmail.com"; }
            if( optionsEmail.GetItemChecked(0) ) { useUpper = true; }
            if( optionsEmail.GetItemChecked(1) ) { useNum = true; }
            if ( optionsEmail.GetItemChecked(2) ) { useSpecial = true; }
            byte n = 0;
            while( length < 8 || length > 255 ) {

                if( n > 200 ) { length = 16; break; }
                length = (byte)( length % 16 );
                n++;
            }
            txtEmail.Text = EmailGenerator.GenerateEmail(length, useUpper, useNum, useSpecial, suffix);
        }
    }
}
