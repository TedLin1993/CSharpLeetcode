namespace CSharpLeetcode.leetcode;

public class _2463
{
    public long MinimumTotalDistance(IList<int> robot, int[][] factory)
    {
        var robotList = robot.Order().ToList();
        Array.Sort(factory, (a, b) => a[0] - b[0]);

        var m = factory.Length;
        var n = robot.Count;
        var cache = new long[m][];
        for (int i = 0; i < m; i++)
        {
            cache[i] = new long[n];
            for (int j = 0; j < n; j++)
            {
                cache[i][j] = long.MaxValue;
            }
        }

        long dfs(int i, int j)
        {
            if (j >= n) return 0;
            if (cache[i][j] < long.MaxValue) return cache[i][j];

            if (i == m - 1)
            {
                if (factory[i][1] < n - j) return long.MaxValue;
                long sum = 0;
                foreach (var r in robotList[j..])
                {
                    sum += Math.Abs(factory[i][0] - r);
                }
                cache[i][j] = sum;
                return sum;
            }

            long dist = 0;
            var res = dfs(i + 1, j);
            for (int k = 0; k < factory[i][1] && j + k < n; k++)
            {
                dist += Math.Abs(factory[i][0] - robotList[j + k]);
                var next = dfs(i + 1, j + k + 1);
                if (next < long.MaxValue)
                    res = Math.Min(res, dist + next);
            }
            cache[i][j] = res;
            return res;
        }
        var res = dfs(0, 0);
        return res;
    }

    public void Test()
    {
        Console.WriteLine(MinimumTotalDistance([670355988, 403625544, 886437985, 224430896, 126139936, -477101480, -868159607, -293937930],
            [[333473422, 7], [912209329, 7], [468372740, 7], [-765827269, 4], [155827122, 4], [635462096, 2], [-300275936, 2], [-115627659, 0]])); //509199280

        Console.WriteLine(MinimumTotalDistance([789300819, -600989788, 529140594, -592135328, -840831288, 209726656, -671200998],
            [[-865262624, 6], [-717666169, 0], [725929046, 2], [449443632, 3], [-912630111, 0], [270903707, 3], [-769206598, 2], [-299780916, 4], [-159433745, 5], [-467185764, 3], [849991650, 7], [-292158515, 6], [940410553, 6], [258278787, 0], [83034539, 2], [54441577, 3], [-235385712, 2], [75791769, 3]])); //582755368

        Console.WriteLine(MinimumTotalDistance([-333539942, 359275673, 89966494, 949684497, -733065249, 241002388, 325009248, 403868412, -390719486, -670541382, 563735045, 119743141, 323190444, 534058139, -684109467, 425503766, 761908175],
           [[-590277115, 0], [-80676932, 3], [396659814, 0], [480747884, 9], [118956496, 10]])); //582755368

    }
}