namespace CSharpLeetcode.leetcode;

public class _169
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> numCount = [];
        var n = nums.Length;
        foreach (var v in nums)
        {
            numCount[v] = numCount.GetValueOrDefault(v) + 1;
            if (numCount[v] > n / 2) return v;
        }
        return -1;
    }
}