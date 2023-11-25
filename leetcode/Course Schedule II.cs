namespace CSharpLeetcode.leetcode;
public class Course_Schedule_II
{
    public int[] FindOrder(int n, int[][] preR)
    {
        var preCount = new int[n];
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++) graph[i] = new List<int>();
        foreach (var p in preR)
        {
            preCount[p[0]]++;
            graph[p[1]].Add(p[0]);
        }

        var queue = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (preCount[i] == 0) queue.Enqueue(i);
        }
        var res = new List<int>();
        while (queue.Count > 0)
        {
            var course = queue.Dequeue();
            res.Add(course);
            foreach (var c in graph[course])
            {
                preCount[c]--;
                if (preCount[c] == 0) queue.Enqueue(c);
            }
        }
        return res.Count == n ? res.ToArray() : new int[0];
    }
}