using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LowestCommonAncestor.UnitTests
{
    public class SubTreeMembersOfTests
    {
        [Test]
        public void TestComplexSubMembers()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, int>()
                {
                    { 0, -1 },
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 5 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 6 },
                    { 11, 10 },
                    { 12, 10 },
                    { 13, 11 },
                    { 14, 13 },
                }
            };

            var expected = new List<int> { 8, 7, 14, 13, 11, 10, 6, 5 };

            Assert.AreEqual(expected, tree.SubTreeMembersOf(8, 14));
        }
    }
}