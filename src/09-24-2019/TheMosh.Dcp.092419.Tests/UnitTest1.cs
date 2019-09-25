using System;
using Xunit;

namespace TheMosh.Dcp._092419.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Node a = new Node() { Tag = "a", Children = new System.Collections.Generic.List<Node>() };
            Node b = new Node()
            {
                Tag = "b",
                Parent = a,
                ParentLinkWeight = 3
            };
            a.Children.Add(b);

            Node c = new Node()
            {
                Tag = "c",
                Parent = a,
                ParentLinkWeight = 5
            };
            a.Children.Add(c);

            Node d = new Node()
            {
                Tag = "d",
                Parent = a,
                ParentLinkWeight = 8,
                Children = new System.Collections.Generic.List<Node>()
            };
            a.Children.Add(d);

            Node e = new Node()
            {
                Tag = "e",
                Parent = d,
                ParentLinkWeight = 2,
                Children = new System.Collections.Generic.List<Node>()
            };
            d.Children.Add(e);

            Node f = new Node()
            {
                Tag = "f",
                Parent = d,
                ParentLinkWeight = 4
            };
            d.Children.Add(f);

            Node g = new Node()
            {
                Tag = "g",
                Parent = e,
                ParentLinkWeight = 1
            };
            e.Children.Add(g);


            Node h = new Node()
            {
                Tag = "h",
                Parent = e,
                ParentLinkWeight = 1
            };
            e.Children.Add(h);

            Tree tree = new Tree() { Root = a };
            int longestPath = Traverser.FindLongestPathLength(tree);
            Assert.True(longestPath == 17);
        }
    }
}
