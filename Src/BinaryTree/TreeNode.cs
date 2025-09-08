namespace Alogorihm.BinaryTree
{   
    /// <summary>
    /// 存储int值的树节点
    /// </summary>
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int _val, TreeNode _left = null, TreeNode _right = null)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}