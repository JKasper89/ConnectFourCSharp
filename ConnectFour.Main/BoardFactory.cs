using System;
using System.Collections.Generic;

namespace ConnectFour.Main
{
    public class BoardFactory
    {
        public Board Create(int rowsCount, int columnsCount)
        {
            if (columnsCount < 2) throw new ArgumentOutOfRangeException("columnsCount");
            if (rowsCount < 2) throw new ArgumentOutOfRangeException("rowsCount");
            // Create 2D Slot-Array
            var slots = new Slot[columnsCount][];
            for(var i=0; i < columnsCount; i++)
            {
                slots[i] = new Slot[rowsCount];
                for(var j = 0; j < rowsCount; j++)
                {
                    slots[i][j] = new Slot(i,j);
                }
            }
            // Add Columns
            var columns = new List<Column>();
            for(var i = 0; i < columnsCount; i++)
            {
                var columnSlots = new List<Slot>();
                for(var j = 0; j < rowsCount; j++)
                {
                    columnSlots.Add(slots[i][j]);
                }
                columns.Add(new Column(columnSlots));
            }
            // Add Rows
            var rows = new List<Row>();
            for (var j = 0; j < rowsCount; j++)
            {
                var rowSlots = new List<Slot>();
                for (var i = 0; i < rowsCount; i++)
                {
                    rowSlots.Add(slots[i][j]);
                }
                rows.Add(new Row(rowSlots));
            }
            // Add Diagonals
            var diagonals = new List<Diagonal>();
            // Diagonals from TopLeft to RightDown
            var diagonalDirection = DiagonalDirection.DownRight;
            for ( var i = 0; i< columnsCount; i++)
            {
                var columnIndex = i;
                var rowIndex = 0;

                var diagonalSlots = new List<Slot>();
                while(columnIndex < columnsCount && rowIndex <rowsCount)
                {
                    diagonalSlots.Add(slots[columnIndex][rowIndex]);
                    columnIndex++;
                    rowIndex++;
                }
                if(diagonalSlots.Count >= 4)
                {
                    diagonals.Add(new Diagonal(i,0,diagonalDirection,diagonalSlots));
                }
            }

            for ( var j = 1; j <rowsCount; j++)
            {
                var columnIndex = 0;
                var rowIndex = j;

                var diagonalSlots = new List<Slot>();
                while(columnIndex < columnsCount && rowIndex < rowsCount)
                {
                    diagonalSlots.Add(slots[columnIndex][rowIndex]);
                    columnIndex++;
                    rowIndex++;
                }
                if (diagonalSlots.Count >= 4)
                {
                    diagonals.Add(new Diagonal(0,j,diagonalDirection,diagonalSlots));
                }
            }
            // Diagonals fromt LeftDown to RightUp
            diagonalDirection = DiagonalDirection.DownLeft;
            for (var i = 0; i < columnsCount; i++)
            {
                var columnIndex = i;
                var rowIndex = 0;

                var diagonalSlots = new List<Slot>();
                while (columnIndex >= 0 && rowIndex < rowsCount)
                {
                    diagonalSlots.Add(slots[columnIndex][rowIndex]);
                    columnIndex--;
                    rowIndex++;
                }
                if (diagonalSlots.Count >= 4)
                {
                    diagonals.Add(new Diagonal(i,0,diagonalDirection,diagonalSlots));
                }
            }

            for (var j = 1; j < rowsCount; j++)
            {
                var columnIndex = columnsCount-1;
                var rowIndex = j;

                var diagonalSlots = new List<Slot>();
                while (columnIndex >= 0 && rowIndex < rowsCount)
                {
                    diagonalSlots.Add(slots[columnIndex][rowIndex]);
                    columnIndex--;
                    rowIndex++;
                }
                if (diagonalSlots.Count >= 4)
                {
                    diagonals.Add(new Diagonal(columnsCount - 1,j,diagonalDirection,diagonalSlots));
                }
            }
            // Initialize Board
            return new Board(slots, rows, columns, diagonals);
        }
    }
}
