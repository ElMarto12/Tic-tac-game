using System.Windows.Forms;

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
        
    }
}