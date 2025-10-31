using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    /// <summary>
    /// 单例是实现，非线程安全
    /// </summary>
    sealed class Singleton
    {
        private static Singleton _instance=default;

        public static Singleton Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        private Singleton()
        {
            Console.WriteLine("初始化Singleton");
        }
    }
}
