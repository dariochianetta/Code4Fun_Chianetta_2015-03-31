using System;
using Application.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Test
{
    [TestClass]
    public class EuleroTest
    {
        [TestMethod]
        public void ReturnRightValueEuleroProblem()
        {
            int somma = 233168;

           int result =  EuleroProblem.Eulero();

           Assert.AreEqual(result, somma);
        }
    }
}
