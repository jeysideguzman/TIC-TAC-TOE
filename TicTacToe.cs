using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        string[] GAME = new string[9];
        int playerturn = 0;

        public string returnsym(int turn)
        {
            if (turn % 2 == 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[0] = returnsym(playerturn);
            btn1.Text = GAME[0];
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[1] = returnsym(playerturn);
            btn2.Text = GAME[1];
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[2] = returnsym(playerturn);
            btn3.Text = GAME[2];
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[3] = returnsym(playerturn);
            btn4.Text = GAME[3];
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[4] = returnsym(playerturn);
            btn5.Text = GAME[4];
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[5] = returnsym(playerturn);
            btn6.Text = GAME[5];
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[6] = returnsym(playerturn);
            btn7.Text = GAME[6];
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[7] = returnsym(playerturn);
            btn8.Text = GAME[7];
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[8] = returnsym(playerturn);
            btn9.Text = GAME[8];
        }
    }
}
