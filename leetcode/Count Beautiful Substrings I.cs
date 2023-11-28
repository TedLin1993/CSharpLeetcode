namespace CSharpLeetcode.leetcode;
public class Count_Beautiful_Substrings_I
{
    public int BeautifulSubstrings(string s, int k)
    {
        var n = s.Length;
        var res = 0;
        var vowelSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < n; i++)
        {
            var vowelCount = 0;
            var consCount = 0;
            for (int j = i; j < n; j++)
            {
                if (vowelSet.Contains(s[j]))
                    vowelCount++;
                else
                    consCount++;
                    
                if (vowelCount == consCount && vowelCount * consCount % k == 0)
                    res++;
            }
        }
        return res;

    }
}