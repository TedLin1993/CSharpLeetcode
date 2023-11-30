namespace CSharpLeetcode.leetcode;
public class Longest_Consecutive_Sequence
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var res = 0;
        foreach (int num in nums)
        {
            if (set.Contains(num - 1)) continue;
            var temp = 1;
            var cur = num + 1;
            while (set.Contains(cur))
            {
                temp++;
                cur++;
            }
            res = Math.Max(res, temp);
        }
        return res;
    }
}