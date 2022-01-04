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
                Nodes = new Dictionary<int, Node>()
                {
                    { 0, new Node() { Parent = -1 } },
                    { 1, new Node() { Parent = 0 } },
                    { 2, new Node() { Parent = 1 } },
                    { 3, new Node() { Parent = 2 } },
                    { 4, new Node() { Parent = 2 } },
                    { 5, new Node() { Parent = 4 } },
                    { 6, new Node() { Parent = 5 } },
                    { 7, new Node() { Parent = 5 } },
                    { 8, new Node() { Parent = 7 } },
                    { 9, new Node() { Parent = 8 } },
                    { 10, new Node() { Parent = 6 } },
                    { 11, new Node() { Parent = 10 } },
                    { 12, new Node() { Parent = 10 } },
                    { 13, new Node() { Parent = 11 } },
                    { 14, new Node() { Parent = 13 } },
                }
            };

            var expected = new List<int> { 8, 7, 14, 13, 11, 10, 6, 5 };

            Assert.AreEqual(expected, tree.SubTreeMembersOf(8, 14));
        }
    }
}