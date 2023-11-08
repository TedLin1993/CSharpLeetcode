namespace CSharpLeetcode.leetcode;
public class Gas_Station
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var n = gas.Length;
        var start = 0;
        var gasTotal = 0;
        var costTotal = 0;
        var cur = 0;
        for (int i = 0; i < n; i++)
        {
            gasTotal += gas[i];
            costTotal += cost[i];
            cur += gas[i] - cost[i];
            if (cur < 0)
            {
                start = i + 1;
                cur = 0;
            }
        }
        return gasTotal >= costTotal ? start : -1;
    }
}