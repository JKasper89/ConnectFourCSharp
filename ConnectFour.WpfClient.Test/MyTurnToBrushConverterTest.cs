using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media;

namespace ConnectFour.WpfClient.Test
{
    [TestClass]
    public class MyTurnToBrushConverterTest
    {
        [TestMethod]
        public void ConverterTransparentIfFalse()
        {
            var testTarget = new MyTurnToBrushConverter();
            var brush = (SolidColorBrush)testTarget.Convert(false, null, null, null);
            Assert.AreEqual(Colors.Transparent, brush.Color);
        }
        [TestMethod]
        public void ConverterColourIfTrue()
        {
            var testTarget = new MyTurnToBrushConverter();
            var brush = (SolidColorBrush)testTarget.Convert(true, null, null, null);
            Assert.AreEqual(Colors.Silver, brush.Color);
        }
    }
}
