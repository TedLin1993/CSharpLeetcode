namespace CSharpLeetcode.leetcode;

public class _735
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();
        foreach (var a in asteroids)
        {
            if (a > 0)
            {
                stack.Push(a);
            }
            else
            {
                while (stack.Count > 0 &&
                    stack.Peek() > 0 &&
                    Math.Abs(a) > Math.Abs(stack.Peek()))
                {
                    stack.Pop();
                }
                if (stack.Count == 0 || stack.Peek() < 0)
                {
                    stack.Push(a);
                }
                else if (Math.Abs(a) == Math.Abs(stack.Peek()))
                {
                    stack.Pop();
                }
            }
        }
        return stack.Reverse().ToArray();
    }
}