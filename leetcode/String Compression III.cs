using System.Text;

namespace CSharpLeetcode.leetcode;

public class _3163
{
    public string CompressedString(string word)
    {
        var sb = new StringBuilder();
        var count = 1;
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                count++;
                if (count == 10)
                {
                    sb.Append($"9{word[i - 1]}");
                    count = 1;
                }
            }
            else
            {
                sb.Append($"{count}{word[i - 1]}");
                count = 1;
            }
        }
        sb.Append($"{count}{word[^1]}");
        return sb.ToString();
    }
}