using System;
using Application.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Test
{
    [TestClass]
    public class SpiralTest
    {
        [TestMethod]
        public void MatrixSpiralHasTwentyElements()
        {
            int[,] a = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };

            MatrixToSpiral.Spiral(a, 0, 3, 0, 4);

            Assert.AreEqual(MatrixToSpiral.List.Count, 20);
        }
    }
}
