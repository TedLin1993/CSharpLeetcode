namespace CSharpLeetcode.leetcode;

public class _3020
{
    public int MaximumLength(int[] nums)
    {
        Dictionary<long, int> dict = [];
        foreach (var v in nums)
        {
            dict[v] = dict.GetValueOrDefault(v) + 1;
        }
        var res = 1;
        while (dict.GetValueOrDefault(1) >= 3)
        {
            dict[1] -= 2;
            res += 2;
        }
        dict[1] = 0;
        Array.Sort(nums);
        foreach (var v in nums)
        {
            if (dict[v] == 0) continue;
            var temp = 1;
            long cur = v;
            while (dict.GetValueOrDefault(cur) >= 2)
            {
                if (dict.GetValueOrDefault(cur * cur) == 0)
                {
                    break;
                }
                temp += 2;
                dict[cur] = 0;
                cur *= cur;
            }
            res = Math.Max(res, temp);
        }
        return res;
    }
}