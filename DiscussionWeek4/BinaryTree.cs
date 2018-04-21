namespace DiscussionWeek4
{
    /// <summary>
    /// Bare bones binary tree class.
    /// Data here is a string, but this is easy enough to generalize to anything, or even to turn into a generic class.
    /// </summary>
    public class BinaryTree
    {
        public BinaryTree Left {
            get;
            private set;
        }

        public BinaryTree Right {
            get;
            private set;
        }

        public string Data {
            get;
            private set;
        }

        public BinaryTree (string data) {
            Left = null;
            Right = null;
            Data = data;
        }

        public BinaryTree (string data, BinaryTree left, BinaryTree right) {
            Left = left;
            Right = right;
            Data = data;
        }
    }
}
