namespace CSharpLeetcode.leetcode;

public class _2192
{
    public IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        var graph = new List<int>[n];
        var ancestors = new HashSet<int>[n];
        for (int i = 0; i < n; i++)
        {
            graph[i] = [];
            ancestors[i] = [];
        }

        var inDegree = new int[n];
        foreach (var e in edges)
        {
            graph[e[0]].Add(e[1]);
            inDegree[e[1]]++;
        }

        var queue = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (inDegree[i] == 0) queue.Enqueue(i);
        }
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            foreach (var child in graph[node])
            {
                ancestors[child].Add(node);
                ancestors[child].UnionWith(ancestors[node]);
                inDegree[child]--;
                if (inDegree[child] == 0) queue.Enqueue(child);
            }
        }

        var res = new List<IList<int>>();
        foreach (var anc in ancestors)
        {
            var temp = anc.ToList();
            temp.Sort();
            res.Add(temp);
        }
        return res;
    }
    public void Test()
    {
        GetAncestors(8, [[0, 3], [0, 4], [1, 3], [2, 4], [2, 7], [3, 5], [3, 6], [3, 7], [4, 6]]);
    }
}