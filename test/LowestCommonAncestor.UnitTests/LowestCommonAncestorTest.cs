using System.Collections.Generic;
using NUnit.Framework;

namespace LowestCommonAncestor.UnitTests
{
    public class LowestCommonAncestorTests
    {
        [Test]
        public void TestSingleDepthTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, Node>()
                {
                    { 0, new Node() { Parent = -1 } },
                    { 1, new Node() { Parent = 0 } },
                    { 2, new Node() { Parent = 0 } }
                }
            };

            Assert.AreEqual(0, tree.LowestCommonAncestor(1, 2));
        }

        [Test]
        public void TestDoubleDepthTailTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, Node>()
                {
                    { 0, new Node() { Parent = -1 } },
                    { 1, new Node() { Parent = 0 } },
                    { 2, new Node() { Parent = 1 } },
                    { 3, new Node() { Parent = 2 } },
                    { 4, new Node() { Parent = 2 } }
                }
            };

            Assert.AreEqual(2, tree.LowestCommonAncestor(3, 4));
        }

        [Test]
        public void TestUnequalDistances()
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
                }
            };

            Assert.AreEqual(2, tree.LowestCommonAncestor(3, 6));
        }

        [Test]
        public void TestComplexBranchingTree()
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

            Assert.AreEqual(5, tree.LowestCommonAncestor(14, 8));
        }
    }
}