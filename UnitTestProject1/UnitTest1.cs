using System;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program_Walutowy;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange  
            string debitAmount = "1,2";
            bool expected = true;
            Form4 account = new Form4();

            // act  
            bool actual = account.CzyJestLiczba(debitAmount);

            // assert  
            Assert.AreEqual(expected ? "Tak" : "Nie", actual ? "Tak" : "Nie", "Nie", "Ciąg nie jest liczbą!");
        }
    }
}
