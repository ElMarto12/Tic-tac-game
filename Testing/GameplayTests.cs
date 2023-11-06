
using System.Windows.Forms;
using NUnit.Framework;
using Tic_tac_game.logic;

namespace Tic_tac_game.tests
{
    [TestFixture]
    public class GameplayTests
    {
        [Test]
        public void TestSwitchPlayer_Player1StatusTrue()
        {
            var gameplay = new Gameplay();
            var player1 = new Player { PlayerStatus = true };
            var player2 = new Player { PlayerStatus = false };
            
            gameplay.switchPlayer(player1, player2);
            
            Assert.That(player1.PlayerStatus, Is.False);
            Assert.That(player2.PlayerStatus, Is.True);
        }

        [Test]
        public void TestSwitchPlayer_Player2StatusTrue()
        {
            
            var gameplay = new Gameplay();
            var player1 = new Player { PlayerStatus = false };
            var player2 = new Player { PlayerStatus = true };
            
            gameplay.switchPlayer(player1, player2);
            
            Assert.That(player1.PlayerStatus, Is.True);
            Assert.That(player2.PlayerStatus, Is.False);
        }

        [Test]
        public void TestIsDraw_NotDraw()
        {
           
            var gameplay = new Gameplay();
            var buttons = new Button[9]; 
            
            buttons[0] = new Button();
            buttons[1] = new Button();
            buttons[2] = new Button();
            buttons[3] = new Button();
            buttons[4] = new Button();
            buttons[5] = new Button();
            buttons[6] = new Button();
            buttons[7] = new Button();
            buttons[8] = new Button();
            
            var result = gameplay.IsDraw(buttons);
            
            Assert.That(result, Is.False);
        }

        [Test]
        public void TesIsDraw_IsDraw()
        {
            var gameplay = new Gameplay();
            var buttons = new Button[9];

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = "t";
            }
            
            var result = gameplay.IsDraw(buttons);
            
            Assert.That(result, Is.True);
        }
    }
}