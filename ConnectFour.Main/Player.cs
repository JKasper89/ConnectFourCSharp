using System;
using System.Collections.Generic;

namespace ConnectFour.Main
{
    public class Player
    {
        private readonly string _name;
        private readonly IList<Coin> _coins;
        private readonly Colour _playerColour;
        public Player(string name, IList<Coin> coins, Colour playerColour)
        {
            _name = name ?? throw new ArgumentNullException("name");
            _coins = coins ?? throw new ArgumentNullException("coins");
            _playerColour = playerColour ?? throw new ArgumentNullException("playerColour");
        }
        public string Name
        {
            get { return _name; }
        }
        public IList<Coin> Coins
        {
            get { return _coins; }
        }
        public Colour PlayerColour
        {
            get { return _playerColour; }
        }
        public void MakeTurn(IColumn column)
        {
            if (column == null) throw new ArgumentNullException("column");

            //Take coin  from player's stash
            var coin = _coins[0];
            _coins.RemoveAt(0);

            //Put coin in target column
            column.DropCoin(coin);

        }
    }
}
