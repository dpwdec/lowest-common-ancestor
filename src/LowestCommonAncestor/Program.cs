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
        public int DepthOf(NodeLabel label)
        {
            var node = Nodes[label];
            return node.Parent >= 0 ? 1 + DepthOf(node.Parent) : 1;
        }
    }

    public class Node
    {
        // -1 indicates a null parent relationship
        public NodeLabel Parent { get; set; }
        public List<NodeLabel> Children { get; set; }
    }
}
