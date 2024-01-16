namespace CSharpLeetcode.leetcode;
class q3
{
    public static List<int> sentTimes(int n, int t, List<int> packetIds)
    {
        int[] res = new int[n];
        int[] portTime = new int[n];
        for (int i = 0; i < packetIds.Count; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (portTime[j] > 0) portTime[j]--;
            }
            var port = packetIds[i] % n;
            for (int j = 0; j < n; j++)
            {
                if (portTime[(port + j) % n] == 0)
                {
                    portTime[(port + j) % n] = t;
                    res[i] = (port + j) % n;
                    break;
                }
            }
        }
        return res.ToList();
    }

}