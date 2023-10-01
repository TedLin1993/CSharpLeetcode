using System.Text;

namespace CSharpLeetcode.leetcode
{
    public class ReverseWordsinaStringIII
    {
        public string ReverseWords(string s)
        {
            var sb = new StringBuilder();
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        sb.Append(stack.Pop());
                    }
                    sb.Append(" ");
                }
            }
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
            return sb.ToString();
        }
    }
}