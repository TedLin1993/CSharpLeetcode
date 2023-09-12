using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode dfs(TreeNode node)
            {
                if (node == null)
                {
                    return null;
                }
                if (node == p || node == q)
                {
                    return node;
                }
                var left = dfs(node.left);
                var right = dfs(node.right);
                if (left != null && right != null)
                {
                    return node;
                }
                if (left != null)
                {
                    return left;
                }
                return right;
            }

            return dfs(root);
        }
    }
}