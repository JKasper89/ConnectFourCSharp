using System.Collections.Generic;

namespace ConnectFour.Main.Test
{
    public class LineDummy : Line
    {
        public LineDummy(IReadOnlyList<Slot> slots) : base(slots)
        {
        }
    }
}
