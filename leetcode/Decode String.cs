namespace CSharpLeetcode.leetcode;
public class Decode_String
{
    public string DecodeString(string s)
    {
        var res = "";
        var idx = 0;
        while (idx < s.Length)
        {
            var bracketSt = s.IndexOf('[', idx);
            if (bracketSt == -1)
            {
                res += s[idx..];
                break;
            }

            var k = 0;
            for (int i = idx; i < bracketSt; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                    res += s[i];
                else
                {
                    k = int.Parse(s[i..bracketSt]);
                    break;
                }
            }
            var stack = new Stack<int>();
            stack.Push(bracketSt);
            var temp = "";
            idx = bracketSt + 1;
            while (stack.Count > 0)
            {
                if (s[idx] == '[')
                {
                    stack.Push(idx);
                }
                else if (s[idx] == ']')
                {
                    var start = stack.Pop();
                    if (stack.Count == 0)
                    {
                        temp = DecodeString(s[(start + 1)..idx]);
                    }
                }
                idx++;
            }
            for (int i = 0; i < k; i++)
            {
                res += temp;
            }
        }
        return res;
    }
}