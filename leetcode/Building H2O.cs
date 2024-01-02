namespace CSharpLeetcode.leetcode;

public class H2O
{
    AutoResetEvent oLock;
    AutoResetEvent hLock;
    int hCount;

    public H2O()
    {
        oLock = new AutoResetEvent(false);
        hLock = new AutoResetEvent(true);
        hCount = 0;
    }

    public void Hydrogen(Action releaseHydrogen)
    {
        hLock.WaitOne();
        // releaseHydrogen() outputs "H". Do not change or remove this line.
        releaseHydrogen();
        hCount++;
        if (hCount % 2 == 0)
        {
            oLock.Set();
        }
        else
        {
            hLock.Set();
        }
    }

    public void Oxygen(Action releaseOxygen)
    {
        oLock.WaitOne();
        // releaseOxygen() outputs "O". Do not change or remove this line.
        releaseOxygen();
        hLock.Set();
    }
}