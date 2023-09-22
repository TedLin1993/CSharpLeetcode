namespace CSharpLeetcode.leetcode
{
    public class Is_Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }
            var sIdx = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s[sIdx] == t[i])
                {
                    sIdx++;
                }
                if (sIdx == s.Length)
                {
                    break;
                }
            }
            return sIdx == s.Length;
        }
    }
}

