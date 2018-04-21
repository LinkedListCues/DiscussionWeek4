using DiscussionWeek4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeTraversalTests
{
    [TestClass]
    public class TreeTraversalTests
    {
        /* the binary tree that everyone will be traversing
                  A     
                 / \    
                /   \   
               -     -  
               B     C  
              / \   / \ 
             -   - -   -
             D   E F   G
         */
        private static readonly BinaryTree BT =
            new BinaryTree("A",
                new BinaryTree("B",
                    new BinaryTree("D"),
                    new BinaryTree("E")
                    ),
                new BinaryTree("C",
                    new BinaryTree("F"),
                    new BinaryTree("G")
                    )
                );

        [TestMethod]
        public void BreadthFirstTraversal () {
            const string result = "ABCDEFG";
            // TODO replace me with your implementation of a breadth-first traverser
            ITraverser traverser = new IncorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(BT));
        }

        [TestMethod]
        public void InOrderDepthFirstTraversal () {
            const string result = "DBEAFCG";
            // TODO replace me with your implementation of an inorder depth-first traverser
            ITraverser traverser = new IncorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(BT));
        }

        [TestMethod]
        public void PreOrderDepthFirstTraversal () {
            const string result = "ABDECFG";
            // TODO replace me with your implementation of a preorder depth-first traverser
            ITraverser traverser = new IncorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(BT));
        }

        [TestMethod]
        public void PostOrderDepthFirstTraversal () {
            const string result = "DEBFGCA";
            // TODO replace me with your implementation of a postorder depth-first traverser
            ITraverser traverser = new IncorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(BT));
        }
    }
}
