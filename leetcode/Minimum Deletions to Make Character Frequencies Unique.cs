namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public int MinDeletions(string s)
        {
            var charCount = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                charCount[s[i] - 'a']++;
            }
            var countMap = new int[s.Length + 1];
            foreach (var count in charCount)
            {
                countMap[count]++;
            }

            var res = 0;
            for (int i = countMap.Length - 1; i > 0; i--)
            {
                if (countMap[i] > 1)
                {
                    var remain = countMap[i] - 1;
                    res += remain;
                    countMap[i - 1] += remain;
                }
            }
            return res;
        }
    }
}