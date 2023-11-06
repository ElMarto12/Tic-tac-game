using System;
using System.Windows.Forms;
using Tic_tac_game.logic;

namespace Tic_tac_game
{
    public partial class BoardMenu : Form
    {
        private string character;

        private threeBoard three = new threeBoard();
        private fourBoard four = new fourBoard();
        private fiveBoard five = new fiveBoard();
        
        Player player1 = new Player();
        Player player2 = new Player();
        public BoardMenu()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radio_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_3_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        public void checkTable()
        {
            if (radio_1.Checked)
            {
                three.identify_player1 = player1.Character;
                three.identify_player2 = player2.Character;
                three.Show();
            }
            else if (radio_2.Checked)
            {
                four.identify_player1 = player1.Character;
                four.identify_player2 = player2.Character;
                four.Show();
            }
            else if (radio_3.Checked)
            {
                five.identify_player1 = player1.Character;
                five.identify_player2 = player2.Character;
                five.Show();
            }
        }

        void setPlayerChar(Player player1, Player player2)
        {
            
            if (null_char.Text == character)
            {
                player1.Character = character;
                player2.Character = cross_char.Text;
            }
            else if (cross_char.Text == character)
            {
                player1.Character = character;
                player2.Character = null_char.Text;
            }
        }
        
        private void begin_game_Click(object sender, EventArgs e)
        {
            
            setPlayerChar(player1, player2);
            checkTable();
            MessageBox.Show(player1.Character);

        }

        private void null_char_Click(object sender, EventArgs e)
        {
            character = null_char.Text;
        }

        private void cross_char_Click(object sender, EventArgs e)
        {
            character = cross_char.Text;
        }
    }
}