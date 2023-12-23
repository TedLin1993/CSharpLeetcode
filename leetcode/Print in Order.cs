namespace CSharpLeetcode.leetcode;
using System.Threading;

public class Foo
{
    ManualResetEvent s2;
    ManualResetEvent s3;
    public Foo()
    {
        s2 = new ManualResetEvent(false);
        s3 = new ManualResetEvent(false);
    }

    public void First(Action printFirst)
    {

        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        s2.Set();
    }

    public void Second(Action printSecond)
    {
        s2.WaitOne();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        s3.Set();
    }

    public void Third(Action printThird)
    {
        s3.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}