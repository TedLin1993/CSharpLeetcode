namespace CSharpLeetcode.leetcode;

public class _948
{
    public int BagOfTokensScore(int[] tokens, int power)
    {
        var res = 0;
        var score = 0;
        Array.Sort(tokens);
        var left = 0;
        var right = tokens.Length - 1;
        while (left <= right)
        {
            if (power >= tokens[left])
            {
                power -= tokens[left];
                score++;
                res = Math.Max(res, score);
                left++;
            }
            else if (score > 0)
            {
                power += tokens[right];
                right--;
                score--;
            }
            else
            {
                break;
            }
        }
        return res;
    }
}