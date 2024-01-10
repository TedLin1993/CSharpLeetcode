using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode;
public class _2385
{
    public int AmountOfTime(TreeNode root, int start)
    {
        var graph = new Dictionary<int, List<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (!graph.ContainsKey(node.val)) graph.Add(node.val, new List<int>());
            if (node.left != null)
            {
                graph[node.val].Add(node.left.val);
                if (!graph.ContainsKey(node.left.val)) graph.Add(node.left.val, new List<int>());
                graph[node.left.val].Add(node.val);
                queue.Enqueue(node.left);
            }
            if (node.right != null)
            {
                graph[node.val].Add(node.right.val);
                if (!graph.ContainsKey(node.right.val)) graph.Add(node.right.val, new List<int>());
                graph[node.right.val].Add(node.val);
                queue.Enqueue(node.right);
            }
        }
        var visit = new HashSet<int>();
        var queue2 = new Queue<int>();
        queue2.Enqueue(start);
        var res = -1;
        while (queue2.Count > 0)
        {
            var count = queue2.Count;
            for (int i = 0; i < count; i++)
            {
                var cur = queue2.Dequeue();
                visit.Add(cur);
                foreach (var next in graph[cur])
                {
                    if (visit.Contains(next)) continue;
                    queue2.Enqueue(next);
                }
            }
            res++;
        }
        return res;
    }
}