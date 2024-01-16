namespace CSharpLeetcode.leetcode;
class q4
{
    public static int finalInstances(int instances, List<int> averageUtil)
    {
        Console.WriteLine("ins: " + instances);
        var limit = 2 * (int)1e8;
        var cur = 0;
        while (cur < averageUtil.Count)
        {
            if (averageUtil[cur] < 25 && instances > 1)
            {
                if (instances % 2 == 1)
                {
                    instances = instances / 2 + 1;
                }
                else
                {
                    instances /= 2;
                }
                cur += 11;
            }
            else if (averageUtil[cur] > 60 && instances * 2 <= limit)
            {
                instances *= 2;
                cur += 11;
            }
            else
            {
                cur++;
            }
            Console.WriteLine($"i:{cur}, util:{averageUtil[cur]}, inst:{instances}");
        }
        return instances;
    }

}