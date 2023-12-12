namespace CSharpLeetcode.leetcode;
public class Count_Tested_Devices_After_Test_Operations
{
    public int CountTestedDevices(int[] batteryPercentages)
    {
        var res = 0;
        foreach (var b in batteryPercentages)
        {
            if (b - res > 0)
            {
                res++;
            }
        }
        return res;
    }
}