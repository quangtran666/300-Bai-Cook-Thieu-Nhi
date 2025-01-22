var root = new TreeNode(3);
root.left = new TreeNode(9);
root.right = new TreeNode(20);
root.right.left = new TreeNode(15);
root.right.right = new TreeNode(7);

Console.WriteLine(MaxDepth(root));

int MaxDepth(TreeNode root)
{
    if (root == null)
        return 0;

    var left = MaxDepth(root.left);
    var right = MaxDepth(root.right);
    
    return Math.Max(left, right) + 1;
}

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}