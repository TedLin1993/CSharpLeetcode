using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var m = mat.Length;
            var n = mat[0].Length;
            var minHeap = new PriorityQueue<int, (int idx, int sum)>(Comparer<(int idx, int sum)>.Create((x, y) =>
            {
                if (x.sum != y.sum)
                {
                    return x.sum - y.sum;
                }
                return x.idx - y.idx;
            }));
            for (int i = 0; i < m; i++)
            {
                var solCount = 0;
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        solCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                minHeap.Enqueue(i, (i, solCount));
            }
            var res = new int[k];
            for (int i = 0; i < k; i++)
            {
                res[i] = minHeap.Dequeue();
            }
            return res;
        }
        public int[] KWeakestRows_linq(int[][] mat, int k)
        {
            var res = mat
            .Select((m, i) => (sum: m.Sum(), i))
            .OrderBy(x => x.sum)
            .Select(x => x.i)
            .Take(k)
            .ToArray();
            return res;
        }
    }
}