using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;
using System.Collections.Generic;


namespace UnitTestClosest
{
    [TestClass]
    public class ClosestToZeroTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "List cannot be empty or null")]
        public void TestMethodEmpty()
        {
            List<int> ints = new List<int>();
            int closest = Closest.ClosestIntToZero(ints);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "List cannot be empty or null")]
        public void TestMethodNull()
        {
            //List<int> ints = new List<int>();
            int closest = Closest.ClosestIntToZero(null);
        }
        [TestMethod]
        public void TestMethodCosestTie()
        {
            List<int> ints = new List<int>();
            ints.Add(3);
            ints.Add(6);
            ints.Add(1);
            ints.Add(-10);
            ints.Add(-1);
            ints.Add(54);
            ints.Add(-5);
            int closest = Closest.ClosestIntToZero(ints);
            Assert.AreEqual(closest, 1);
        }
        [TestMethod]
        public void TestMethodClosestNegative()
        {
            List<int> ints = new List<int>();
            ints.Add(-1);
            ints.Add(3);
            ints.Add(6);
            ints.Add(-10);
            ints.Add(-1);
            ints.Add(54);
            ints.Add(-5);
            int closest = Closest.ClosestIntToZero(ints);
            Assert.AreEqual(closest, -1);
        }
        [TestMethod]
        public void TestMethodClosestPositive()
        {
            List<int> ints = new List<int>();
            ints.Add(50001);
            ints.Add(50000);
            int closest = Closest.ClosestIntToZero(ints);
            Assert.AreEqual(closest, 50000);
        }
        [TestMethod]
        public void TestMethodClosestLast()
        {
            List<int> ints = new List<int>();
            ints.Add(50001);
            ints.Add(50000);
            ints.Add(-3);
            int closest = Closest.ClosestIntToZero(ints);
            Assert.AreEqual(closest, -3);
        }
        [TestMethod]
        public void TestMethodClosestFirst()
        {
            List<int> ints = new List<int>();
            ints.Add(2);
            ints.Add(50001);
            ints.Add(50000);
            ints.Add(-3);
            int closest = Closest.ClosestIntToZero(ints);
            Assert.AreEqual(closest, 2);
        }
    }
}
