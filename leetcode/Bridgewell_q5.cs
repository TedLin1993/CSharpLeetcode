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
        var maxHeap = new PriorityQueue<string, (string, Data)>(Comparer<(string title, Data data)>.Create((x, y) =>
        {
            if (x.data.num_comments != y.data.num_comments)
                return (int)(y.data.num_comments - x.data.num_comments);
            return string.Compare(y.title, x.title);
        }));
        for (var i = 0; i < totalPage; i++)
        {
            var article = GetArticles(i);
            for (int j = 0; j < article.data.Count; j++)
            {
                if (article.data[j].title == null && article.data[j].story_title == null) continue;
                var title = "";
                if (article.data[j].title != null) title = article.data[j].title;
                else title = article.data[j].story_title;
                if (article.data[j].num_comments == null) article.data[j].num_comments = 0;
                maxHeap.Enqueue(title, (title, article.data[j]));
                if (maxHeap.Count > limit)
                {
                    maxHeap.Dequeue();
                }
            }
        }
        var res = new List<string>();
        for (int i = 0; i < limit && maxHeap.Count > 0; i++)
        {
            res.Add(maxHeap.Dequeue());
        }
        return res;
    }
    public void Test()
    {
        topArticles(50);
    }
}