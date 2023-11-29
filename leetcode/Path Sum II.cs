using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class Path_Sum_II
{
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        var res = new List<IList<int>>();
        void dfs(TreeNode? node, List<int> path, int curSum)
        {
            if (node == null) return;
            curSum += node.val;
            path.Add(node.val);
            if (curSum == targetSum && node.left == null && node.right == null)
                res.Add(new List<int>(path));
            dfs(node.left, path, curSum);
            dfs(node.right, path, curSum);
            path.RemoveAt(path.Count - 1);
        }
        dfs(root, new List<int>(), 0);
        return res;
    }
}