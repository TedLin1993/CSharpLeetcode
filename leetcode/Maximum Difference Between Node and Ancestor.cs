using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public class MaximumDifferenceBetweenNodeandAncestor
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            return dfs(root, root.val, root.val);
        }
        public int dfs(TreeNode node, int min, int max)
        {
            if (node == null) return max - min;
            var curMax = Math.Max(node.val, max);
            var curMin = Math.Min(node.val, min);
            return Math.Max(dfs(node.left, curMin, curMax), dfs(node.right, curMin, curMax));
        }
    }
}