namespace CSharpLeetcode.leetcode
{
    public class Apply_Operations_to_Make_Two_Strings_Equal
    {
        public int MinOperations(string s1, string s2, int x)
        {
            if (s1 == s2) return 0;
            var n = s1.Length;
            var p = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (s1[i] != s2[i]) p.Add(i);
            }
            if (p.Count % 2 != 0) return -1;
            var dp0 = 0;
            var dp1 = x;
            for (int i = 1; i < p.Count; i++)
            {
                (dp0, dp1) = (dp1, Math.Min(dp1 + x, dp0 + (p[i] - p[i - 1]) * 2));
            }
            return dp1 / 2;
        }
    }
}