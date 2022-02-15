using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Tests
{
    [TestClass()]
    public class KuriageTests
    {
        [TestMethod()]
        public void Kuriage10Test()
        {
            //Assert.Fail();
            Assert.AreEqual(10, Kuriage.Kuriage10(6));
        }
    }
}