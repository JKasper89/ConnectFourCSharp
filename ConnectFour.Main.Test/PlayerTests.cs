using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectFour.Main.Test
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void MakeTurnRemovesCoin()
        {
            var coins = new List<Coin>
                            {
                              new Coin(new Colour(128,0,0), "Foo"),
                              new Coin(new Colour(128,0,0), "Foo")
                            };
            var initialCount = coins.Count;
            var testTarget = new Player("Foo", coins, new Colour(128,0,0));
            

            testTarget.MakeTurn(new ColumnMock());

            Assert.AreEqual(initialCount - 1, testTarget.Coins.Count);
        }
        [TestMethod]
        public void DropCoinIsCalledByMakeTurn()
        {
            var coins = new List<Coin>
                            {
                              new Coin(new Colour(128,0,0), "Foo"),
                              new Coin(new Colour(128,0,0), "Foo")
                            };
            var initialCount = coins.Count;
            var testTarget = new Player("Foo", coins, new Colour(128,0,0));
            var columnMock = new ColumnMock();

            testTarget.MakeTurn(columnMock);

            Assert.IsTrue(columnMock.IsDropCoinCalled);
        }
    }
}
