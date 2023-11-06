using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Tic_tac_game.logic
{
    public class Gameplay
    {
        public void switchPlayer(Player player1, Player player2)
        {
            if (player1.PlayerStatus)
            {
                player1.PlayerStatus = false;
                player2.PlayerStatus = true;
            }
            else if (player2.PlayerStatus)
            {
                player2.PlayerStatus = false;
                player1.PlayerStatus = true;
            }
        }
        
        public bool IsDraw(Button[] buttons)
        {
            
            for (int i = 0; i < buttons.Length; i++)
            {
                if (string.IsNullOrEmpty(buttons[i].Text))
                {
                    return false;
                }
            }

            MessageBox.Show("It's Draw");
            return true;
        }
        
    }
}