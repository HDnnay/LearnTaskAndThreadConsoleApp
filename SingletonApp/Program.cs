

using SingletonApp;

#region 单例实现的调用

//Console.WriteLine("第一次调用Singleton");
//Singleton s1 = Singleton.Instance;
//Console.WriteLine("第二次调用Singleton");
//Singleton s2 = Singleton.Instance;
//Console.ReadKey();

#endregion

#region  并发场景下单例非线程安全调用例子，构造函数多次初始化

//ParallelEnumerable.Range(0,1000).ForAll(_ =>
//{
//    ////多线程并发访问下，可能会多次调用构造函数
//    //var reult = Singleton.Instance;
//    //var result = SingletonThreadSafe.Instance;
//    ////Lazy实现的单例
//    var lazyResult =  SingletonImpLazy.Instance;

//});


#endregion

#region 静态函数实现单例模式
//访问静态属性时会调用静态构造函数去构造静态属性初始化
//这里调用静态属性ClassName属性时，并不会触发Instance的初始化
//因为Instance是在内部类Nested类中定义赋值的，只有访问Instance时才会触发Nested类的初始化
var result = SingletonImpStatic.ClassName;
//访问Instance时才会触发Nested类的初始化，从而触发SingletonImpStatic的初始化
var instance = SingletonImpStatic.Instance;

Console.WriteLine(SingletonImpStatic.ClassName);
#endregion



Console.ReadKey();
