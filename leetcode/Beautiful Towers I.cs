namespace CSharpLeetcode.leetcode
{
    public class Beautiful_Towers_I
    {
        public long MaximumSumOfHeights(IList<int> maxHeights)
        {
            var n = maxHeights.Count;
            long res = 0;
            for (int i = 0; i < n; i++)
            {
                long cur = maxHeights[i];
                var prev = maxHeights[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    var height = Math.Min(maxHeights[j], prev);
                    cur += height;
                    prev = height;
                }
                prev = maxHeights[i];
                for (int j = i + 1; j < n; j++)
                {
                    var height = Math.Min(maxHeights[j], prev);
                    cur += height;
                    prev = height;
                }
                res = Math.Max(res, cur);
            }
            return res;
        }
        public void Test()
        {
            var test = MaximumSumOfHeights(new List<int> { 1000000000, 1000000000, 1000000000 });
            Console.WriteLine(test);
        }
    }
}

