using System;
using System.Collections.Generic;
using ConnectFour.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectFour.WpfClient.Test
{
    [TestClass]
    public class PlayerViewModelTests
    {
        [TestMethod]
        public void ViewModelNotifysMyTurn()
        {
            var testTarget = new PlayerViewModel(new Player("Foo", new List<Coin>(), new Colour(128,0,0)));
            var callCount = 0;
            testTarget.PropertyChanged += (sender, args) => callCount++;

            testTarget.MyTurn = !testTarget.MyTurn;

            Assert.AreEqual(1, callCount);

        }
    }
}
