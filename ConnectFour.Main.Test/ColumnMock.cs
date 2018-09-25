using System;

namespace ConnectFour.Main.Test
{
    public class ColumnMock : IColumn
    {
        private int _countDropCoinCalls;
        public void DropCoin(Coin coin)
        {
            _countDropCoinCalls++;
        }
        public bool IsDropCoinCalled
        {
            get { return _countDropCoinCalls == 1; }
        }
        public bool IsColumnFull
        {
            get { throw new NotSupportedException(); }
        }
    }
}
