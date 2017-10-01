using System;
using TreeTraversal.Objects;
using TreeTraversal.Testing;
using TreeTraversal.TreeExplorers;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {

            var testTreeEntryNode = GenerateSampleTree();

            var treeExplorer = new IterativeDfsTreeExplorer(testTreeEntryNode); // Modify the explorer to test different behaviours.

            var exitNode = treeExplorer.FindTarget();

            Console.WriteLine("Found target at: " + exitNode.Id);

            var x = Console.ReadLine();

            return;
        }

        static Node GenerateSampleTree()
        {
            var treeGenerator = new TestTreeGenerator(3);

            var testTree = treeGenerator.CreateTree(10, false);

            treeGenerator.PrintTree(testTree, "", false);

            return testTree;
        }
    }
}
