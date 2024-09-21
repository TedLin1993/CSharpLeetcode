namespace CSharpLeetcode.leetcode;

public class _386
{
    public IList<int> LexicalOrder(int n)
    {
        var res = Dfs(0, n);
        return res;
    }

    public List<int> Dfs(int val, int n)
    {
        var res = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            var temp = val + i;
            if (temp == 0) continue;
            if (temp > n) return res;
            res.Add(temp);
            if (temp * 10 <= n)
            {
                res.AddRange(Dfs(temp * 10, n));
            }
        }
        return res;
    }
}