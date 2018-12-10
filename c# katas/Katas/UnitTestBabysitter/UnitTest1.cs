using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabysitterKata;
namespace UnitTestBabysitter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodNoPastBedtime()
        {
            int earnings = Babysitter.CalculateEarnings(5, 10, 10);

            Assert.AreEqual(earnings, 50);
        }
        [TestMethod]
        public void TestMethodPastBedtime()
        {
            int earnings = Babysitter.CalculateEarnings(5, 10, 8);

            Assert.AreEqual(earnings, 42);
        }
        [TestMethod]
        public void TestMethodPastMidnightAndBed()
        {
            int earnings = Babysitter.CalculateEarnings(5, 4, 10);

            Assert.AreEqual(earnings, 94);
        }

        [TestMethod]
        public void TestMethodPastMidnight()
        {
            int earnings = Babysitter.CalculateEarnings(7, 3, 12);

            Assert.AreEqual(earnings, 74);
        }

        [TestMethod]
        public void TestMethodArriveAndDepartSameTime()
        {
            int earnings = Babysitter.CalculateEarnings(7, 7, 11);

            Assert.AreEqual(earnings, 10);
        }
        [TestMethod]
        public void TestMethodArriveAndDepartSameTimeAfterBed()
        {
            int earnings = Babysitter.CalculateEarnings(10, 10, 9);

            Assert.AreEqual(earnings, 6);
        }
        [TestMethod]
        public void TestMethodArriveAndDepartSameTimeAfterMid()
        {
            int earnings = Babysitter.CalculateEarnings(2, 2, 9);

            Assert.AreEqual(earnings, 8);
        }
    }
}
