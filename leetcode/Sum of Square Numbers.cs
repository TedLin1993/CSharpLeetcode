namespace CSharpLeetcode.leetcode;

public class _633
{
    public bool JudgeSquareSum(int c)
    {
        long left = 0;
        long right = (long)Math.Sqrt(c);
        while (left <= right)
        {
            var sum = left * left + right * right;
            if (sum == c)
            {
                return true;
            }
            else if (sum < c)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return false;
    }

    public void Test()
    {
        Console.WriteLine(JudgeSquareSum(5)); //true
        Console.WriteLine(JudgeSquareSum(3)); //false
        Console.WriteLine(JudgeSquareSum(2147483647)); //false
        Console.WriteLine(JudgeSquareSum(4)); //true
        Console.WriteLine(JudgeSquareSum(0)); //true
    }
}