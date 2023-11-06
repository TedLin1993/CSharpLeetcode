namespace CSharpLeetcode.leetcode;
public class Find_Champion_II
{
    public int FindChampion(int n, int[][] edges)
    {
        var isWeaker = new bool[n];
        foreach (var e in edges)
        {
            isWeaker[e[1]] = true;
        }
        var res = -1;
        for (int i = 0; i < n; i++)
        {
            if (!isWeaker[i])
            {
                if (res != -1) return -1;
                res = i;
            }
        }
        return res;
    }
    public void Test()
    {
        FindChampion(4, new int[][]{
            new int[] {0,2},
            new int[] {1,3},
            new int[] {1,2},
        });
    }
}