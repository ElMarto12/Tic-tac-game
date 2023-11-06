namespace Tic_tac_game.logic
{
    public class Player
    {
        private string _character;
        private bool _playerStatus;
        public string Character
        {
            get { return _character; }
            set { _character = value; }
        }

        public bool PlayerStatus
        {
            get { return _playerStatus; }
            set { _playerStatus = value; }
        }
    }
}