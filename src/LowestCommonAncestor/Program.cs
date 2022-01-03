using System;
using System.Collections.Generic;
using NodeLabel = System.Int32;

namespace LowestCommonAncestor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // label based node storage
    public class Tree
    {
        public Dictionary<NodeLabel, Node> Nodes { get; set; }

        // calculate the lowest common ancestor of two nodes in a tree
        public NodeLabel LowestCommonAncestor(NodeLabel x, NodeLabel y)
        {
            return 0;
        }

        // recursive function to enumerate the depth of a node
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
