namespace CSharpLeetcode.leetcode;

public class _787
{
    record flightPrice(int To, int Price);
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        Dictionary<int, List<flightPrice>> graph = [];
        for (int i = 0; i < n; i++) graph[i] = [];
        foreach (var f in flights)
        {
            graph[f[0]].Add(new flightPrice(f[1], f[2]));
        }
        var costs = new int[n];
        Array.Fill(costs, int.MaxValue);
        costs[src] = 0;
        Queue<int> queue = [];
        queue.Enqueue(src);
        while (queue.Count > 0 && k >= 0)
        {
            var temp = (int[])costs.Clone();
            var count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                var city = queue.Dequeue();
                foreach (var fp in graph[city])
                {
                    if (costs[city] + fp.Price < temp[fp.To])
                    {
                        temp[fp.To] = costs[city] + fp.Price;
                        queue.Enqueue(fp.To);
                    }
                }
            }
            costs = temp;
            k--;
        }
        return costs[dst] == int.MaxValue ? -1 : costs[dst];
    }
}