using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowetCommonAncestorBT
{
    class LowestCommonAncestor
    {
        public Node LowestCommonAncestorNode(Node root, Node N1, Node N2)
        {
            if (root == null)
                return null;

            if (root == N1 || root == N2)
                return root;


            Node left = LowestCommonAncestorNode(root.left, N1, N2);
            
            Node right = LowestCommonAncestorNode(root.right, N1, N2);

            if (left != null && right != null)
                return root;

            if (left == null && right == null)
                return null;

            return left != null ? left : right;

        }
    }
}
