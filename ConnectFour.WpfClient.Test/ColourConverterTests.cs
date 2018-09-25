using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Media;
using ConnectFour.Main;

namespace ConnectFour.WpfClient.Test
{
    [TestClass]
    public class ColourConverterTests
    {
        [TestMethod]
        public void ColourConverterReturnsBrushWithRGB()
        {
            var colour = new Colour(255, 128, 0);
            var testTarget = new ColourConverter();

            var resultingBrush = (SolidColorBrush)testTarget.Convert(colour, null, null, null);

            var estimatedBrushColour = Color.FromRgb(255, 128, 0);

            Assert.AreEqual(estimatedBrushColour, resultingBrush.Color);
        }
    }
}
