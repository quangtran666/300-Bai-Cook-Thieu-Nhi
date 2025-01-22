var root = new TreeNode(5);
root.left = new TreeNode(4);
root.right = new TreeNode(8);
root.left.left = new TreeNode(11);
root.left.left.left = new TreeNode(7);
root.left.left.right = new TreeNode(2);
root.right.left = new TreeNode(13);
root.right.right = new TreeNode(4);
root.right.right.right = new TreeNode(1);

Console.WriteLine(HasPathSum(root, 22));

bool HasPathSum(TreeNode root, int targetSum)
{
    if (root == null)
        return false;

    if (root.left == null && root.right == null)
        return targetSum == root.val;

    var left = HasPathSum(root.left, targetSum - root.val);
    var right = HasPathSum(root.right, targetSum - root.val);
    
    return left || right;
}

class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
{
    public int val = val;
    public TreeNode left = left;
    public TreeNode right = right;
}