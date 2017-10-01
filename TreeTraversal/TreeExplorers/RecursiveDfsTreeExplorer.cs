using System;
using System.Collections.Generic;
using System.Linq;
using TreeTraversal.Objects;

namespace TreeTraversal.TreeExplorers
{
    public class RecursiveDfsTreeExplorer
    {
        private readonly HashSet<Node> _visitedNodes;

        public RecursiveDfsTreeExplorer()
        {
            _visitedNodes = new HashSet<Node>();
        }

        public Node FindTarget(Node currentNode)
        {

            if (currentNode.IsTargetNode)
                return currentNode;

            foreach (var node in currentNode.ChildNodes.Where(n => !_visitedNodes.Contains(n)))
            {
                FindTarget(node);
            }

            return null;
        }
    }
}
