using System;
using System.Collections.Generic;

namespace ConnectFour.Main
{
    public class Diagonal : Line
    {
        private readonly int _startIndexX;
        private readonly int _startIndexY;
        private readonly DiagonalDirection _diagonalDirection;

        public Diagonal(int startIndexX,
                        int startIndexY,
                        DiagonalDirection diagonaldirection,
                        IReadOnlyList<Slot> slots) : base(slots)
        {
            if (startIndexX < 0) throw new ArgumentOutOfRangeException("startIndexX");
            if (startIndexY < 0) throw new ArgumentOutOfRangeException("startIndexY");
            _startIndexX = startIndexX;
            _startIndexY = startIndexY;
            _diagonalDirection = diagonaldirection;
                
        }
        public int StartIndexX
        {
            get { return _startIndexX; }
        }
        public int StartIndexY
        {
            get { return _startIndexY; }
        }
        public DiagonalDirection DiagonalDirection
        {
            get { return _diagonalDirection; }
        }
    }
}
;