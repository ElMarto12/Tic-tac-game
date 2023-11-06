using System;
using System.Windows.Forms;
using Tic_tac_game.logic;

namespace Tic_tac_game
{
    public partial class fiveBoard : Form
    {
        Player _player1 = new Player();
        Player _player2 = new Player();
        
        Gameplay gmp = new Gameplay();

        private Button[] buttons = new Button[25];
        
        public string identify_player1
        {
            set  { _player1.Character = value; }
        }

        public string identify_player2
        {
            set { _player2.Character = value; }
        }
        public fiveBoard()
        {
            InitializeComponent();
            _player1.PlayerStatus = true;

            buttons[0] = but0;
            buttons[1] = but1;
            buttons[2] = but2;
            buttons[3] = but3;
            buttons[4] = but4;
            buttons[5] = but5;
            buttons[6] = but6;
            buttons[7] = but7;
            buttons[8] = but8;
            buttons[9] = but9;
            buttons[10] = but10;
            buttons[11] = but11;
            buttons[12] = but12;
            buttons[13] = but13;
            buttons[14] = but14;
            buttons[15] = but15;
            buttons[16] = but16;
            buttons[17] = but17;
            buttons[18] = but18;
            buttons[19] = but19;
            buttons[20] = but20;
            buttons[21] = but21;
            buttons[22] = but22;
            buttons[23] = but23;
            buttons[24] = but24;

        }
        
        private void fiveBoard_Load(object sender, EventArgs e)
        {
            player1_label.Text = "Player 1: " + _player1.Character;
            player2_label.Text = "Player 2: " + _player2.Character;
        }

