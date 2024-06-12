namespace TreePreOrderTraversal
{
    internal class Solution
    {
        public static void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.value + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }
    }
}
