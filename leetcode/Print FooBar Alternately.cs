namespace CSharpLeetcode.leetcode;

using System.Threading;
public class FooBar
{
    private int n;
    AutoResetEvent fooEvent;
    AutoResetEvent barEvent;
    public FooBar(int n)
    {
        this.n = n;
        fooEvent = new AutoResetEvent(true);
        barEvent = new AutoResetEvent(false);
    }

    public void Foo(Action printFoo)
    {

        for (int i = 0; i < n; i++)
        {
            fooEvent.WaitOne();
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            barEvent.Set();
        }
    }

    public void Bar(Action printBar)
    {

        for (int i = 0; i < n; i++)
        {
            barEvent.WaitOne();
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();
            fooEvent.Set();
        }
    }
}