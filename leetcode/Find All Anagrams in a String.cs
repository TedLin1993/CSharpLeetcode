namespace CSharpLeetcode.leetcode
{
    public class Find_All_Anagrams_in_a_String
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var sLen = s.Length;
            var pLen = p.Length;
            if (sLen < pLen) return new List<int>();
            var pCount = new int[26];
            var sCount = new int[26];
            for (int i = 0; i < pLen; i++) pCount[p[i] - 'a']++;
            var res = new List<int>();
            for (int i = 0; i < sLen; i++)
            {
                sCount[s[i] - 'a']++;
                if (i >= pLen) sCount[s[i - pLen] - 'a']--;
                if (IsTheSame(pCount, sCount)) res.Add(i - pLen + 1);
            }
            return res;
        }
        bool IsTheSame(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
        public void Test()
        {
            var res = FindAnagrams("cbaebabacd", "abc");
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }
        }
    }
}