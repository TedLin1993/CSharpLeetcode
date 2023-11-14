namespace CSharpLeetcode.leetcode;
public class Maximum_Strong_Pair_XOR_II
{
    public int MaximumStrongPairXor(int[] nums)
    {
        Array.Sort(nums);
        var maxBit = 19;
        var mask = 0;
        var res = 0;
        for (int i = maxBit; i >= 0; i--)
        {
            mask |= 1 << i;
            var nextRes = res | 1 << i;
            var dict = new Dictionary<int, int>();
            foreach (var y in nums)
            {
                var maskY = y & mask;
                if (dict.ContainsKey(maskY ^ nextRes) && 2 * dict[maskY ^ nextRes] >= y)
                {
                    res = nextRes;
                    break;
                }
                dict[maskY] = y;
            }
        }
        return res;
    }

    public void Test()
    {
        var test = MaximumStrongPairXor(new int[] { 500, 520, 2500, 3000 });
        Console.WriteLine(test);
    }
}
