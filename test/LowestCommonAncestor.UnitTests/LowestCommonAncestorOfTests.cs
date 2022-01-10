using System.Collections.Generic;
using NUnit.Framework;

namespace LowestCommonAncestor.UnitTests
{
    public class LowestCommonAncestorOfTests
    {
        [Test]
        public void TestSingleDepthTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, int>()
                {
                    { 0, -1 },
                    { 1, 0 },
                    { 2, 0 }
                }
            };

            Assert.AreEqual(0, tree.LowestCommonAncestorOf(1, 2));
        }

        [Test]
        public void TestDoubleDepthTailTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, int>()
                {
                    { 0, -1 },
                    { 1, 0  },
                    { 2, 1  },
                    { 3, 2  },
                    { 4, 2  }
                }
            };

            Assert.AreEqual(2, tree.LowestCommonAncestorOf(3, 4));
        }

        [Test]
        public void TestUnequalDistances()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, int>()
                {
                    { 0, -1  },
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 4 },
                    { 6, 5 },
                }
            };

            Assert.AreEqual(2, tree.LowestCommonAncestorOf(3, 6));
        }

        [Test]
        public void TestComplexBranchingTree()
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

            Assert.AreEqual(5, tree.LowestCommonAncestorOf(14, 8));
        }
    }
}