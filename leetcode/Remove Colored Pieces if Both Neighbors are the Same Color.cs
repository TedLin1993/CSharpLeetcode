namespace CSharpLeetcode.leetcode
{
    public class RemoveColoredPiecesifBothNeighborsaretheSameColor
    {
        public bool WinnerOfGame(string colors)
        {
            var aCount = 0;
            var bCount = 0;
            for (int i = 1; i < colors.Length - 1; i++)
            {
                if (colors[i] == colors[i - 1] && colors[i] == colors[i + 1])
                {
                    if (colors[i] == 'A') aCount++;
                    else bCount++;
                }
            }
            return aCount > bCount;
        }
    }
}