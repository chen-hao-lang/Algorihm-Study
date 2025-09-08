namespace Alogorihm.BinaryTree
{
    /// <summary>
    /// 判断根节点是否等于子节点之和
    /// </summary>
    class CheckTree
    {
        public bool SLove(TreeNode root)
        { 
            return root.val == (root.left.val + root.right.val);
        }
    }
}