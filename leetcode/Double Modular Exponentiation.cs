namespace CSharpLeetcode.leetcode;

public class Double_Modular_Exponentiation
{
    public IList<int> GetGoodIndices(int[][] variables, int target)
    {
        var res = new List<int>();
        for (int i = 0; i < variables.Length; i++)
        {
            var a = variables[i][0];
            var b = variables[i][1];
            var c = variables[i][2];
            var m = variables[i][3];

            var ab = a;
            for (int j = 1; j < b; j++)
            {
                ab = ab * a % 10;
            }
            ab %= 10;

            var abc = ab;
            for (int j = 1; j < c; j++)
            {
                abc = abc * ab % m;
            }
            abc %= m;
            if (abc == target) res.Add(i);
        }
        return res;
    }
}