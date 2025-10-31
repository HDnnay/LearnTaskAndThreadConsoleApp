using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    /// <summary>
    /// 线程安全的单例实现
    /// </summary>
    sealed class SingletonThreadSafe
    {
        private static readonly object _lock = new object();
        private static SingletonThreadSafe _instance = default;
        public static SingletonThreadSafe Instance
        {
            get
            {
                // 双重锁定判断，多线程下每一次加锁导致性能下架，我们只关注第一次初始化，如果为空才加锁
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonThreadSafe();
                        }
                    }
                }
                return _instance;
            }
        }

        private SingletonThreadSafe()
        {
            Console.WriteLine("初始化SingletonThreadSate");
        }
    }
}
