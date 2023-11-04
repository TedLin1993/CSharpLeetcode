namespace CSharpLeetcode.leetcode;
public class Daily_Temperatures
{
    public int[] DailyTemperatures(int[] t)
    {
        var stack = new Stack<int>();
        var n = t.Length;
        var res = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && t[i] >= t[stack.Peek()])
            {
                stack.Pop();
            }
            if (stack.Count == 0)
                res[i] = 0;
            else
                res[i] = stack.Peek() - i;
            stack.Push(i);
        }
        return res;
    }
}