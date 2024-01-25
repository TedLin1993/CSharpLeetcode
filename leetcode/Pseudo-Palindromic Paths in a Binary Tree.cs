using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class _1457
{
    public int PseudoPalindromicPaths(TreeNode root)
    {
        var res = 0;
        void dfs(TreeNode node, int valCount)
        {
            valCount ^= 1 << node.val;
            if (node.left == null && node.right == null)
            {
                if ((valCount & (valCount - 1)) == 0) res++;
                return;
            }
            if (node.left != null) dfs(node.left, valCount);
            if (node.right != null) dfs(node.right, valCount);
        }
        dfs(root, 0);
        return res;
    }
}