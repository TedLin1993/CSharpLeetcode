namespace CSharpLeetcode.leetcode
{
    public class Minimum_Processing_Time
    {
        public int MinProcessingTime(IList<int> processorTime, IList<int> tasks)
        {
            var pList = processorTime.ToList();
            pList.Sort();
            var tList = tasks.ToList();
            tList.Sort((t1, t2) => t2 - t1);
            var res = 0;
            for (int i = 0; i < pList.Count; i++)
            {
                res = Math.Max(res, pList[i] + tList[4 * i]);
            }
            return res;
        }
    }
}