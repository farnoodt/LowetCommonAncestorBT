using System;

namespace LowetCommonAncestorBT
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(3);
            tree.left = new Node(6);
            tree.left.left = new Node(2);
            tree.left.right = new Node(11);
            tree.left.right.left = new Node(9);
            tree.left.right.right = new Node(5);
            tree.right = new Node(8);
            tree.right.right = new Node(13);
            tree.right.right.left = new Node(7);

            LowestCommonAncestor LCA = new LowestCommonAncestor();

            Console.WriteLine(LCA.LowestCommonAncestorNode(tree, tree.left.left, tree.left.right.left).data);
            Console.ReadLine();
        }
    }
}
