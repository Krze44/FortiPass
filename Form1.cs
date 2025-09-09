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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            optionsPassword.CheckOnClick = true;
            optionsUserName.CheckOnClick = true;
        }

        private void Form1_load(object sender,  EventArgs e)
        {
            txtPassword.Enabled = false;
            txtUserName.Enabled = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeneratePassword_Click( object sender, EventArgs e ) {
            bool useUpper = false;
            bool useNum = false;
            bool useSpecial = false;
            uint length = Convert.ToUInt16(txtPasswordLength.Text);
            if( optionsPassword.GetItemChecked(0) ) { useUpper = true; }
            if( optionsPassword.GetItemChecked(1) ) { useNum = true; }
            if( optionsPassword.GetItemChecked(2) ) { useSpecial = true; }
            txtPassword.Text = PasswordGenerator.GeneratePassword((byte)length, useUpper, useNum, useSpecial);
        }

        private void btnGenerateUserName_Click( object sender, EventArgs e ) {
            bool useUpper = false;
            bool useNum = false;
            bool useSpecial = false;
            uint length = Convert.ToUInt16(txtUserNameLength.Text);
            while( length < 0 || length > 255 ) { length = 16; }
            if( optionsUserName.GetItemChecked(0) ) { useUpper = true; }
            if( optionsUserName.GetItemChecked(1) ) { useNum = true; }
            if( optionsUserName.GetItemChecked(2) ) { useSpecial = true; }
            txtUserName.Text = UsernameGenerator.GenerateUserName((byte)length, useUpper, useNum, useSpecial);
        }
    }
}
