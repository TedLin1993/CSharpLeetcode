using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;

public class Path_Sum_III
{
    public int PathSum(TreeNode root, int targetSum)
    {
        var valDict = new Dictionary<long, int>();
        var res = 0;
        void dfs(TreeNode node, long preSum)
        {
            if (node == null) return;
            preSum += node.val;
            if (preSum == targetSum) res++;
            if (valDict.ContainsKey(preSum - targetSum)) res += valDict[preSum - targetSum];
            if (!valDict.ContainsKey(preSum)) valDict.Add(preSum, 0);
            valDict[preSum]++;
            dfs(node.left, preSum);
            dfs(node.right, preSum);
            valDict[preSum]--;
        }
        dfs(root, 0);
        return res;
    }
}