using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Tests
{
    [TestClass()]
    public class JetCoasterTests
    {
        [TestMethod()]
        public void rideTest()
        {
            int[] g1 = { 4, 1, 2, 1 };
            Assert.AreEqual(16, JetCoaster.ride(6, g1, 4));
            Assert.AreEqual(5, JetCoaster.ride(6, g1, 1));
            Assert.AreEqual(8, JetCoaster.ride(6, g1, 2));
            Assert.AreEqual(13, JetCoaster.ride(6, g1, 3));
            int[] g2 = { 1, 4, 2, 1 };
            Assert.AreEqual(9, JetCoaster.ride(6, g2, 2));
            Assert.AreEqual(21, JetCoaster.ride(6, g2, 4));
        }
    }
}