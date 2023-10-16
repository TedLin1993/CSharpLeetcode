namespace CSharpLeetcode.leetcode
{
    public class Shortest_and_Lexicographically_Smallest_Beautiful_String
    {
        public string ShortestBeautifulSubstring(string s, int k)
        {
            var count = 0;
            foreach (var c in s)
            {
                if (c == '1') count++;
            }
            if (count < k) return "";
            var res = s;
            var left = s.IndexOf('1');
            var cur = 0;
            for (int right = left; right < s.Length; right++)
            {
                if (s[right] == '1') cur++;
                if (cur > k)
                {
                    left++;
                    cur--;
                    while (s[left] != '1') left++;
                }
                if (cur == k)
                {
                    var temp = s[left..(right + 1)];
                    if (temp.Length < res.Length || (temp.Length == res.Length && string.Compare(temp, res) < 0))
                    {
                        res = temp;
                    }
                }
            }
            return res;
        }
    }
}