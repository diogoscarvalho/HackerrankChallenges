namespace TreePreOrderTraversal
{
    internal class BinaryTree
    {
        public Node InsertNode(Node root, int val)
        {
            if (root == null)
            {
                return new Node(val);
            }
            else
            {
                if (val < root.value)
                {
                    root.left = InsertNode(root.left, val);
                }
                else
                {
                    root.right = InsertNode(root.right, val);
                }
                return root;
            }
        }
    }
}
