using System;
using System.Collections.Generic;
using System.Linq;
using NodeLabel = System.Int32;

namespace LowestCommonAncestor
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // label based node storage
    public class Tree
    {
        public Dictionary<NodeLabel, Node> Nodes { get; set; }

        // calculate the lowest common ancestor of two nodes in a tree
        public NodeLabel LowestCommonAncestor(NodeLabel x, NodeLabel y)
        {
            // calculate the intersection of the two paths from the nodes in question to the root
            return RootPathOf(x)
                .Intersect(RootPathOf(y))
                // order the nodes in the intersection by their depth
                .OrderBy(node => RootPathOf(node).Count)
                // return the deepest node in the instersection i.e. LCA
                .Last();
        }

        // recursive function to return the path of a node to the tree root
        public List<int> RootPathOf(NodeLabel label)
        {
            var node = Nodes[label];
            var path = new List<int> { label };
            return node.Parent >= 0 ? path.Merge(RootPathOf(node.Parent)) : path;
        }
    }

    public class Node
    {
        // -1 indicates a null parent relationship
        public NodeLabel Parent { get; set; }
        public List<NodeLabel> Children { get; set; }
    }

    public static class Extensions
    {
        public static List<T> Merge<T>(this List<T> list, List<T> other)
        {
            list.AddRange(other);
            return list;
        }
    }
}
