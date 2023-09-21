namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public class TimeMap
        {
            private Dictionary<string, List<(int timestamp, string value)>> Dict;
            public TimeMap()
            {
                Dict = new Dictionary<string, List<(int timestamp, string value)>>();
            }

            public void Set(string key, string value, int timestamp)
            {
                if (!Dict.ContainsKey(key))
                {
                    Dict.Add(key, new List<(int, string)>());
                }
                Dict[key].Add((timestamp, value));
            }

            public string Get(string key, int timestamp)
            {
                if (!Dict.ContainsKey(key))
                {
                    return string.Empty;
                }
                var list = Dict[key];
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].timestamp <= timestamp)
                    {
                        return list[i].value;
                    }
                }
                return string.Empty;
            }
        }
        public void TestTimeMap()
        {
            var obj = new TimeMap();
            obj.Set("love", "high", 10);
            obj.Set("love", "low", 20);
            Console.WriteLine(obj.Get("love", 5));
        }
    }
}