namespace CSharpLeetcode.leetcode
{
    public class Count_Valid_Paths_in_a_Tree
    {
        public long CountPaths(int n, int[][] edges)
        {
            var graph = new List<List<int>>();
            for (int i = 0; i < n + 1; i++)
            {
                graph.Add(new List<int>());
            }
            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            var isPrime = new bool[n + 1];
            for (int i = 2; i < n + 1; i++)
            {
                isPrime[i] = true;
            }
            for (int i = 2; i * i < n + 1; i++)
            {
                for (int j = i * i; j < n + 1; j += i)
                {
                    isPrime[j] = false;
                }
            }

            List<int> dfs(int cur, int prev)
            {
                var res = new List<int> { cur };
                foreach (var next in graph[cur])
                {
                    if (!isPrime[next] && next != prev)
                    {
                        res.AddRange(dfs(next, cur));
                    }
                }
                return res;
            }

            long res = 0;
            var size = new int[n + 1];
            for (int i = 1; i < n + 1; i++)
            {
                if (!isPrime[i]) continue;
                var sum = 0;
                foreach (var node in graph[i])
                {
                    if (isPrime[node]) continue;
                    if (size[node] == 0)
                    {
                        var nodes = dfs(node, -1);
                        foreach (var j in nodes)
                        {
                            size[j] = nodes.Count;
                        }
                    }
                    res += size[node] * sum;
                    sum += size[node];
                }
                res += sum;
            }
            return res;
        }
    }
}