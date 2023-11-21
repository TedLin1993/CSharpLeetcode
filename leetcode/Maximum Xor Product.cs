namespace CSharpLeetcode.leetcode;
public class Maximum_Xor_Product
{
    public int MaximumXorProduct(long a, long b, int n)
    {
        var mod = (long)(1e9 + 7);
        for (int i = n - 1; i >= 0; i--)
        {
            long mask = (long)1 << i;
            var aBit = (a >> i) % 2;
            var bBit = (b >> i) % 2;
            if ((aBit == 0 && bBit == 0) ||
                (aBit == 0 && a >> (i + 1) < b >> (i + 1)) ||
                (bBit == 0 && a >> (i + 1) > b >> (i + 1)))
            {
                a ^= mask;
                b ^= mask;
            }
        }
        return (int)(a % mod * (b % mod) % mod);
    }

    public void Test()
    {
        var test = MaximumXorProduct(570713374625622, 553376364476768, 35);
        Console.WriteLine(test); //4832893
    }
}