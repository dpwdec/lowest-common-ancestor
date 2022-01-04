using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LowestCommonAncestor.UnitTests
{
    public class DifferenceTests
    {
        [Test]
        public void TestBasicDifference()
        {
            var x = new List<int> { 1, 2, 3 };
            var y = new List<int> { 3, 4, 5 };

            Assert.AreEqual(new List<int> { 1, 2, 4, 5 }, x.Difference(y));
        }
    }
}