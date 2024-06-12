// See https://www.hackerrank.com/challenges/tree-preorder-traversal/problem for more information
using TreePreOrderTraversal;

int treeSize = Convert.ToInt32(Console.ReadLine());
string treeValues = Console.ReadLine();

List<int> numbers = new(Array.ConvertAll(treeValues.Split(' '), int.Parse));

Node root = null;
BinaryTree tree = new();

for (int i = 0; i < treeSize ; i++)
{
    root = tree.InsertNode(root, numbers[i]);
}

Solution.PreOrder(root);