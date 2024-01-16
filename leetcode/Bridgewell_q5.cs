using System.Text.Json;

namespace CSharpLeetcode.leetcode;
class q5
{
    public class Articles
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Data>? data { get; set; }
    }

    public class Data
    {
        public string? title { get; set; }
        public string? url { get; set; }
        public string? author { get; set; }
        public int? num_comments { get; set; }
        public int? story_id { get; set; }
        public string? story_title { get; set; }
        public string? story_url { get; set; }
        public int? parent_id { get; set; }
        public int? created_at { get; set; }
    }
    public static Articles GetArticles(int pageNumber)
    {
        using (var client = new HttpClient())
        {
            var response = client.GetAsync($"https://jsonmock.hackerrank.com/api/articles?page={pageNumber}").Result;
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var articles = JsonSerializer.Deserialize<Articles>(content);
                return articles;
            }
            else
            {
                throw new Exception("HTTP GET 請求失敗");
            }
        }
    }
    public static List<string> topArticles(int limit)
    {
        var first = GetArticles(0);
        var totalPage = first.total_pages;
        var minHeap = new PriorityQueue<string, Data>((IEnumerable<(string Priority, Data Element)>)Comparer<(Data data, string title)>.Create((x, y) =>
        {
            return (int)(x.data.num_comments - y.data.num_comments);
        }), (IComparer<Data>?)StringComparer.Ordinal);
        for (var i = 0; i < totalPage; i++)
        {
            var article = GetArticles(i);
            for (int j = 0; j < article.data.Count; j++)
            {
                if (article.data[j].title == null || article.data[j].story_title == null) continue;
                var title = "";
                if (article.data[j].title != null) title = article.data[j].title;
                else title = article.data[j].story_title;
                if (article.data[j].num_comments == null) article.data[j].num_comments = 0;
                minHeap.Enqueue(title, article.data[j]);
            }
        }
        var res = new List<string>();
        for (int i = 0; i < limit; i++)
        {
            res.Add(minHeap.Dequeue());
        }
        return res;
    }
    public void Test()
    {
        topArticles(5);
    }
}