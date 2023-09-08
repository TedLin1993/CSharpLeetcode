namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>
        {
            new List<int> { 1 }
        };
            for (int i = 1; i < numRows; i++)
            {
                var size = i + 1;
                res.Add(new List<int>(size));
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || j == size - 1)
                    {
                        res[i].Add(1);
                    }
                    else
                    {
                        res[i].Add(res[i - 1][j - 1] + res[i - 1][j]);
                    }
                }
            }
            return res;
        }
    }
}