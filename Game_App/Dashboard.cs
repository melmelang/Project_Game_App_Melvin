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
        Game_App_DBEntities1 db = new Game_App_DBEntities1();
        public static bool isConnected = false;
        public static string playerName;
        public static int playerId { get; set; }
        int playerid;

        public Dashboard()
        {
            InitializeComponent();
        }

        public void RefreshScore(bool load)
        {
            if (load)
            {
                var scores = db.TicTacToe.Where(t => t.PlayerId == playerid);

                foreach (var s in scores)
                {
                    Wins.Text = "Wins: " + s.Wins;
                    Loses.Text = "Loses: " + s.Loses;
                }
            }
            else
            {
                Wins.Text = "Wins: " + TicTacToeForm.ReturnPlayerWins;
                Loses.Text = "Loses: " + TicTacToeForm.ReturnPlayerLoses;
            }
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

            var pID = db.Player.Where(p => p.UserName == Dashboard.playerName);

            foreach (var i in pID)
            {
                playerid = i.PlayerId;
            }

            RefreshScore(true);

            if (Login.ReturnIsConnected == false)
                Close();
        }

        private void tikTakToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacToeForm ticTacToe = new TicTacToeForm();
            ticTacToe.ShowDialog();
            RefreshScore(false);
        }

        private void SudokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudokuForm sudoku = new SudokuForm();
            sudoku.ShowDialog();
            RefreshScore(false);
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Login.ReturnIsConnected = false;
            login.ShowDialog();
            playerName = Login.ReturnPlayerName;
            isConnected = Login.ReturnIsConnected;

            PlayerNameLabel.Text = playerName;

            var playerID = db.Player;

            foreach (var pi in playerID)
            {
                playerId = pi.PlayerId;
            }

            RefreshScore(false);

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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshScore(false);
        }
    }
}
