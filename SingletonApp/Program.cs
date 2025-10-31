

using SingletonApp;

#region 单例实现的调用

//Console.WriteLine("第一次调用Singleton");
//Singleton s1 = Singleton.Instance;
//Console.WriteLine("第二次调用Singleton");
//Singleton s2 = Singleton.Instance;
//Console.ReadKey();

#endregion

#region  并发场景下单例非线程安全调用例子，构造函数多次初始化

ParallelEnumerable.Range(0,1000).ForAll(_ =>
{
    ////多线程并发访问下，可能会多次调用构造函数
    //var reult = Singleton.Instance;
    var result = SingletonThreadSafe.Instance;

});

#endregion