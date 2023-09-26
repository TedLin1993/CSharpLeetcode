namespace CSharpLeetcode.leetcode
{
    public class Beautiful_Towers_II
    {
        public long MaximumSumOfHeights(IList<int> maxHeights)
        {
            var n = maxHeights.Count;
            var stack = new Stack<int>();
            stack.Push(n);
            var suf = new long[n + 1];
            long cur = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                while (stack.Count > 1 && maxHeights[i] <= maxHeights[stack.Peek()])
                {
                    var j = stack.Pop();
                    cur -= (long)maxHeights[j] * (stack.Peek() - j);
                }
                cur += (long)maxHeights[i] * (stack.Peek() - i);
                suf[i] = cur;
                stack.Push(i);
            }

            stack = new Stack<int>();
            stack.Push(-1);
            var pre = new long[n];
            cur = 0;
            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 1 && maxHeights[i] <= maxHeights[stack.Peek()])
                {
                    var j = stack.Pop();
                    cur -= (long)maxHeights[j] * (j - stack.Peek());
                }
                cur += (long)maxHeights[i] * (i - stack.Peek());
                pre[i] = cur;
                stack.Push(i);
            }

            long res = 0;
            for (int i = 0; i < n; i++)
            {
                res = Math.Max(res, pre[i] + suf[i + 1]);
            }
            return res;
        }
        public void Test()
        {
            var test = MaximumSumOfHeights(new List<int> { 1000000000, 1000000000, 1000000000 }); //3000000000
            Console.WriteLine(test);
            test = MaximumSumOfHeights(new List<int> { 5, 3, 4, 1, 1 }); //13
            Console.WriteLine(test);
        }
    }
}

