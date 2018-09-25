using System.Collections.Generic;

namespace ConnectFour.Main
{
    public class Row : Line
    {
        //private readonly IReadOnlyList<Slot> _slots;

        public Row(IReadOnlyList<Slot> slots) :base(slots)
        {

        }
    }
}
