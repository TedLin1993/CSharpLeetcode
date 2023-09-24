namespace CSharpLeetcode.leetcode
{
    public class Longest_String_Chain
    {
        public int LongestStrChain(string[] words)
        {
            var n = words.Length;
            Array.Sort(words, (w1, w2) => w1.Length - w2.Length);
            var dp = new int[n];
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (dp[i] < dp[j] + 1 && IsPredecessor(words[j], words[i]))
                    {
                        dp[i] = dp[j] + 1;
                    }
                }
            }
            return dp.Max();
        }
        bool IsPredecessor(string a, string b)
        {
            if (b.Length != a.Length + 1) return false;

            var aIdx = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (a[aIdx] == b[i])
                {
                    aIdx++;
                }
                if (aIdx == a.Length)
                {
                    break;
                }
            }
            return aIdx == a.Length;
        }
    }
}