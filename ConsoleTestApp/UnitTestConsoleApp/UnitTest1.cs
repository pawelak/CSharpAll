using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConsoleApp
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void DuplicateCount()
        {
            // Arrange
            KataTests kataTests = new KataTests();

            // Act

            // Assert
            Assert.AreEqual(0, kataTests.DuplicateCount("asd"));

        }
    }
}
