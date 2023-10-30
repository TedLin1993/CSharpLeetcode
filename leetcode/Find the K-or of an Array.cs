namespace CSharpLeetcode.leetcode
{
    public class Find_the_K_or_of_an_Array
    {
        public int FindKOr(int[] nums, int k)
        {
            var bitCount = new int[32];
            foreach (var num in nums)
            {
                var cur = num;
                var i = 0;
                while (cur > 0)
                {
                    if (cur % 2 == 1) bitCount[i]++;
                    cur = cur >> 1;
                    i++;
                }
            }
            var res = 0;
            for (int i = 0; i < 32; i++)
            {
                if (bitCount[i] >= k)
                {
                    res += 1 << i;
                }
            }
            return res;
        }
    }
}