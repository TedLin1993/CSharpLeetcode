namespace CSharpLeetcode.leetcode;
public class Count_Complete_Substrings
{
    public int CountCompleteSubstrings(string word, int k)
    {
        var res = 0;
        var start = 0;
        while (start < word.Length)
        {
            var end = start;
            for (int j = start + 1; j < word.Length; j++)
            {
                if (Math.Abs(word[j] - word[j - 1]) <= 2)
                {
                    end = j;
                }
                else
                {
                    break;
                }
            }
            res += getComplete(word[start..(end + 1)], k);
            start = end + 1;
        }
        return res;
    }
    int getComplete(string s, int k)
    {
        var res = 0;
        for (int i = 1; i <= 26; i++)
        {
            var size = i * k;
            if (size > s.Length) break;
            var charCount = new int[26];
            for (int j = 0; j < size; j++)
            {
                charCount[s[j] - 'a']++;
            }
            if (charCount.All(x => x == k || x == 0))
            {
                res++;
            }
            for (int j = size; j < s.Length; j++)
            {
                charCount[s[j] - 'a']++;
                charCount[s[j - size] - 'a']--;
                if (charCount.All(x => x == k || x == 0))
                {
                    res++;
                }
            }
        }
        return res;
    }
}