namespace CSharpLeetcode.leetcode;
public class Maximum_XOR_of_Two_Numbers_in_an_Array
{
    public int FindMaximumXOR(int[] nums)
    {
        Array.Sort(nums);
        var mask = 0;
        var res = 0;
        for (int i = 30; i >= 0; i--)
        {
            mask |= 1 << i;
            var nextRes = res | 1 << i;
            var set = new HashSet<int>();
            foreach (var y in nums)
            {
                var maskY = y & mask;
                if (set.Contains(nextRes ^ maskY))
                {
                    res = nextRes;
                    break;
                }
                set.Add(maskY);
            }
        }
        return res;
    }
}