using System;
using System.Windows.Forms;
using Tic_tac_game.logic;

namespace Tic_tac_game
{
    public partial class threeBoard : Form
    {
        
        Player _player1 = new Player();
        Player _player2 = new Player();

        Gameplay gmp = new Gameplay();
        
        public string identify_player1
        {
            set  { _player1.Character = value; }
        }

        public string identify_player2
        {
            set { _player2.Character = value; }
        }

        public threeBoard()
        {
            InitializeComponent();
            _player1.PlayerStatus = true;
        }
        
        private void threeBoard_Load(object sender, EventArgs e)
        {
            player1_label.Text = "Player 1: " + _player1.Character;
            player2_label.Text = "Player 2: " + _player2.Character;
        }

        private void play_btn0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn0.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn0.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn0.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }

        private void play_btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn1.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn1.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn1.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }

        private void play_btn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn2.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn2.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn2.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }

        private void play_btn3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn3.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn3.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn3.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }

        private void play_btn4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn4.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn4.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn4.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }


        private void play_btn5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn5.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn5.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn5.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }

        private void play_btn6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn6.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn6.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn6.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }


        private void play_btn7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn7.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn7.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn7.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }

        private void play_btn8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(play_btn8.Text))
            {
                if (_player1.PlayerStatus)
                {
                    play_btn8.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    play_btn8.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
        }

        private void checkWinner()
        {
            
            //if O player wins in Rows
            
            if (play_btn0.Text == "O" && play_btn1.Text == "O" && play_btn2.Text == "O")
            {
                MessageBox.Show("Player O Won");
            }

            if (play_btn3.Text == "O" && play_btn4.Text == "O" && play_btn5.Text == "O")
            {
                MessageBox.Show("Player O Won");
            }

            if (play_btn6.Text == "O" && play_btn7.Text == "O" && play_btn8.Text == "O")
            {
                MessageBox.Show("Player O Won");
            }
            
            //if O player wins in Columns
            
            if (play_btn0.Text == "O" && play_btn3.Text == "O" && play_btn6.Text == "O")
            {
                MessageBox.Show("Player O Won");
            }

            if (play_btn1.Text == "O" && play_btn4.Text == "O" && play_btn7.Text == "O")
            {
                MessageBox.Show("Player O Won");
            }

            if (play_btn2.Text == "O" && play_btn5.Text == "O" && play_btn8.Text == "O")
            {
                MessageBox.Show("Player O Won");
            }
            
            
            //if X player wins in Rows
            
            if (play_btn0.Text == "X" && play_btn1.Text == "X" && play_btn2.Text == "X")
            {
                MessageBox.Show("Player X Won");
            }

            if (play_btn3.Text == "X" && play_btn4.Text == "X" && play_btn5.Text == "X")
            {
                MessageBox.Show("Player X Won");
            }

            if (play_btn6.Text == "X" && play_btn7.Text == "X" && play_btn8.Text == "X")
            {
                MessageBox.Show("Player X Won");
            }
            
            
            //if X player wins in Collumns
            
            if (play_btn0.Text == "X" && play_btn3.Text == "X" && play_btn6.Text == "X")
            {
                MessageBox.Show("Player X Won");
            }

            if (play_btn1.Text == "X" && play_btn4.Text == "X" && play_btn7.Text == "X")
            {
                MessageBox.Show("Player X Won");
            }

            if (play_btn2.Text == "X" && play_btn5.Text == "X" && play_btn8.Text == "X")
            {
                MessageBox.Show("Player X Won");
            }
        }
    }
}