namespace DiscussionWeek4
{
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
