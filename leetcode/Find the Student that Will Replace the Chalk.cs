namespace CSharpLeetcode.leetcode;

public class _1894
{
    public int ChalkReplacer(int[] chalk, int k)
    {
        var sum = chalk.Sum(v => (long)v);
        var value = k % sum;
        for (int i = 0; i < chalk.Length; i++)
        {
            value -= chalk[i];
            if (value < 0) return i;
        }
        return -1;
    }
}