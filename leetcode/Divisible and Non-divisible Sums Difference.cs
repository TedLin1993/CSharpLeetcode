namespace CSharpLeetcode.leetcode
{
    public class Divisible_and_Non_divisible_Sums_Difference
    {
        public int DifferenceOfSums(int n, int m)
        {
            var k = n / m;
            return n * (n + 1) / 2 - k * (k + 1) * m;
        }
    }
}
