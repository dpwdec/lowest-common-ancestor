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
        public const int ROOT = -1; 

        public Dictionary<NodeLabel, NodeLabel> Nodes { get; set; }

        // calculate the lowest common ancestor of two nodes in a tree
        public NodeLabel LowestCommonAncestorOf(params NodeLabel[] nodes)
        {
            var path = RootPathOf(nodes[0]);

            return nodes
            .Aggregate(path, (acc, node) => acc.Intersect(RootPathOf(node)).ToList())
            .First();
        }

        // recursive function to return the path of a node to the tree root
        public List<NodeLabel> RootPathOf(NodeLabel label)
        {
            var path = new List<int> { label };
            return Nodes[label] >= 0 ? path.Merge(RootPathOf(Nodes[label])) : path;
        }

        // returns a sub tree that leads to the two nmodes from the LCA
        public List<NodeLabel> SubTreeMembersOf(NodeLabel x, NodeLabel y)
        {
            // take the symmetric difference between to the two roof paths i.e. opposite of intersection
            var members = RootPathOf(x).Difference(RootPathOf(y));
            // add the LCA for the two nodes to the top
            members.Add(LowestCommonAncestorOf(x, y));
            return members;
        }

        public void Add(NodeLabel label, NodeLabel parent)
        {
            Nodes.Add(label, parent);
        }

        public NodeLabel ParentOf(NodeLabel label)
        {
            return Nodes[label];
        }

        public bool Contains(NodeLabel label)
        {
            return Nodes.Keys.Contains(label);
        }
    }

    public class Node
    {
        // -1 indicates a null parent relationship
        public NodeLabel Parent { get; set; }
    }

    public static class Extensions
    {
        public static List<T> Merge<T>(this List<T> list, List<T> other)
        {
            list.AddRange(other);
            return list;
        }

        public static List<T> Difference<T>(this List<T> list, List<T> other)
        {
            var listDiff = list.Except(other).ToList();
            var otherDiff = other.Except(list);

            listDiff.AddRange(otherDiff);

            return listDiff;
        }
    }
}
