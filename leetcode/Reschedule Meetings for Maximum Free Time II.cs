namespace CSharpLeetcode.leetcode;

public class _3440
{
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        var n = startTime.Length;

        var empty1 = startTime[0] - 0;
        var empty2 = eventTime - endTime[n - 1];
        var empty3 = 0;
        if (empty2 > empty1) (empty1, empty2) = (empty2, empty1);
        for (int i = 1; i < startTime.Length; i++)
        {
            var prevEmpty = startTime[i] - endTime[i - 1];
            if (prevEmpty > empty1)
            {
                (empty1, empty2, empty3) = (prevEmpty, empty1, empty2);
            }
            else if (prevEmpty > empty2)
            {
                (empty2, empty3) = (prevEmpty, empty2);
            }
            else if (prevEmpty > empty3)
            {
                empty3 = prevEmpty;
            }
        }

        var res = 0;
        for (int i = 0; i < startTime.Length; i++)
        {
            var leftSpace = 0;
            if (i != 0) leftSpace = startTime[i] - endTime[i - 1];
            else leftSpace = startTime[i];

            var rightSpace = 0;
            if (i < startTime.Length - 1) rightSpace = startTime[i + 1] - endTime[i];
            else rightSpace = eventTime - endTime[i];

            var occupySpace = endTime[i] - startTime[i];
            if (occupySpace <= empty3)
            {
                res = Math.Max(res, leftSpace + occupySpace + rightSpace);
            }
            else if (occupySpace > empty1)
            {
                res = Math.Max(res, leftSpace + rightSpace);
            }
            else if (occupySpace <= empty2)
            {
                if (leftSpace >= empty2 && rightSpace >= empty2)
                {
                    res = Math.Max(res, leftSpace + rightSpace);
                }
                else
                {
                    res = Math.Max(res, leftSpace + occupySpace + rightSpace);
                }
            }
            else
            {
                if (leftSpace == empty1 || rightSpace == empty1)
                {
                    res = Math.Max(res, leftSpace + rightSpace);
                }
                else
                {
                    res = Math.Max(res, leftSpace + occupySpace + rightSpace);
                }
            }
        }

        return res;
    }
}