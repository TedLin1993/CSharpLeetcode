using System.Collections.Immutable;

namespace CSharpLeetcode.leetcode
{
    public class Maximum_Odd_Binary_Number
    {
        public string MaximumOddBinaryNumber(string s)
        {
            var n = s.Length;
            var oneCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '1')
                {
                    oneCount++;
                }
            }
            var res = "";
            for (int i = 0; i < oneCount - 1; i++)
            {
                res += "1";
            }
            for (int i = 0; i < n - oneCount; i++)
            {
                res += "0";
            }
            res += "1";
            return res;
        }
    }
}