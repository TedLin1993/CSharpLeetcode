public class Router
{
    record Package(int Src, int Des, int Ts);
    Dictionary<int, List<int>> dictDesTs;
    HashSet<Package> set;
    Queue<Package> queue;
    int limit;

    public Router(int memoryLimit)
    {
        limit = memoryLimit;
        dictDesTs = [];
        set = [];
        queue = [];
    }

    public bool AddPacket(int source, int destination, int timestamp)
    {
        var p = new Package(source, destination, timestamp);
        if (set.Contains(p)) return false;

        if (!dictDesTs.ContainsKey(destination))
        {
            dictDesTs[destination] = [];
        }
        dictDesTs[destination].Add(timestamp);

        set.Add(p);
        queue.Enqueue(p);
        if (queue.Count > limit)
        {
            ForwardPacket();
        }
        return true;
    }

    public int[] ForwardPacket()
    {
        if (queue.Count == 0) return [];
        var p = queue.Dequeue();
        set.Remove(p);
        dictDesTs[p.Des] = dictDesTs[p.Des][1..];
        return [p.Src, p.Des, p.Ts];
    }

    public int GetCount(int destination, int startTime, int endTime)
    {
        var tsList = dictDesTs[destination];
        var idx1 = BinarySearch(tsList, startTime);
        var idx2 = BinarySearch(tsList, endTime + 1);
        return idx2 - idx1;
    }

    int BinarySearch(List<int> list, int time)
    {
        var left = -1;
        var right = list.Count;
        while (left + 1 < right)
        {
            var mid = left + (right - left) / 2;
            if (list[mid] < time)
            {
                left = mid;
            }
            else
            {
                right = mid;
            }
        }
        return right;
    }
}