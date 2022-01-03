using System.Collections.Generic;
using NUnit.Framework;

namespace LowestCommonAncestor.UnitTests
{
    public class DepthOfTests
    {
        [Test]
        public void TestSingleNodeTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, Node>()
                {
                    {0, new Node() { Parent = -1 } }
                }
            };

            var expected = new List<int> { 0 };

            Assert.AreEqual(expected, tree.RootPathOf(0));
        }

        [Test]
        public void TestTwoNodeTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, Node>()
                {
                    {0, new Node() { Parent = -1 } },
                    {1, new Node() { Parent = 0 } }
                }
            };

            var expected = new List<int> { 1, 0 };

            Assert.AreEqual(expected, tree.RootPathOf(1));
        }

        [Test]
        public void TestSplitNodeTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, Node>()
                {
                    {0, new Node() { Parent = -1 } },
                    {1, new Node() { Parent = 0 } },
                    {2, new Node() { Parent = 1 } },
                    {3, new Node() { Parent = 2 } },
                    {4, new Node() { Parent = 2 } }
                }
            };

            var expected = new List<int> { 4, 2, 1, 0 };

            Assert.AreEqual(expected, tree.RootPathOf(4));
        }
    }
}