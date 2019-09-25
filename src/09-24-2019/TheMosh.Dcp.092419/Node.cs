using System;
using System.Collections.Generic;
using System.Text;

namespace TheMosh.Dcp._092419
{
    public class Node
    {
        public string Tag { get; set; }

        public List<Node> Children { get; set; }

        public Node Parent { get; set; }

        public int ParentLinkWeight { get; set; }
    }
}
