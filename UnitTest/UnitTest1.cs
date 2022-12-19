using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software.Design.Models;
using System;
using System.Diagnostics.Metrics;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void Invalid_name_length()
            {
                string name = "ASKLDJHKAJSHD:LAJSKDFJHJALHSDFKLJHSLJFJHSLDKHFJNLSKJDGKJSNJDCVJKBSFLVJSKJHNFLKSDBNFSJND"; 
                Assert.IsFalse(Isnotlonger(name));
            }
        
            [TestMethod]
            public void valid_name_length() 
            {
                string name = "team 1";
                Assert.IsTrue(Isnotlonger(name));
            }
        
            [TestMethod]
            public void valid_id()
            {
                int id = 2;
                Assert.IsTrue(idtest(id));
            }

            [TestMethod]
            public void invalid_id()
            {
                int id = 0;
                Assert.IsFalse(idtest(id));
            }

            bool Isnotlonger(string name)
            {
               return name.Length <= 50;
            }

            bool idtest(int value)
            {
                return value > 0 && value < 4;
            }
}
}

