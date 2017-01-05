using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TellDontAsk.Tests
{
    [TestClass]
    public class PaintTest
    {
        private Paint _paint;

        [TestInitialize]
        public void Initialize()
        {
            _paint = new Paint();
        }

        [TestMethod]
        public void ShouldDrawASquare()
        {
            var square = _paint.DrawASquare(20, 20);

            Assert.IsNotNull(square);
            Assert.IsInstanceOfType(square, typeof(Square));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A square needs height equals width")]
        public void ShouldNotDrawAIncorrectSquare()
        {
            var square = _paint.DrawASquare(20, 50);
        }
    }
}
