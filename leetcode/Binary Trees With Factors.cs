namespace CSharpLeetcode.leetcode
{
    public class Binary_Trees_With_Factors
    {
        public int NumFactoredBinaryTrees(int[] arr)
        {
            var n = arr.Length;
            var mod = (int)1e9 + 7;
            Array.Sort(arr);

            var valueIdx = new Dictionary<int, int>();
            for (int i = 0; i < n; i++) valueIdx.Add(arr[i], i);

            var dp = new long[n];
            dp[0] = 1;
            for (int i = 1; i < n; i++)
            {
                dp[i] = 1;
                for (int j = 0; arr[j] <= arr[i] / 2; j++)
                {
                    if (arr[i] % arr[j] == 0 && valueIdx.ContainsKey(arr[i] / arr[j]))
                    {
                        var idx = valueIdx[arr[i] / arr[j]];
                        dp[i] += dp[j] * dp[idx] % mod;
                        dp[i] %= mod;
                    }
                }
            }
            long res = 0;
            foreach (var v in dp) res = (res + v) % mod;
            return (int)res;
        }
    }
}