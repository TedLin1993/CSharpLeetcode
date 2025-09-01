public class Q2
{
    public int[] MinDifference(int n, int k)
    {
        var diff = 100001;
        var res = new int[0];

        void Dfs(int v, Stack<int> cur, int prev)
        {
            if (cur.Count == k - 1)
            {
                cur.Push(v);
                var max = cur.Max();
                var min = cur.Min();
                if (max - min < diff)
                {
                    diff = max - min;
                    res = [.. cur];
                }
                cur.Pop();
                return;
            }

            for (int i = prev; i * i <= v; i++)
            {
                if (v % i == 0)
                {
                    cur.Push(i);
                    Dfs(v / i, cur, i);
                    cur.Pop();
                }
            }
        }

        Dfs(n, new Stack<int>(), 1);
        return res;
    }

    public void Test()
    {
        MinDifference(44, 3);
    }
}