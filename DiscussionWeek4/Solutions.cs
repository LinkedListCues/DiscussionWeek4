using System.Collections.Generic;

namespace DiscussionWeek4
{
    public class InOrder : ITraverser
    {
        public string Traverse (BinaryTree root) {
            if (root == null) {
                return "";
            }
            return Traverse(root.Left) + root.Data + Traverse(root.Right);
        }
    }

    public class Preorder : ITraverser
    {
        public string Traverse (BinaryTree root) {
            if (root == null) { return ""; }
            return root.Data + Traverse(root.Left) + Traverse(root.Right);
        }
    }

    public class Postorder : ITraverser
    {
        public string Traverse (BinaryTree root) {
            if (root == null) { return ""; }
            return Traverse(root.Left) + Traverse(root.Right) + root.Data;
        }
    }


    public class BreadthFirst : ITraverser
    {
        public string Traverse (BinaryTree root) {
            var q = new Queue<BinaryTree>();
            string result = "";
            q.Enqueue(root);

            while (q.Count > 0) {
                var node = q.Dequeue();
                result += node.Data;
                if (node.Left != null) { q.Enqueue(node.Left); }
                if (node.Right != null) { q.Enqueue(node.Right); }
            }

            return result;
        }
    }
}
