namespace CSharpLeetcode.leetcode
{
    public class String_to_Integer
    {
        public int MyAtoi(string s)
        {
            var idx = 0;
            var n = s.Length;
            while (idx < n)
            {
                if (s[idx] == ' ') idx++;
                else break;
            }
            if (idx == n) return 0;
            double res = 0;
            var isNegative = false;
            if (s[idx] == '-')
            {
                res = -res;
                isNegative = true;
                idx++;
            }
            else if (s[idx] == '+')
            {
                idx++;
            }
            var maxVal = Math.Pow(2, 31);
            while (idx < n)
            {
                if (s[idx] < '0' || s[idx] > '9') break;
                res = res * 10 + (s[idx] - '0');
                if (isNegative && res >= maxVal) return int.MinValue;
                if (!isNegative && res >= maxVal - 1) return int.MaxValue;
                idx++;
            }
            if (isNegative) res = -res;
            return (int)res;
        }
        public void Test()
        {
            Console.WriteLine(MyAtoi("2147483648")); //2147483647
        }
    }
}