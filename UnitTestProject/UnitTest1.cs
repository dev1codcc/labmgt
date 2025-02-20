using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LabLocker;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int pwd = Passwd.getPwd();
            Assert.AreNotSame(25, pwd, "Wrong password. " + pwd);
        }
    }
}
