namespace CSharpLeetcode.leetcode;

public class _3005
{
    public int MaxFrequencyElements(int[] nums)
    {
        var res = 0;
        var freqDict = new Dictionary<int, int>();
        var maxFreq = 0;
        foreach (var v in nums)
        {
            if (!freqDict.ContainsKey(v)) freqDict[v] = 0;
            freqDict[v]++;
            if (freqDict[v] > maxFreq)
            {
                res = freqDict[v];
                maxFreq = freqDict[v];
            }
            else if (freqDict[v] == maxFreq)
            {
                res += freqDict[v];
            }
        }
        return res;
    }

}