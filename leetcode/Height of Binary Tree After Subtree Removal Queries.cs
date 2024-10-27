using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class _2458
{
    public int[] TreeQueries(TreeNode root, int[] queries)
    {
        var heightDict = new Dictionary<TreeNode, int>();
        int dfs(TreeNode node)
        {
            if (node is null) return 0;
            heightDict[node] = 1 + Math.Max(dfs(node.left), dfs(node.right));
            return heightDict[node];
        }
        dfs(root);

        var res = new int[heightDict.Count + 1];
        void dfsRes(TreeNode node, int current, int prevMax)
        {
            if (node is null) return;
            res[node.val] = Math.Max(prevMax, current);
            current += 1;

            var rightMax = node.right is not null ? Math.Max(prevMax, current + heightDict[node.right]) : prevMax;
            var leftMax = node.left is not null ? Math.Max(prevMax, current + heightDict[node.left]) : prevMax;

            dfsRes(node.left, current, rightMax);
            dfsRes(node.right, current, leftMax);
        }
        dfsRes(root, -1, 0);

        for (int i = 0; i < queries.Length; i++)
        {
            queries[i] = res[queries[i]];
        }
        return queries;
    }
}