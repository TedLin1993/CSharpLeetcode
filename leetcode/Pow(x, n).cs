namespace CSharpLeetcode.leetcode;
public class _50
{
    public double MyPow(double x, int n)
    {
        long nL = n;
        if (n < 0)
        {
            return MyPow(1 / x, -nL);
        }
        return MyPow(x, nL);

    }
    double MyPow(double x, long n)
    {
        double res = 1;
        while (n > 0)
        {
            if (n % 2 == 1) res *= x;
            x *= x;
            n >>= 1;
        }
        return res;
    }
    public void Test()
    {
        Console.WriteLine(MyPow(2.0, -2147483648));
    }
}