namespace CSharpLeetcode.leetcode;

public class _150
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = [];
        foreach (var t in tokens)
        {
            if (t == "+" || t == "-" || t == "*" || t == "/")
            {
                var right = stack.Pop();
                var left = stack.Pop();
                int temp = 0;
                switch (t)
                {
                    case "+":
                        temp = left + right;
                        break;
                    case "-":
                        temp = left - right;
                        break;
                    case "*":
                        temp = left * right;
                        break;
                    case "/":
                        temp = left / right;
                        break;
                }
                stack.Push(temp);
            }
            else
            {
                stack.Push(Convert.ToInt32(t));
            }
        }
        return stack.Pop();
    }
}