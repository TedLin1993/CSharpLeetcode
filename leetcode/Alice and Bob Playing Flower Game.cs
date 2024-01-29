namespace CSharpLeetcode.leetcode;

public class _3021
{
    public long FlowerGame(int n, int m)
    {
        long xEven = n / 2;
        long xOdd = n % 2 == 1 ? n / 2 + 1 : n / 2;
        long yEven = m / 2;
        long yOdd = m % 2 == 1 ? m / 2 + 1 : m / 2;
        return xEven * yOdd + xOdd * yEven;
    }
}