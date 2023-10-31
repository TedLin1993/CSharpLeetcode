namespace CSharpLeetcode.leetcode;
public class Maximum_Points_After_Collecting_Coins_From_All_Nodes
{
    public int MaximumPoints(int[][] edges, int[] coins, int k)
    {
        var n = coins.Length;
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++) graph[i] = new List<int>();
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            graph[e[1]].Add(e[0]);
        }
        var memo = new int[n, 14];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                memo[i, j] = -1;
            }
        }
        int dfs(int i, int j, int parent)
        {
            if (memo[i, j] != -1) return memo[i, j];
            var res1 = (coins[i] >> j) - k;
            var res2 = coins[i] >> (j + 1);
            foreach (var next in graph[i])
            {
                if (next == parent) continue;
                res1 += dfs(next, j, i);
                if (j < 13)
                {
                    res2 += dfs(next, j + 1, i);
                }
            }
            memo[i, j] = Math.Max(res1, res2);
            return memo[i, j];
        }
        var res = dfs(0, 0, -1);
        return res;
    }
    public void Test()
    {
        var res = MaximumPoints(new int[][]{
                new int[]{0,1},
                new int[]{1,2},
                new int[]{2,3}}, new int[] { 10, 10, 3, 3 }, 5);
        Console.WriteLine(res); //11
    }
}