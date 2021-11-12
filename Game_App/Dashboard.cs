using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Game_App
{
    public partial class Dashboard : Form
    {
        Game_App_DbEntities db = new Game_App_DbEntities();
        public static bool isConnected = false;
        public static string playerName;
        public static TicTacToeForm ticTacToe;
        public static SudokuForm sudoku;
        int playerid;
        bool openedTicTacToe = false;

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

            var scoresSudoku = db.Sudoku.Where(s => s.PlayerId == playerid).OrderBy(s => s.Score);
            SudokuScoreList.Items.Clear();
            SudokuScoreList.Items.Add("----------Easy----------");
            int counter = 0;
            foreach (var s in scoresSudoku)
            {
                if (s.Difficulty == 1)
                {
                    counter++;
                    SudokuScoreList.Items.Add("#" + counter + " - Score: " + s.Score);
                }
            }
            SudokuScoreList.Items.Add("----------Normal----------");
            counter = 0;
            foreach (var s in scoresSudoku)
            {
                if (s.Difficulty == 2)
                {
                    counter++;
                    SudokuScoreList.Items.Add("#" + counter + " - Score: " + s.Score);
                }
            }
            SudokuScoreList.Items.Add("----------Hard----------");
            counter = 0;
            foreach (var s in scoresSudoku)
            {
                if (s.Difficulty == 3)
                {
                    counter++;
                    SudokuScoreList.Items.Add("#" + counter + " - Score: " + s.Score);
                }
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'game_App_DbDataSet.Player' table. You can move, or remove it, as needed.
            playerTableAdapter.Fill(game_App_DbDataSet.Player);
            Login login = new Login();
            login.ShowDialog();
            playerName = Login.ReturnPlayerName;
            isConnected = Login.ReturnIsConnected;

            PlayerNameLabel.Text = playerName;

            var pID = db.Player.Where(p => p.UserName == playerName);

            foreach (var i in pID)
            {
                playerid = i.PlayerId;
            }

            RefreshScore(true);

            if (Login.ReturnIsConnected == false)
            {
                Close();
            }
        }

        private void tikTakToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ticTacToe == null)
            {
                ticTacToe = new TicTacToeForm();
                IsMdiContainer = true;
                ticTacToe.MdiParent = this;
                ticTacToe.Show();
                ticTacToe.Location = new Point(0, 0);
                ticTacToe.WindowState = FormWindowState.Maximized;
                openedTicTacToe = true;
            }
            else
            {
                ticTacToe.BringToFront();
            }
        }

        private void SudokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sudoku == null)
            {
                sudoku = new SudokuForm();
                IsMdiContainer = true;
                sudoku.MdiParent = this;
                sudoku.Show();
                sudoku.Location = new Point(0, 0);
                sudoku.WindowState = FormWindowState.Maximized;
            }
            else
            {
                sudoku.BringToFront();
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Login.ReturnIsConnected = false;
            login.ShowDialog();
            playerName = Login.ReturnPlayerName;
            isConnected = Login.ReturnIsConnected;

            PlayerNameLabel.Text = playerName;

            var pID = db.Player.Where(p => p.UserName == playerName);

            foreach (var i in pID)
            {
                playerid = i.PlayerId;
            }

            RefreshScore(true);

            if (Login.ReturnIsConnected == false)
            {
                Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            playerBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(game_App_DbDataSet);

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshScore(true);
            if (openedTicTacToe)
            {
                RefreshScore(false);
            }
        }
    }
}
