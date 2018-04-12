using System;
using ConsoleTestApp.TestProg;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleTestApp.UnitTests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void DuplicateCountTests()
        {
            // Arrange
            var kata = new Kata();

            // Act

            // Assert
            Assert.AreEqual(0, kata.DuplicateCount("asd"));
            Assert.AreEqual(1, kata.DuplicateCount("aasd"));
            Assert.AreEqual(2, kata.DuplicateCount("aassd"));
            Assert.AreEqual(3, kata.DuplicateCount("12312312sadasfasvALKSNASNKxxxxx"));
            Assert.AreEqual(0, kata.DuplicateCount(""));
            Assert.AreEqual(0, kata.DuplicateCount("abcde"));
            Assert.AreEqual(2, kata.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, kata.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, kata.DuplicateCount("Indivisibility"));
            Assert.AreEqual(1, kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");

        }
    }
}
