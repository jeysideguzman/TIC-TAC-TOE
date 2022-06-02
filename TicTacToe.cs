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
        int playerOXwins;

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
            checker();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[1] = returnsym(playerturn);
            btn2.Text = GAME[1];
            checker();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[2] = returnsym(playerturn);
            btn3.Text = GAME[2];
            checker();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[3] = returnsym(playerturn);
            btn4.Text = GAME[3];
            checker();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[4] = returnsym(playerturn);
            btn5.Text = GAME[4];
            checker();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[5] = returnsym(playerturn);
            btn6.Text = GAME[5];
            checker();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[6] = returnsym(playerturn);
            btn7.Text = GAME[6];
            checker();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[7] = returnsym(playerturn);
            btn8.Text = GAME[7];
            checker();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            playerturn++;
            GAME[8] = returnsym(playerturn);
            btn9.Text = GAME[8];
            checker();
        }

        public void checker()
        {
            checker(playerOXwins);
        }

        public void checker(int playerOXwins)
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                btn1.BackColor = Color.Red;
                btn2.BackColor = Color.Red;
                btn3.BackColor = Color.Red;               
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                btn4.BackColor = Color.Red;
                btn5.BackColor = Color.Red;
                btn6.BackColor = Color.Red;               
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                btn7.BackColor = Color.Red;
                btn8.BackColor = Color.Red;
                btn9.BackColor = Color.Red;                
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                btn1.BackColor = Color.Red;
                btn4.BackColor = Color.Red;
                btn7.BackColor = Color.Red;              
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                btn2.BackColor = Color.Red;
                btn5.BackColor = Color.Red;
                btn8.BackColor = Color.Red;                
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                btn3.BackColor = Color.Red;
                btn6.BackColor = Color.Red;
                btn9.BackColor = Color.Red;                
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                btn1.BackColor = Color.Red;
                btn5.BackColor = Color.Red;
                btn9.BackColor = Color.Red;               
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                btn3.BackColor = Color.Red;
                btn5.BackColor = Color.Red;
                btn7.BackColor = Color.Red;                
                PXscore.Text += "*";
                MessageBox.Show("Player X Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                btn1.BackColor = Color.Blue;
                btn2.BackColor = Color.Blue;
                btn3.BackColor = Color.Blue;               
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                btn4.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn6.BackColor = Color.Blue;               
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                btn7.BackColor = Color.Blue;
                btn8.BackColor = Color.Blue;
                btn9.BackColor = Color.Blue;             
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                btn1.BackColor = Color.Blue;
                btn4.BackColor = Color.Blue;
                btn7.BackColor = Color.Blue;
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                btn2.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn8.BackColor = Color.Blue;
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                btn3.BackColor = Color.Blue;
                btn6.BackColor = Color.Blue;
                btn9.BackColor = Color.Blue;
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                btn1.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn9.BackColor = Color.Blue;
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();
            }
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                btn3.BackColor = Color.Blue;
                btn5.BackColor = Color.Blue;
                btn7.BackColor = Color.Blue;
                POscore.Text += "*";
                MessageBox.Show("Player O Wins!", "Tic Tac Toe");
                reset();  
            }
            drawchecker();
        }

        private void reset()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
            GAME = new string[9];
            playerturn = 0;   
        }

        public void drawchecker()
        {
          if (playerturn == 9)
            {
                reset();
                MessageBox.Show("It's a Draw, Goodjob!", "Tic Tac Toe");
            }
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            reset();
            POscore.Text = "";
            PXscore.Text = "";  
        }
    }
}