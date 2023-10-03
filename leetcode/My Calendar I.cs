namespace CSharpLeetcode.leetcode
{
    public class MyCalendar
    {
        List<(int start, int end)> calendar;
        public MyCalendar()
        {
            calendar = new();
        }

        public bool Book(int start, int end)
        {
            if (calendar.Count == 0)
            {
                calendar.Add((start, end));
                return true;
            }
            var left = 0;
            var right = calendar.Count - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var midBooking = calendar[mid];
                if (end <= midBooking.start)
                {
                    right = mid - 1;
                }
                else if (start >= midBooking.end)
                {
                    left = mid + 1;
                }
                else
                {
                    return false;
                }
            }
            calendar.Insert(left, (start, end));
            return true;
        }
        public void Test()
        {
            var obj = new MyCalendar();
            Console.WriteLine(obj.Book(47, 50));
            Console.WriteLine(obj.Book(33, 41));
            Console.WriteLine(obj.Book(39, 45));
            Console.WriteLine(obj.Book(33, 42));
            Console.WriteLine(obj.Book(25, 32));
            Console.WriteLine(obj.Book(26, 35));
            Console.WriteLine(obj.Book(19, 25));
            Console.WriteLine(obj.Book(3, 8));
            Console.WriteLine(obj.Book(8, 13));
            Console.WriteLine(obj.Book(18, 27));
            //[null,true,true,false,false,true,false,true,true,true,false]
        }
    }
    /**
     * Your MyCalendar object will be instantiated and called as such:
     * MyCalendar obj = new MyCalendar();
     * bool param_1 = obj.Book(start,end);
     */
}