using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Game_App
{
    public partial class SudokuForm : Form
    {
        Game_App_DbEntities db = new Game_App_DbEntities();
        public delegate DateTime Score(DateTime time);

        public event Score T;

        public DateTime resultTime;

        List<int> numbers = new List<int>();
        List<TextBox> text = new List<TextBox>();
        Random rnd = new Random();
        int playerid;
        int ExtraScore;
        public static int ReturnPlayerScore { get; set; }

        public SudokuForm()
        {
            InitializeComponent();
            T += new Score(CreateScoreEvent);
        }

        public DateTime CreateScoreEvent(DateTime GetTime)
        {
            return GetTime;
        }

        private bool IsEveritingADigit(String t)
        {
            foreach (char c in t)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }

        public void SetUpLists()
        {
            //x1 num
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(1);
            numbers.Add(2);
            //x2 num
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(9);
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(8);
            //x3 num
            numbers.Add(1);
            numbers.Add(9);
            numbers.Add(8);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(2);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            //x4 num
            numbers.Add(8);
            numbers.Add(5);
            numbers.Add(9);
            numbers.Add(7);
            numbers.Add(6);
            numbers.Add(1);
            numbers.Add(4);
            numbers.Add(2);
            numbers.Add(3);
            //x5 num
            numbers.Add(4);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(1);
            //x6 num
            numbers.Add(7);
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(9);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(8);
            numbers.Add(5);
            numbers.Add(6);
            //x7 num
            numbers.Add(9);
            numbers.Add(6);
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(8);
            numbers.Add(4);
            //x8 num
            numbers.Add(2);
            numbers.Add(8);
            numbers.Add(7);
            numbers.Add(4);
            numbers.Add(1);
            numbers.Add(9);
            numbers.Add(6);
            numbers.Add(3);
            numbers.Add(5);
            //x9 num
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(8);
            numbers.Add(6);
            numbers.Add(1);
            numbers.Add(7);
            numbers.Add(9);
            //x1 text
            text.Add(X1Y1);
            text.Add(X1Y2);
            text.Add(X1Y3);
            text.Add(X1Y4);
            text.Add(X1Y5);
            text.Add(X1Y6);
            text.Add(X1Y7);
            text.Add(X1Y8);
            text.Add(X1Y9);
            //x2 text
            text.Add(X2Y1);
            text.Add(X2Y2);
            text.Add(X2Y3);
            text.Add(X2Y4);
            text.Add(X2Y5);
            text.Add(X2Y6);
            text.Add(X2Y7);
            text.Add(X2Y8);
            text.Add(X2Y9);
            //x3 text
            text.Add(X3Y1);
            text.Add(X3Y2);
            text.Add(X3Y3);
            text.Add(X3Y4);
            text.Add(X3Y5);
            text.Add(X3Y6);
            text.Add(X3Y7);
            text.Add(X3Y8);
            text.Add(X3Y9);
            //x4 text
            text.Add(X4Y1);
            text.Add(X4Y2);
            text.Add(X4Y3);
            text.Add(X4Y4);
            text.Add(X4Y5);
            text.Add(X4Y6);
            text.Add(X4Y7);
            text.Add(X4Y8);
            text.Add(X4Y9);
            //x5 text
            text.Add(X5Y1);
            text.Add(X5Y2);
            text.Add(X5Y3);
            text.Add(X5Y4);
            text.Add(X5Y5);
            text.Add(X5Y6);
            text.Add(X5Y7);
            text.Add(X5Y8);
            text.Add(X5Y9);
            //x6 text
            text.Add(X6Y1);
            text.Add(X6Y2);
            text.Add(X6Y3);
            text.Add(X6Y4);
            text.Add(X6Y5);
            text.Add(X6Y6);
            text.Add(X6Y7);
            text.Add(X6Y8);
            text.Add(X6Y9);
            //x7 text
            text.Add(X7Y1);
            text.Add(X7Y2);
            text.Add(X7Y3);
            text.Add(X7Y4);
            text.Add(X7Y5);
            text.Add(X7Y6);
            text.Add(X7Y7);
            text.Add(X7Y8);
            text.Add(X7Y9);
            //x8 text
            text.Add(X8Y1);
            text.Add(X8Y2);
            text.Add(X8Y3);
            text.Add(X8Y4);
            text.Add(X8Y5);
            text.Add(X8Y6);
            text.Add(X8Y7);
            text.Add(X8Y8);
            text.Add(X8Y9);
            //x9 text
            text.Add(X9Y1);
            text.Add(X9Y2);
            text.Add(X9Y3);
            text.Add(X9Y4);
            text.Add(X9Y5);
            text.Add(X9Y6);
            text.Add(X9Y7);
            text.Add(X9Y8);
            text.Add(X9Y9);
        }

        public void ShowNumbers(string difficulty)
        {
            foreach (var t in text)
            {
                t.Enabled = true;
                t.Text = null;
                t.BackColor = Color.White;
            }

            if (difficulty == "Easy")
            {
                for (int i = 0; i < 40; i++)
                {
                    int listIndex = 0;
                    while (text[listIndex].Text != "")
                    {
                        listIndex = rnd.Next(numbers.Count);
                    }
                    text[listIndex].Text = numbers[listIndex].ToString();
                    text[listIndex].Enabled = false;
                }
            }
            else if (difficulty == "Normal")
            {
                for (int i = 0; i < 35; i++)
                {
                    int listIndex = 0;
                    while (text[listIndex].Text != "")
                    {
                        listIndex = rnd.Next(numbers.Count);
                    }
                    text[listIndex].Text = numbers[listIndex].ToString();
                    text[listIndex].Enabled = false;
                }
            }
            else
            {
                for (int i = 0; i < 30; i++)
                {
                    int listIndex = 0;
                    while (text[listIndex].Text != "")
                    {
                        listIndex = rnd.Next(numbers.Count);
                    }
                    text[listIndex].Text = numbers[listIndex].ToString();
                    text[listIndex].Enabled = false;
                }
            }
        }

        public void Win()
        {
            bool win = true;
            foreach (TextBox t in text)
            {
                if (t.Enabled == true)
                {
                    win = false;
                }
            }
            if (win)
            {
                TimeSpan now = DateTime.Now - resultTime;
                ReturnPlayerScore = (int)now.TotalMilliseconds + ExtraScore;

                Sudoku sudoku = new Sudoku();
                sudoku.PlayerId = playerid;
                sudoku.Score = ReturnPlayerScore;
                if (Difficulty.Text == "Easy")
                {
                    sudoku.Difficulty = 1;
                }
                else if (Difficulty.Text == "Normal")
                {
                    sudoku.Difficulty = 2;
                }
                else
                {
                    sudoku.Difficulty = 3;
                }

                db.Sudoku.Add(sudoku);
                db.SaveChanges();
                RefreshScore();
                Hint.Enabled = false;

                MessageBox.Show("You win - " + ReturnPlayerScore);
            }
        }

        public void RefreshScore()
        {
            var scoresSudoku = db.Sudoku.Where(s => s.PlayerId == playerid).OrderByDescending(s => s.Score);
            foreach (var s in scoresSudoku)
            {
                if (s.Difficulty == 1)
                {
                    EasyLabel.Text = s.Score.ToString();
                }
                else if (s.Difficulty == 2)
                {
                    NormalLabel.Text = s.Score.ToString();
                }
                else
                {
                    HardLabel.Text = s.Score.ToString();
                }
            }
        }

        private void SudokuForm_Load(object sender, EventArgs e)
        {
            SetUpLists();
            var pID = db.Player.Where(p => p.UserName == Dashboard.playerName);

            foreach (var i in pID)
            {
                playerid = i.PlayerId;
            }

            Difficulty.Text = "Easy";
            RefreshScore();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Difficulty.Text))
            {
                MessageBox.Show("Chose a difficulty");
            }
            else
            {
                ShowNumbers(Difficulty.Text);
                SudokuForm Score1 = new SudokuForm();
                DateTime now = DateTime.Now;
                resultTime = Score1.T(now);
                Hint.Enabled = true;
            }
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            Dashboard.sudoku = null;
            Close();
        }

        private void PressKey(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int indexOfNumber = text.IndexOf(textBox);
            int realNumber = numbers[indexOfNumber];

            string numberSting = textBox.Text;

            if (IsEveritingADigit(numberSting) && !string.IsNullOrEmpty(numberSting))
            {
                int numberInt = int.Parse(numberSting);

                if (realNumber == numberInt)
                {
                    textBox.BackColor = Color.Yellow;
                    textBox.ForeColor = Color.Black;
                    textBox.Enabled = false;
                    Win();
                }
                else
                {
                    ExtraScore += 100;
                    textBox.BackColor = Color.Red;
                    textBox.Text = "";
                }
            }
            else
            {
                textBox.Text = "";
            }
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                int listIndex = 0;
                while (text[listIndex].Text != "")
                {
                    listIndex = rnd.Next(numbers.Count);
                }
                text[listIndex].Text = numbers[listIndex].ToString();
                text[listIndex].BackColor = Color.Black;
                text[listIndex].ForeColor = Color.White;
                text[listIndex].Enabled = false;
            }
            ExtraScore += 5000;
            Win();
        }
    }
}
