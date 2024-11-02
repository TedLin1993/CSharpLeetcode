namespace CSharpLeetcode.leetcode;

public class _2409
{
    public bool IsCircularSentence(string sentence)
    {
        var list = sentence.Split(' ');
        for (int i = 1; i < list.Length; i++)
        {
            if (list[i][0] != list[i - 1][^1]) return false;
        }
        return list[^1][^1] == list[0][0];
    }
}