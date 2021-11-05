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
    public partial class SudokuForm : Form
    {
        List<int> numbers = new List<int>();
        List<TextBox> text = new List<TextBox>();
        public SudokuForm()
        {
            InitializeComponent();
        }

        private void SudokuForm_Load(object sender, EventArgs e)
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

        private void Sudoku_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
