using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectFour.Main
{
    public class Column : Line, IColumn
    {

        //private readonly IReadOnlyList<Slot> _slots;

        public Column(IReadOnlyList<Slot> slots) : base(slots)
        {

        }
        public void DropCoin(Coin coin)
        {
            foreach (var slot in Slots)
            {
                if (slot.Coin == null)
                {
                    slot.Coin = coin;
                    return;
                }
            }
            throw new InvalidOperationException("Column is full");
        }
        public bool IsColumnFull
        {
            get{ return Slots.All(slot => slot.Coin != null); }
        }
    }
}
