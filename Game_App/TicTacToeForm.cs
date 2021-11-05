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
    public partial class TicTacToeForm : Form
    {
        Game_App_DBEntities1 db = new Game_App_DBEntities1();
        public List<Button> buttonList = new List<Button>();
        Random rnd = new Random();

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            buttonList.Add(TIC1);
            buttonList.Add(TIC2);
            buttonList.Add(TIC3);
            buttonList.Add(TIC4);
            buttonList.Add(TIC5);
            buttonList.Add(TIC6);
            buttonList.Add(TIC7);
            buttonList.Add(TIC8);
            buttonList.Add(TIC9);
        }

        public void Win()
        {
            if ((TIC1.Text == TIC2.Text && TIC1.Text == TIC3.Text && TIC2.Text == TIC3.Text &&
                !(string.IsNullOrEmpty(TIC1.Text) || string.IsNullOrEmpty(TIC2.Text) ||
                string.IsNullOrEmpty(TIC3.Text)) ||
                TIC1.Text == TIC4.Text && TIC1.Text == TIC7.Text && TIC4.Text == TIC7.Text &&
                !(string.IsNullOrEmpty(TIC1.Text) || string.IsNullOrEmpty(TIC4.Text) ||
                string.IsNullOrEmpty(TIC7.Text)) ||
                TIC1.Text == TIC5.Text && TIC1.Text == TIC9.Text && TIC5.Text == TIC9.Text &&
                !(string.IsNullOrEmpty(TIC1.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC9.Text)) ||
                TIC4.Text == TIC5.Text && TIC4.Text == TIC6.Text && TIC5.Text == TIC6.Text &&
                !(string.IsNullOrEmpty(TIC4.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC6.Text)) ||
                TIC7.Text == TIC8.Text && TIC7.Text == TIC9.Text && TIC8.Text == TIC9.Text &&
                !(string.IsNullOrEmpty(TIC7.Text) || string.IsNullOrEmpty(TIC8.Text) ||
                string.IsNullOrEmpty(TIC9.Text)) ||
                TIC7.Text == TIC5.Text && TIC7.Text == TIC3.Text && TIC5.Text == TIC3.Text &&
                !(string.IsNullOrEmpty(TIC3.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC7.Text)) ||
                TIC2.Text == TIC5.Text && TIC2.Text == TIC8.Text && TIC5.Text == TIC8.Text &&
                !(string.IsNullOrEmpty(TIC2.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC8.Text)) ||
                TIC3.Text == TIC6.Text && TIC3.Text == TIC9.Text && TIC6.Text == TIC9.Text &&
                !(string.IsNullOrEmpty(TIC3.Text) || string.IsNullOrEmpty(TIC6.Text) ||
                string.IsNullOrEmpty(TIC9.Text))))
            {
                MessageBox.Show("you win");
                bool exist = false;

                var wins = db.Player.Where(p => p.UserName == Dashboard.playerName);
                TicTacToe ticTacToe = new TicTacToe();

                foreach (var w in wins)
                {
                    ticTacToe.Wins += 1;
                    ticTacToe.PlayerId = w.PlayerId;
                }

                db.TicTacToe.Add(ticTacToe);
                db.SaveChanges();

                RetryGame();
            }
        }

        public void Lose()
        {
            if ((TIC1.Text == TIC2.Text && TIC1.Text == TIC3.Text && TIC2.Text == TIC3.Text &&
                !(string.IsNullOrEmpty(TIC1.Text) || string.IsNullOrEmpty(TIC2.Text) ||
                string.IsNullOrEmpty(TIC3.Text)) ||
                TIC1.Text == TIC4.Text && TIC1.Text == TIC7.Text && TIC4.Text == TIC7.Text &&
                !(string.IsNullOrEmpty(TIC1.Text) || string.IsNullOrEmpty(TIC4.Text) ||
                string.IsNullOrEmpty(TIC7.Text)) ||
                TIC1.Text == TIC5.Text && TIC1.Text == TIC9.Text && TIC5.Text == TIC9.Text &&
                !(string.IsNullOrEmpty(TIC1.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC9.Text)) ||
                TIC4.Text == TIC5.Text && TIC4.Text == TIC6.Text && TIC5.Text == TIC6.Text &&
                !(string.IsNullOrEmpty(TIC4.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC6.Text)) ||
                TIC7.Text == TIC8.Text && TIC7.Text == TIC9.Text && TIC8.Text == TIC9.Text &&
                !(string.IsNullOrEmpty(TIC7.Text) || string.IsNullOrEmpty(TIC8.Text) ||
                string.IsNullOrEmpty(TIC9.Text)) ||
                TIC7.Text == TIC5.Text && TIC7.Text == TIC3.Text && TIC5.Text == TIC3.Text &&
                !(string.IsNullOrEmpty(TIC3.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC7.Text)) ||
                TIC2.Text == TIC5.Text && TIC2.Text == TIC8.Text && TIC5.Text == TIC8.Text &&
                !(string.IsNullOrEmpty(TIC2.Text) || string.IsNullOrEmpty(TIC5.Text) ||
                string.IsNullOrEmpty(TIC8.Text)) ||
                TIC3.Text == TIC6.Text && TIC3.Text == TIC9.Text && TIC6.Text == TIC9.Text &&
                !(string.IsNullOrEmpty(TIC3.Text) || string.IsNullOrEmpty(TIC6.Text) ||
                string.IsNullOrEmpty(TIC9.Text))))
            {
                MessageBox.Show("you lose");
                RetryGame();
            }
        }

        public void RetryGame()
        {
            TIC1.Text = null;
            TIC2.Text = null;
            TIC3.Text = null;
            TIC4.Text = null;
            TIC5.Text = null;
            TIC6.Text = null;
            TIC7.Text = null;
            TIC8.Text = null;
            TIC9.Text = null;

            TIC1.Enabled = true;
            TIC2.Enabled = true;
            TIC3.Enabled = true;
            TIC4.Enabled = true;
            TIC5.Enabled = true;
            TIC6.Enabled = true;
            TIC7.Enabled = true;
            TIC8.Enabled = true;
            TIC9.Enabled = true;

            buttonList.Clear();

            buttonList.Add(TIC1);
            buttonList.Add(TIC2);
            buttonList.Add(TIC3);
            buttonList.Add(TIC4);
            buttonList.Add(TIC5);
            buttonList.Add(TIC6);
            buttonList.Add(TIC6);
            buttonList.Add(TIC7);
            buttonList.Add(TIC8);
            buttonList.Add(TIC9);
        }

        public void Bot()
        {
            int blistIndex = rnd.Next(buttonList.Count);
            Button chosenButton = buttonList[blistIndex];
            if (buttonList.Count > 0)
            {
                chosenButton.Text = "O";
                chosenButton.Enabled = false;
                buttonList.Remove(chosenButton);
            }
            else
            {
                MessageBox.Show("Game Over");
            }
            Lose();
        }

        private void TIC1_Click(object sender, EventArgs e)
        {
            TIC1.Text = "X";
            TIC1.Enabled = false;
            Win();
            buttonList.Remove(TIC1);
            Bot();
        }

        private void TIC2_Click(object sender, EventArgs e)
        {
            TIC2.Text = "X";
            TIC2.Enabled = false;
            Win();
            buttonList.Remove(TIC2);
            Bot();
        }

        private void TIC3_Click(object sender, EventArgs e)
        {
            TIC3.Text = "X";
            TIC3.Enabled = false;
            Win();
            buttonList.Remove(TIC3);
            Bot();
        }

        private void TIC4_Click(object sender, EventArgs e)
        {
            TIC4.Text = "X";
            TIC4.Enabled = false;
            Win();
            buttonList.Remove(TIC4);
            Bot();
        }

        private void TIC5_Click(object sender, EventArgs e)
        {
            TIC5.Text = "X";
            TIC5.Enabled = false;
            Win();
            buttonList.Remove(TIC5);
            Bot();
        }

        private void TIC6_Click(object sender, EventArgs e)
        {
            TIC6.Text = "X";
            TIC6.Enabled = false;
            Win();
            buttonList.Remove(TIC6);
            Bot();
        }

        private void TIC7_Click(object sender, EventArgs e)
        {
            TIC7.Text = "X";
            TIC7.Enabled = false;
            Win();
            buttonList.Remove(TIC7);
            Bot();
        }

        private void TIC8_Click(object sender, EventArgs e)
        {
            TIC8.Text = "X";
            TIC8.Enabled = false;
            Win();
            buttonList.Remove(TIC8);
            Bot();
        }

        private void TIC9_Click(object sender, EventArgs e)
        {
            TIC9.Text = "X";
            TIC9.Enabled = false;
            Win();
            buttonList.Remove(TIC9);
            Bot();
        }

        private void Retry_Click(object sender, EventArgs e)
        {
            RetryGame();
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
