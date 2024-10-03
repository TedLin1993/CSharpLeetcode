namespace CSharpLeetcode.leetcode;
public class _1590
{
    public int MinSubarray(int[] nums, int p)
    {
        var remain = (int)(nums.Sum(x => (long)x) % p);
        if (remain == 0) return 0;

        var res = nums.Length;
        var prefixRemainDict = new Dictionary<int, int>();
        prefixRemainDict[0] = -1;
        var prefixRemain = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            prefixRemain = (nums[i] + prefixRemain) % p;
            var key = (prefixRemain - remain + p) % p;
            if (prefixRemainDict.ContainsKey(key))
            {
                res = Math.Min(res, i - prefixRemainDict[key]);
            }
            prefixRemainDict[prefixRemain] = i;
        }

        return res == nums.Length ? -1 : res;
    }
}