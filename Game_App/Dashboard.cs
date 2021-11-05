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
    public partial class Dashboard : Form
    {
        public static bool isConnected = false;
        public static string playerName;
        public static string playerId { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_App_DbDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.game_App_DbDataSet.Player);
            Login login = new Login();
            login.ShowDialog();
            playerName = Login.ReturnPlayerName;
            isConnected = Login.ReturnIsConnected;

            PlayerNameLabel.Text = playerName;
            if (Login.ReturnIsConnected == false)
                Close();
        }

        private void tikTakToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacToeForm ticTacToe = new TicTacToeForm();
            ticTacToe.ShowDialog();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Login.ReturnIsConnected = false;
            login.ShowDialog();
            playerName = Login.ReturnPlayerName;
            isConnected = Login.ReturnIsConnected;

            PlayerNameLabel.Text = playerName;
            if (Login.ReturnIsConnected == false)
                Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.game_App_DbDataSet);

        }
    }
}
