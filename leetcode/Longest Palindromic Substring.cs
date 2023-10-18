namespace CSharpLeetcode.leetcode
{
    public class Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {
            var res = "";
            for (int i = 0; i < s.Length; i++)
            {
                var left = i;
                var right = i;
                for (int j = 0; i - j >= 0 && i + j < s.Length; j++)
                {
                    if (s[i - j] == s[i + j])
                    {
                        left = i - j;
                        right = i + j;
                    }
                    else break;
                }
                if (right - left + 1 > res.Length)
                {
                    res = s[left..(right + 1)];
                }

                for (int j = 0; i - j >= 0 && i + j + 1 < s.Length; j++)
                {
                    if (s[i - j] == s[i + j + 1])
                    {
                        left = i - j;
                        right = i + j + 1;
                    }
                    else break;
                }
                if (right - left + 1 > res.Length)
                {
                    res = s[left..(right + 1)];
                }
            }
            return res;
        }
    }
}