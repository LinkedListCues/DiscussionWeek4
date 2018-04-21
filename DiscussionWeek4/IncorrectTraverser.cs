namespace DiscussionWeek4
{
    /// <inheritdoc />
    /// <summary>
    /// A bad traverser.
    /// Does indeed implement the ITraverser interface, balways returns the same value.
    /// </summary>
    public class IncorrectTraverser : ITraverser
    {
        public string Traverse (BinaryTree root) {
            return "ZYXWVUTSRQPONMLKJIHGFEDCBA";
        }
    }
}
