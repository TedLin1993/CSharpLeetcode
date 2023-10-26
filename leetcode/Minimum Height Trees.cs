namespace CSharpLeetcode.leetcode
{
    public class Minimum_Height_Trees
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (n == 1) return new List<int> { 0 };
            var graph = new HashSet<int>[n];
            for (int i = 0; i < n; i++) graph[i] = new HashSet<int>();
            foreach (var e in edges)
            {
                graph[e[0]].Add(e[1]);
                graph[e[1]].Add(e[0]);
            }
            var leaf = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (graph[i].Count == 1) leaf.Add(i);
            }
            var remain = n;
            while (remain > 2)
            {
                remain -= leaf.Count;
                var newLeaf = new List<int>();
                foreach (var node in leaf)
                {
                    foreach (var neighbor in graph[node])
                    {
                        graph[neighbor].Remove(node);
                        if (graph[neighbor].Count == 1) newLeaf.Add(neighbor);
                    }
                }
                leaf = newLeaf;
            }
            return leaf;
        }
        public void Test()
        {
            var n = 4;
            var edges = new int[][]
            {
                new int[] {1, 0},
                new int[] {1, 2},
                new int[] {1, 3}
            };
            Console.WriteLine(FindMinHeightTrees(n, edges));
        }
    }
}