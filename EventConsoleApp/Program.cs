
using System.Runtime.CompilerServices;
using EventConsoleApp.Entity;


public class Program
{
    public static void Main(string[] args)
    {
        var work = new Worker();
        //先监听监听事件
        work.WorkEventFormedHandler += Work_Preformete;
        work.WorkCompletedHandler += Work_Completed;
        //在调用方法
        work.DoWork(8,WorkType.NetWork);
        
        Console.ReadKey();
    }
    static void Work_Completed(object? sender, WorkCompletedEventArgs e)
    {
        Console.WriteLine("工作完成了！");
        e.Worker.WorkEventFormedHandler -= Work_Preformete;
        e.Worker.WorkCompletedHandler -= Work_Completed;
    }

    static void Work_Preformete(object? sender, WorkEventFormedArgs args)
    {
        Console.WriteLine($"小时数:{args.Hours}  工作类型：{args.WorkType}");
    }
}



