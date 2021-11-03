﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_App
{
    public partial class Login : Form
    {
        Game_App_DBEntities db = new Game_App_DBEntities();
        public static string ReturnPlayerName { get; set; }
        public static bool ReturnIsConnected { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void GoToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
            if (ReturnIsConnected)
            {
                Close();
            }
        }

        private void Log_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string email = EmailBox.Text;
            string password = PasswordBox.Text;

            if (!(string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrEmpty(PasswordBox.Text)))
            {

                var UserData = db.Player.Where(p => p.UserName == username && p.Email == email && p.Password == password);

                foreach (Player p in UserData)
                {
                    ReturnPlayerName = p.UserName;
                    ReturnIsConnected = true;
                }

                if (ReturnIsConnected)
                {
                    Close();
                }

            }

            UsernameBox.Text = "";
            EmailBox.Text = "";
            PasswordBox.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }
    }
}
