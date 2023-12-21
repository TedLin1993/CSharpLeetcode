namespace CSharpLeetcode.leetcode;
public class _560
{
    public int SubarraySum(int[] nums, int k)
    {
        var preSumDict = new Dictionary<int, int>();
        preSumDict[0] = 1;
        var res = 0;
        var cur = 0;
        foreach (var v in nums)
        {
            cur += v;
            if (preSumDict.ContainsKey(cur - k))
            {
                res += preSumDict[cur - k];

            }
            if (!preSumDict.ContainsKey(cur))
            {
                preSumDict[cur] = 1;
            }
            else
            {
                preSumDict[cur]++;
            }
        }
        return res;
    }
}