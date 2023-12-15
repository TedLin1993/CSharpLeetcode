namespace CSharpLeetcode.leetcode;

public class Longest_Repeating_Character_Replacement
{
    public int CharacterReplacement(string s, int k)
    {
        var res = 0;
        var charCount = new int[26];
        var left = 0;
        var right = 0;
        var maxFreq = 0;
        while (right < s.Length)
        {
            charCount[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, charCount[s[right] - 'A']);
            while (right - left + 1 - maxFreq > k)
            {
                charCount[s[left] - 'A']--;
                left++;
            }
            res = Math.Max(res, right - left + 1);
            right++;
        }
        return res;
    }
}