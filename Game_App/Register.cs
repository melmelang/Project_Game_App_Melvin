using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Game_App
{
    public partial class Register : Form
    {
        Game_App_DbEntities db = new Game_App_DbEntities();

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
                var UserData = db.Player.Where(x => x.UserName == username || x.Email == email);
                foreach (Player p in UserData)
                {
                    if (p.UserName == username)
                    {
                        MessageBox.Show("Username already exist. Take another!!!");
                        doesntExist = false;
                    }
                    if (p.Email == email)
                    {
                        MessageBox.Show("Email already exist. Take another!!!");
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
