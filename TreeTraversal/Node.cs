using System;

namespace TreeTraversal
{
    public class Node
    {
        public string Id { get; set; }
        public Node[] ChildNodes { get; set; }
        public bool IsTargetNode { get; set; }
        public Node ParentNode { get; set; }
    }
}