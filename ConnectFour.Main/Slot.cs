using System;

namespace ConnectFour.Main
{
    public class Slot
    {
        private readonly int _x;
        private readonly int _y;

        public Slot(int x, int y)
        {
            if (x < 0) throw new ArgumentOutOfRangeException("x");
            if (y < 0) throw new ArgumentOutOfRangeException("y");
            _x = x;
            _y = y;
        }

        public Coin Coin { get; set; }

        public int X
        {
            get { return _x; }
        }
        public int Y
        {
            get { return _y; }
        }
        public override string ToString()
        {
            return "Slot "+ X +", "+ Y;
        }
    }
}
