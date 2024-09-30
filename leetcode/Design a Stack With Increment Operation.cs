namespace CSharpLeetcode.leetcode;

public class CustomStack
{
    readonly int[] stack;
    int index;
    public CustomStack(int maxSize)
    {
        stack = new int[maxSize];
        index = -1;
    }

    public void Push(int x)
    {
        if (index < stack.Length - 1)
        {
            index++;
            stack[index] = x;
        }
    }

    public int Pop()
    {
        if (index > -1)
        {
            var res = stack[index];
            index--;
            return res;
        }
        return -1;
    }

    public void Increment(int k, int val)
    {
        for (int i = 0; i < k && i <= index; i++)
        {
            stack[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */