using DiscussionWeek4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeTraversalTests
{
    [TestClass]
    public class TreeTraversalTests
    {
        static BinaryTree bt = new BinaryTree("A",
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
        public void BreadthFirstTraversal()
        {
            var result = "ABCDEFG";
            ITraverser traverser = new MostlyCorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(bt));
        }

        [TestMethod]
        public void InOrderDepthFirstTraversal()
        {
            var result = "DBEAFCG";
            ITraverser traverser = new MostlyCorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(bt));
        }

        [TestMethod]
        public void PreOrderDepthFirstTraversal()
        {
            var result = "ABDECFG";
            ITraverser traverser = new MostlyCorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(bt));
        }

        [TestMethod]
        public void PostOrderDepthFirstTraversal()
        {
            var result = "DEBFGCA";
            ITraverser traverser = new MostlyCorrectTraverser();
            Assert.AreEqual(result, traverser.Traverse(bt));
        }
    }
}
