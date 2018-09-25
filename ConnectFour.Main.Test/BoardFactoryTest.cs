using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectFour.Main.Test
{
    [TestClass]
    public class BoardFactoryTest
    {
        private BoardFactory _testTarget;
        private Board _board;

        [TestInitialize]
        public void TestInitialize()
        {
            _testTarget = new BoardFactory();
            _board = _testTarget.Create(6, 7);
        }
        [TestMethod]
        public void TestCreatingColumnCount()
        {
            Assert.AreEqual(7, _board.Columns.Count);
        }
        [TestMethod]
        public void TestCreatingRowCount()
        {
            Assert.AreEqual(6, _board.Rows.Count);
        }
        [TestMethod]
        public void CreateSlotsToColumn()
        {
            var column3 = _board.Columns[2];
            Assert.IsTrue(column3.Slots.All(Slot => Slot.X == 2));
        }
        [TestMethod]
        public void CreateSlotsToRow()
        {
            var row4 = _board.Rows[3];
            Assert.IsTrue(row4.Slots.All(Slot => Slot.Y == 3));
        }
        [TestMethod]
        public void CreateSlotsToDiagonalDownLeft()
        {

            var diagonal = _board.Diagonals.First(Diagonal => Diagonal.DiagonalDirection == DiagonalDirection.DownLeft &&
                                                            Diagonal.StartIndexX == 5 &&
                                                            Diagonal.StartIndexY == 0);

            var firstSlot = diagonal.Slots.First();
            var lastSlot = diagonal.Slots.Last();
            Assert.IsTrue(firstSlot.X == 5 && firstSlot.Y == 0);
            Assert.IsTrue(lastSlot.X == 0 && lastSlot.Y == 5);
        }
        [TestMethod]
        public void CreateSlotsToDiagonalDownRight()
        {
            var diagonal = _board.Diagonals.First(Diagonal => Diagonal.DiagonalDirection == DiagonalDirection.DownRight &&
                                                            Diagonal.StartIndexX == 0 &&
                                                            Diagonal.StartIndexY == 2);
            var firstSlot = diagonal.Slots.First();
            var lastSlot = diagonal.Slots.Last();
            Assert.IsTrue(firstSlot.X == 0 && firstSlot.Y == 2);
            Assert.IsTrue(lastSlot.X == 3 && lastSlot.Y == 5);
        }
        [TestMethod]
        public void CreateIgnoresUnderFourSlots()
        {
            Assert.IsTrue(_board.Diagonals.All(Diagonal => Diagonal.Slots.Count >= 4));
        }
    }
}
