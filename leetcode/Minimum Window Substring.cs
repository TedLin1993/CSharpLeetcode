namespace CSharpLeetcode.leetcode;

public class _76
{
    public string MinWindow(string s, string t)
    {
        var m = s.Length;
        var n = t.Length;
        var tCharMap = new Dictionary<char, int>();
        foreach (var c in t)
        {
            if (!tCharMap.ContainsKey(c))
            {
                tCharMap[c] = 0;
            }
            tCharMap[c]++;
        }
        var left = 0;
        var minLeft = 0;
        var minLength = s.Length + 1;
        var tCount = 0;
        for (int right = 0; right < m; right++)
        {
            var c = s[right];
            if (!tCharMap.ContainsKey(c)) continue;
            tCharMap[c]--;
            if (tCharMap[c] >= 0) tCount++;
            while (tCount == n)
            {
                if (right - left + 1 < minLength)
                {
                    minLeft = left;
                    minLength = right - left + 1;
                }
                if (tCharMap.ContainsKey(s[left]))
                {
                    tCharMap[s[left]]++;
                    if (tCharMap[s[left]] > 0) tCount--;
                }
                left++;
            }
        }
        return minLength > s.Length ? string.Empty : s.Substring(minLeft, minLength);
    }
    public void Test()
    {
        var test = MinWindow("abc", "cba");
        Console.WriteLine(test); //abc
    }
}