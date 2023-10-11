namespace CSharpLeetcode.leetcode
{
    public class ApplyOperationsonArraytoMaximizeSumofSquares
    {
        public int MaxSum(IList<int> nums, int k)
        {
            var bitCount = new int[32];
            foreach (var num in nums)
            {
                var i = 0;
                var v = num;
                while (v > 0)
                {
                    bitCount[i] += v % 2;
                    v = v >> 1;
                    i++;
                }
            }
            var res = 0;
            var mod = (int)1e9 + 7;
            for (int i = 0; i < k; i++)
            {
                long temp = 0;
                for (int j = 0; j < bitCount.Length; j++)
                {
                    if (bitCount[j] > 0)
                    {
                        temp += 1 << j;
                        bitCount[j]--;
                    }
                }
                temp = temp * temp % mod;
                res = (res + (int)temp) % mod;
            }
            return res;
        }
        public void Test()
        {
            Console.WriteLine(MaxSum(new List<int> { 2, 6, 5, 8 }, 2)); //261
        }
    }
}