namespace CSharpLeetcode.leetcode;

public class _2561
{
    public long MinCost(int[] basket1, int[] basket2)
    {
        long res = 0;
        var n = basket1.Length;
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            dict[basket1[i]] = dict.GetValueOrDefault(basket1[i]) + 1;
            dict[basket2[i]] = dict.GetValueOrDefault(basket2[i]) - 1;
        }

        var keys = dict.Keys.Order().ToList();
        var costCount = 0;
        foreach (var kvp in dict)
        {
            if (kvp.Value % 2 != 0) return -1;
            costCount += Math.Abs(kvp.Value) / 2;
        }
        var minCost = 2 * keys[0];
        for (int i = 0; i < keys.Count && costCount > 0; i++)
        {
            var k = keys[i];
            var count = Math.Abs(dict[k]);
            var cost = Math.Min(minCost, k);
            if (costCount >= count)
            {
                res += (long)cost * (count / 2);
                costCount -= count;
            }
            else
            {
                res += (long)cost * (costCount / 2);
                costCount = 0;
            }
        }

        return res;
    }

    public void Test()
    {
        Console.WriteLine(MinCost([4, 2, 2, 2], [1, 4, 1, 2])); // 1
    }
}