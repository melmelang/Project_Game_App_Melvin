using System;
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
    public partial class Register : Form
    {
        Game_App_DBEntities1 db = new Game_App_DBEntities1();

        public Register()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string email = EmailBox.Text;
            string password = PasswordBox.Text;
            bool doesntExist = true;


            if (!(string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrEmpty(PasswordBox.Text)))
            {
                var UserData = db.Player;
                foreach (Player p in UserData)
                {
                    if (p.UserName == username)
                    {
                        MessageBox.Show("Username already exist. Take another");
                        doesntExist = false;
                    }
                    if (p.Email == email)
                    {
                        MessageBox.Show("Email already exist. Take another");
                        doesntExist = false;
                    }
                }

                if (doesntExist)
                {
                    var player = new Player();

                    player.UserName = username;
                    player.Email = email;
                    player.Password = password;

                    Login.ReturnPlayerName = username;
                    Login.ReturnIsConnected = true;

                    db.Player.Add(player);
                    db.SaveChanges();

                    MessageBox.Show("doesntExist");
                }

            }

            if (Login.ReturnIsConnected)
            {
                Close();
            }

            UsernameBox.Text = "";
            EmailBox.Text = "";
            PasswordBox.Text = "";
        }
    }
}
