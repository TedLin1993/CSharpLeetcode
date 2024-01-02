namespace CSharpLeetcode.leetcode;
public class _179
{
    public string LargestNumber(int[] nums)
    {
        var n = nums.Length;
        var numStrs = new string[n];
        for (int i = 0; i < n; i++)
        {
            numStrs[i] = nums[i].ToString();
        }
        Array.Sort(numStrs, (a, b) =>
        {
            var s1 = a + b;
            var s2 = b + a;
            return s2.CompareTo(s1);
        });
        if (numStrs[0] == "0") return "0";
        return string.Join("", numStrs);
    }
}