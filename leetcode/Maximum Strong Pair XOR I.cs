namespace CSharpLeetcode.leetcode;
public class Maximum_Strong_Pair_XOR_I
{
    public int MaximumStrongPairXor(int[] nums)
    {
        var res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) <= Math.Min(nums[i], nums[j]))
                {
                    res = Math.Max(res, nums[i] ^ nums[j]);
                }
            }
        }
        return res;
    }
}