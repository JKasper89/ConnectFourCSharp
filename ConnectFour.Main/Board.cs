using System.Collections.Generic;

namespace ConnectFour.Main
{
    public class Board
    {
        private readonly IReadOnlyList<IReadOnlyList<Slot>> _slots;
        private readonly IReadOnlyList<Row> _rows;
        private readonly IReadOnlyList<Column> _columns;
        private readonly IReadOnlyList<Diagonal> _diagonals;

        public Board(IReadOnlyList<IReadOnlyList<Slot>> slots,
                    IReadOnlyList<Row> rows,
                    IReadOnlyList<Column> columns,
                    IReadOnlyList<Diagonal> diagonals)
        {
            _slots = slots;
            _rows = rows;
            _columns = columns;
            _diagonals = diagonals;
        }
        public IReadOnlyList<IReadOnlyList<Slot>> Slots
        {
            get { return _slots; }
        }
        public IReadOnlyList<Row> Rows
        {
            get { return _rows; }
        }
        public IReadOnlyList<Column> Columns
        {
            get { return _columns; }
        }
        public IReadOnlyList<Diagonal> Diagonals
        {
            get { return _diagonals; }
        }
    }
}
