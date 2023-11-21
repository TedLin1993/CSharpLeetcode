namespace CSharpLeetcode.leetcode;
public class Separate_Black_and_White_Balls
{
    public long MinimumSteps(string s)
    {
        var left = -1;
        long res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                res += i - left - 1;
                left++;
            }
        }
        return res;
    }
}