        private void checkWinner()
        {
            //if O wins in rows
            if (but0.Text == "O" && but1.Text == "O" && but2.Text == "O" ||
                but4.Text == "O" && but3.Text == "O" && but2.Text == "O" ||
                but1.Text == "O" && but2.Text == "O" && but3.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but5.Text == "O" && but6.Text == "O" && but7.Text == "O" ||
                but9.Text == "O" && but8.Text == "O" && but7.Text == "O" ||
                but6.Text == "O" && but7.Text == "O" && but8.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but10.Text == "O" && but11.Text == "O" && but12.Text == "O" ||
                but14.Text == "O" && but13.Text == "O" && but12.Text == "O" ||
                but11.Text == "O" && but12.Text == "O" && but13.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but15.Text == "O" && but16.Text == "O" && but17.Text == "O" ||
                but19.Text == "O" && but18.Text == "O" && but17.Text == "O" ||
                but16.Text == "O" && but17.Text == "O" && but18.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but20.Text == "O" && but21.Text == "O" && but22.Text == "O" ||
                but24.Text == "O" && but23.Text == "O" && but22.Text == "O" ||
                but21.Text == "O" && but22.Text == "O" && but23.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            
            //if O wins in collums
            if (but0.Text == "O" && but5.Text == "O" && but10.Text == "O" ||
                but20.Text == "O" && but15.Text == "O" && but10.Text == "O" ||
                but5.Text == "O" && but10.Text == "O" && but15.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but1.Text == "O" && but6.Text == "O" && but11.Text == "O" ||
                but21.Text == "O" && but16.Text == "O" && but11.Text == "O" ||
                but6.Text == "O" && but11.Text == "O" && but16.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but2.Text == "O" && but7.Text == "O" && but12.Text == "O" ||
                but22.Text == "O" && but17.Text == "O" && but12.Text == "O" ||
                but7.Text == "O" && but12.Text == "O" && but17.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but3.Text == "O" && but8.Text == "O" && but13.Text == "O" ||
                but23.Text == "O" && but18.Text == "O" && but13.Text == "O" ||
                but8.Text == "O" && but13.Text == "O" && but18.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but4.Text == "O" && but9.Text == "O" && but14.Text == "O" ||
                but24.Text == "O" && but19.Text == "O" && but14.Text == "O" ||
                but9.Text == "O" && but14.Text == "O" && but19.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            //if O wins in directional /
            
            //this is on / and \ side
            if (but2.Text == "O" && but6.Text == "O" && but10.Text == "O" ||
                but14.Text == "O" && but18.Text == "O" && but22.Text == "O"||
                but2.Text == "O" && but8.Text == "O" && but14.Text == "O"||
                but10.Text == "O" && but16.Text == "O" && but22.Text == "O")
            {
                MessageBox.Show("Player O won");
            }

            if (but3.Text == "O" && but7.Text == "O" && but11.Text == "O" ||
                but15.Text == "O" && but11.Text == "O" && but7.Text == "O" )
            {
                MessageBox.Show("Player O won");
            }
            
            if (but9.Text == "O" && but13.Text == "O" && but17.Text == "O" ||
                but21.Text == "O" && but17.Text == "O" && but13.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            if (but4.Text == "O" && but8.Text == "O" && but12.Text == "O" ||
                but20.Text == "O" && but16.Text == "O" && but12.Text == "O" ||
                but16.Text == "O" && but12.Text == "O" && but8.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            // \ side
            if (but1.Text == "O" && but7.Text == "O" && but13.Text == "O" ||
                but19.Text == "O" && but13.Text == "O" && but7.Text == "O" )
            {
                MessageBox.Show("Player O won");
            }
            
            if (but5.Text == "O" && but11.Text == "O" && but17.Text == "O" ||
                but23.Text == "O" && but17.Text == "O" && but11.Text == "O" )
            {
                MessageBox.Show("Player O won");
            }
            
            if (but0.Text == "O" && but6.Text == "O" && but12.Text == "O" ||
                but24.Text == "O" && but18.Text == "O" && but12.Text == "O" ||
                but18.Text == "O" && but12.Text == "O" && but6.Text == "O")
            {
                MessageBox.Show("Player O won");
            }
            
            //--------------------------------- X Player -----------------------------------
            
            //if O wins in rows
            if (but0.Text == "X" && but1.Text == "X" && but2.Text == "X" ||
                but4.Text == "X" && but3.Text == "X" && but2.Text == "X" ||
                but1.Text == "X" && but2.Text == "X" && but3.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but5.Text == "X" && but6.Text == "X" && but7.Text == "X" ||
                but9.Text == "X" && but8.Text == "X" && but7.Text == "X" ||
                but6.Text == "X" && but7.Text == "X" && but8.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but10.Text == "X" && but11.Text == "X" && but12.Text == "X" ||
                but14.Text == "X" && but13.Text == "X" && but12.Text == "X" ||
                but11.Text == "X" && but12.Text == "X" && but13.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but15.Text == "X" && but16.Text == "X" && but17.Text == "X" ||
                but19.Text == "X" && but18.Text == "X" && but17.Text == "X" ||
                but16.Text == "X" && but17.Text == "X" && but18.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but20.Text == "X" && but21.Text == "X" && but22.Text == "X" ||
                but24.Text == "X" && but23.Text == "X" && but22.Text == "X" ||
                but21.Text == "X" && but22.Text == "X" && but23.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            
            //if O wins in collums
            if (but0.Text == "X" && but5.Text == "X" && but10.Text == "X" ||
                but20.Text == "X" && but15.Text == "X" && but10.Text == "X" ||
                but5.Text == "X" && but10.Text == "X" && but15.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but1.Text == "X" && but6.Text == "X" && but11.Text == "X" ||
                but21.Text == "X" && but16.Text == "X" && but11.Text == "X" ||
                but6.Text == "X" && but11.Text == "X" && but16.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but2.Text == "X" && but7.Text == "X" && but12.Text == "X" ||
                but22.Text == "X" && but17.Text == "X" && but12.Text == "X" ||
                but7.Text == "X" && but12.Text == "X" && but17.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but3.Text == "X" && but8.Text == "X" && but13.Text == "X" ||
                but23.Text == "X" && but18.Text == "X" && but13.Text == "X" ||
                but8.Text == "X" && but13.Text == "X" && but18.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but4.Text == "X" && but9.Text == "X" && but14.Text == "X" ||
                but24.Text == "X" && but19.Text == "X" && but14.Text == "X" ||
                but9.Text == "X" && but14.Text == "X" && but19.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            //if O wins in directional /
            
            //this is on / and \ side
            if (but2.Text == "X" && but6.Text == "X" && but10.Text == "X" ||
                but14.Text == "X" && but18.Text == "X" && but22.Text == "X"||
                but2.Text == "X" && but8.Text == "X" && but14.Text == "X"||
                but10.Text == "X" && but16.Text == "X" && but22.Text == "X")
            {
                MessageBox.Show("Player X won");
            }

            if (but3.Text == "X" && but7.Text == "X" && but11.Text == "X" ||
                but15.Text == "X" && but11.Text == "X" && but7.Text == "X" )
            {
                MessageBox.Show("Player X won");
            }
            
            if (but9.Text == "X" && but13.Text == "X" && but17.Text == "X" ||
                but21.Text == "X" && but17.Text == "X" && but13.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            if (but4.Text == "X" && but8.Text == "X" && but12.Text == "X" ||
                but20.Text == "X" && but16.Text == "X" && but12.Text == "X" ||
                but16.Text == "X" && but12.Text == "X" && but8.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
            
            // \ side
            if (but1.Text == "X" && but7.Text == "X" && but13.Text == "X" ||
                but19.Text == "X" && but13.Text == "X" && but7.Text == "X" )
            {
                MessageBox.Show("Player X won");
            }
            
            if (but5.Text == "X" && but11.Text == "X" && but17.Text == "X" ||
                but23.Text == "X" && but17.Text == "X" && but11.Text == "X" )
            {
                MessageBox.Show("Player X won");
            }
            
            if (but0.Text == "X" && but6.Text == "X" && but12.Text == "X" ||
                but24.Text == "X" && but18.Text == "X" && but12.Text == "X" ||
                but18.Text == "X" && but12.Text == "X" && but6.Text == "X")
            {
                MessageBox.Show("Player X won");
            }
        }
        private void but0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but0.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but0.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but0.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but1.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but1.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but1.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but2.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but2.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but2.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but3.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but3.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but3.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but4.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but4.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but4.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but5.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but5.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but5.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but6.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but6.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but6.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but7.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but7.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but7.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but8.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but8.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but8.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but9.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but9.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but9.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but10.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but10.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but10.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but11.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but11.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but11.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but12.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but12.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but12.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but13_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but13.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but13.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but13.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but14.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but14.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but14.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but15_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but15.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but15.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but15.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but16.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but16.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but16.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but17.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but17.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but17.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but18_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but18.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but18.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but18.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but19.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but19.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but19.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but20.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but20.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but20.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but21.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but21.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but21.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but22.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but22.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but22.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but23_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but23.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but23.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but23.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }

        private void but24_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(but24.Text))
            {
                if (_player1.PlayerStatus)
                {
                    but24.Text = _player1.Character;
                    gmp.switchPlayer(_player1, _player2);   
                }
                else if (_player2.PlayerStatus)
                {
                    but24.Text = _player2.Character;
                    gmp.switchPlayer(_player1, _player2);
                }
            }
            else
            {
                MessageBox.Show("Tile is ocupied");
            }
            
            checkWinner();
            if (gmp.IsDraw(buttons))
            {
                this.Close();
            }
        }
    }
}