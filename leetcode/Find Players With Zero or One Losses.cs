namespace CSharpLeetcode.leetcode;

public class _2225
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        Dictionary<int, int> loseCount = [];
        foreach (var m in matches)
        {
            loseCount[m[0]] = loseCount.GetValueOrDefault(m[0]);
            loseCount[m[1]] = loseCount.GetValueOrDefault(m[1]) + 1;
        }
        List<IList<int>> res = [];
        List<int> res1 = [];
        res.Add(res1);
        List<int> res2 = [];
        res.Add(res2);
        foreach (var kvp in loseCount)
        {
            if (kvp.Value == 0)
            {
                res1.Add(kvp.Key);
            }
            else if (kvp.Value == 1)
            {
                res2.Add(kvp.Key);
            }
        }
        res1.Sort();
        res2.Sort();
        return res;
    }
}