namespace CSharpLeetcode.leetcode;

public class _3044
{
    public int MostFrequentPrime(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        Dictionary<int, int> primeFreq = [];
        int[][] dirs = [[-1, -1], [-1, 0], [-1, 1], [0, -1], [0, 1], [1, -1], [1, 0], [1, 1]];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                foreach (var dir in dirs)
                {
                    var temp = 0;
                    var cur_i = i;
                    var cur_j = j;
                    while (cur_i >= 0 && cur_i < m && cur_j >= 0 && cur_j < n)
                    {
                        temp = temp * 10 + mat[cur_i][cur_j];
                        if (temp > 10 && isPrime(temp))
                        {
                            primeFreq[temp] = primeFreq.GetValueOrDefault(temp) + 1;
                        }
                        cur_i += dir[0];
                        cur_j += dir[1];
                    }
                }
            }
        }
        var res = -1;
        var maxFreq = 0;
        foreach (var kvp in primeFreq)
        {
            if (kvp.Value > maxFreq || (kvp.Value == maxFreq && kvp.Key > res))
            {
                res = kvp.Key;
                maxFreq = kvp.Value;
            }
        }
        return res;
    }
    bool isPrime(int num)
    {
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}