using System;
namespace ConnectFour.Main
{
    public class Coin
    {
        private readonly Colour _colour;
        private readonly string _playerName;

        public Coin(Colour colour, string playerName)
        {
            _colour = colour ?? throw new ArgumentNullException("colour");
            _playerName = playerName ?? throw new ArgumentNullException("playerName");
            
        }
        public Colour Colour
        {
            get { return _colour; }
        }
        public string PlayerName
        {
            get { return _playerName; }
        }
    }
}
