using System.Collections.Generic;
using NUnit.Framework;

namespace LowestCommonAncestor.UnitTests
{
    public class RootPathOfTests
    {
        [Test]
        public void TestSingleNodeTree()
        {
            var tree = new Tree()
            {
                Nodes = new Dictionary<int, int>()
                {
                    {0, -1 }
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
                Nodes = new Dictionary<int, int>()
                {
                    {0, -1 },
                    {1, 0 }
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
                Nodes = new Dictionary<int, int>()
                {
                    {0, -1 },
                    {1, 0 },
                    {2, 1 },
                    {3, 2 },
                    {4, 2 }
                }
            };

            var expected = new List<int> { 4, 2, 1, 0 };

            Assert.AreEqual(expected, tree.RootPathOf(4));
        }
    }
}