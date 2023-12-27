namespace CSharpLeetcode.leetcode;
using System.Threading;
public class ZeroEvenOdd
{
    private int n;
    AutoResetEvent zeroLock;
    AutoResetEvent evenLock;
    AutoResetEvent oddLock;
    public ZeroEvenOdd(int n)
    {
        this.n = n;
        zeroLock = new AutoResetEvent(true);
        evenLock = new AutoResetEvent(false);
        oddLock = new AutoResetEvent(false);
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Zero(Action<int> printNumber)
    {
        for (int i = 1; i <= n; i++)
        {
            zeroLock.WaitOne();
            printNumber(0);
            if (i % 2 == 0)
            {
                evenLock.Set();
            }
            else
            {
                oddLock.Set();
            }
        }
    }

    public void Even(Action<int> printNumber)
    {
        for (int i = 2; i <= n; i += 2)
        {
            evenLock.WaitOne();
            printNumber(i);
            zeroLock.Set();
        }
    }

    public void Odd(Action<int> printNumber)
    {
        for (int i = 1; i <= n; i += 2)
        {
            oddLock.WaitOne();
            printNumber(i);
            zeroLock.Set();
        }
    }
}