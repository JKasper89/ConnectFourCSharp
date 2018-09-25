using System;
using System.Collections.Generic;

namespace ConnectFour.Main
{
    public abstract class Line
    {
        private readonly IReadOnlyList<Slot> _slots;
        protected Line(IReadOnlyList<Slot> slots)
        {
            _slots = slots ?? throw new ArgumentNullException("slots");
        }
        public IReadOnlyList<Slot> Slots
        {
            get { return _slots; }
        }
        public string CheckIfFourConnects()
        {
            var counter = 0;
            string actualPlayerName = null;
            foreach(var slot in _slots)
            {
                var coin = slot.Coin;
                if(coin == null)
                {
                    actualPlayerName = null;
                    counter = 0;
                    continue;
                }
                if(actualPlayerName != coin.PlayerName)
                {
                    actualPlayerName = coin.PlayerName;
                    counter = 1;
                    continue;
                }
                counter++;
                if(counter >= 4)
                {
                    return actualPlayerName;
                }
                
            }
            return null;
        }
    }
}
