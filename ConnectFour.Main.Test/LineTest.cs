using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectFour.Main.Test
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void FourInARow()
        {
            
            var slots = new List<Slot>
                        {
                            new Slot(0,0){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,1){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,2){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,3){Coin= new Coin(new Colour(128,0,0), "Foo")}
                        };
            var testTarget = new LineDummy(slots);
            var playerName = testTarget.CheckIfFourConnects();

            Assert.AreEqual("Foo", playerName);
        }

        [TestMethod]
        public void FourInARowWithBreak()
        {
            
            var slots = new List<Slot>
                        {
                            new Slot(0,0){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,1){Coin= new Coin(new Colour(0,128,0), "Bar")},
                            new Slot(0,2){Coin= new Coin(new Colour(0,128,0), "Bar")},
                            new Slot(0,3){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,4){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,5){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,6){Coin= new Coin(new Colour(128,0,0), "Foo")}
                        };
            var testTarget = new LineDummy(slots);
            var playerName = testTarget.CheckIfFourConnects();

            Assert.AreEqual("Foo", playerName);
        }
        [TestMethod]
        public void NoWinner()
        {
            var slots = new List<Slot>
                        {
                            new Slot(0,1){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,2){Coin= new Coin(new Colour(0,128,0), "Bar")},
                            new Slot(0,3){Coin= new Coin(new Colour(0,128,0), "Bar")},
                            new Slot(0,4){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,5){Coin= new Coin(new Colour(128,0,0), "Foo")},
                            new Slot(0,6){Coin= new Coin(new Colour(128,0,0), "Foo")}
                        };
            var testTarget = new LineDummy(slots);
            var playerName = testTarget.CheckIfFourConnects();

            Assert.AreEqual(null, playerName);
        }
            
    }
}
