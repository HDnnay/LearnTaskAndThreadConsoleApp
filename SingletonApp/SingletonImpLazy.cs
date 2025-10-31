using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    sealed class SingletonImpLazy
    {
        private static readonly Lazy<SingletonImpLazy> _lazyInstance = new(() => new SingletonImpLazy());

        public static SingletonImpLazy Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }
        private SingletonImpLazy()
        {
            Console.WriteLine("初始化SingletonImpLazy");
        }
    }
}
