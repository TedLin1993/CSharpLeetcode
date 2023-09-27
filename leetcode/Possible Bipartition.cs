namespace CSharpLeetcode.leetcode
{
    public class Possible_Bipartition
    {
        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            var parent = new int[n + 1];
            var disMap = new List<int>[n + 1];
            for (int i = 0; i <= n; i++)
            {
                parent[i] = i;
                disMap[i] = new List<int>();
            }
            int find(int a)
            {
                if (parent[a] == a) return a;
                parent[a] = find(parent[a]);
                return parent[a];
            }
            void union(int a, int b)
            {
                a = find(a);
                b = find(b);
                if (a == b) return;
                if (a < b)
                {
                    parent[b] = a;
                }
                else
                {
                    parent[a] = b;
                }
            }
            foreach (var dislike in dislikes)
            {
                disMap[dislike[0]].Add(dislike[1]);
                disMap[dislike[1]].Add(dislike[0]);
            }

            for (int i = 1; i <= n; i++)
            {
                foreach (var j in disMap[i])
                {
                    if (find(i) == find(j)) return false;
                    union(disMap[i][0], j);
                }
            }
            return true;
        }
    }
}