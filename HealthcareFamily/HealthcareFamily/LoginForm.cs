﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthcareFamily
{
    public partial class LoginForm : Form
    {

        private String usrTesting = "";
        private String passTesting = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void cmdSignIn_Click(object sender, EventArgs e)
        {
            String userName;
            String password;

            // doi tuong login
            userName = txtUserName.Text;
            password = txtPassword.Text; 

            if (usrTesting.Equals(userName)
                && password.Equals(password))
            {
                this.Hide();

                var frm = new MainProgramForm();
                frm.Closed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                this.Hide();

                var frm = new LoginFailForm();
                frm.ShowDialog();
                this.Show();
            }

        }

        
    }
}