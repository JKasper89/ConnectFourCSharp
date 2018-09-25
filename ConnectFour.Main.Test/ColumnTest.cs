using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectFour.Main.Test
{
    [TestClass]
    public class ColumnTest
    {
        [TestMethod]
        public void DropCoinInEmptyColumn()
        {
            var slots = new List<Slot>();
            for(int i = 0; i < 6; i++)
            {
                slots.Add(new Slot(i,0));
            }
            var testTarget = new Column(slots);
            var coin = new Coin(new Colour(128,0,0),"Foo");

            testTarget.DropCoin(coin);

            for(var i = 0; i < slots.Count; i++)
            {
                if(i==0)
                {
                    Assert.AreEqual(coin, slots[i].Coin);
                    continue;
                }
                Assert.IsNull(slots[i].Coin);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DropCoinThrowException()
        {
            var coin = new Coin(new Colour(128, 0, 0), "Foo");
            var slots = new List<Slot>();
            for (int i = 0; i < 6; i++)
            {
                slots.Add(new Slot(i,0) { Coin = coin });
            }
            var testTarget = new Column(slots);
            

            testTarget.DropCoin(coin);

            for (var i = 0; i < slots.Count; i++)
            {
                if (i == 0)
                {
                    Assert.AreEqual(coin, slots[i].Coin);
                    continue;
                }
                Assert.IsNull(slots[i].Coin);
            }
        }
        [TestMethod]
        public void IsIsColumnFullWorkingFalse()
        {
            var coin = new Coin(new Colour(128, 0, 0), "Foo");
            var slots = new List<Slot>();
            for (int i = 0; i < 6; i++)
            {
                slots.Add(new Slot(i,0));
            }
            slots[0].Coin = coin;
            slots[1].Coin = coin;
            var testTarget = new Column(slots);

            Assert.IsFalse(testTarget.IsColumnFull);
            
        }
        [TestMethod]
        public void IsIsColumnFullWorkingTrue()
        {
            var coin = new Coin(new Colour(128, 0, 0), "Foo");
            var slots = new List<Slot>();
            for (int i = 0; i < 6; i++)
            {
                slots.Add(new Slot(i,0) { Coin = coin });
            }
            var testTarget = new Column(slots);

            Assert.IsTrue(testTarget.IsColumnFull);

        }
    }
}
