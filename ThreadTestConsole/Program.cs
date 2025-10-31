// See https://aka.ms/new-console-template for more information
const int total = 100000;
int count = 0;

var thread1 = new Thread(TreadCount);
var thread2 = new Thread(TreadCount);
thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();
Console.WriteLine($"cout:{count}");
Console.ReadKey();

void TreadCount()
{
    for (int  index = 0;   index< total; index ++)
    {
        Interlocked.Increment(ref count);
    }
}
