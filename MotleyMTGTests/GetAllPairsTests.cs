using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MotleyMTGTests
{
    [TestClass]
    public class GetAllPairsTests
    {
        public TestContext testContextInstance { get; set; }

            [TestMethod]
        public void FourObjectsShouldHaveThreeWaysToPair()
        {
            List<int> objs = new List<int> { 1, 2, 3, 4 };
            List<List<Tuple<int, int>>> allPairs = MotleyMTG.Draft.GetAllPossiblePairs(objs);
            Assert.AreEqual(3, allPairs.Count);
        }

        [TestMethod]
        public void EightObjectsShouldHave105WaysToPair()
        {
            List<int> objs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<List<Tuple<int, int>>> allPairs = MotleyMTG.Draft.GetAllPossiblePairs(objs);
            Assert.AreEqual(105, allPairs.Count);
        }

        [TestMethod]
        public void EightObjectsShouldHaveFourPairs()
        {
            List<int> objs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<List<Tuple<int, int>>> allPairs = MotleyMTG.Draft.GetAllPossiblePairs(objs);
            Assert.IsTrue(Array.TrueForAll<List<Tuple<int,int>>>(allPairs.ToArray(), pairList => pairList.Count == 4));
        }

        private TimeSpan Time(Action toTime)
        {
            var timer = Stopwatch.StartNew();
            toTime();
            timer.Stop();
            return timer.Elapsed;
        }

        [TestMethod]
        public void PerformanceForTwelveItemsIsntBad()
        {
            List<int> objs = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            TimeSpan howLongItTook = Time(() => MotleyMTG.Draft.GetAllPossiblePairs(objs));
            Trace.WriteLine(howLongItTook.TotalSeconds + " seconds to handle a dozen items.");
            Assert.IsTrue(howLongItTook <= TimeSpan.FromSeconds(1));
        }
    }
}
