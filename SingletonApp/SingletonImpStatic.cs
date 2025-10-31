using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    sealed class SingletonImpStatic
    {
        public static string ClassName;

        public static SingletonImpStatic Instance => Nested.Instance;

        private class Nested
        {
            internal static SingletonImpStatic Instance { get; } = new();

            static Nested() { }
        }

        static SingletonImpStatic()
        {
            //静态构造函数只会调用一次,上述定义静态属性中，如果在外部访问ClassNeme时，Instance不会被初始化
            //只有访问Instance时，才会触发Nested.Instance的初始化,这样的有点在哪里？
            //1.延迟初始化，只有在需要使用时才会初始化,也就是说，如果SingletonImpStatic.ClassName被访问时,如果Instance也会为初始化，
            //那么我们只需要ClassName即可，但是Instance被初始化，可能我们并不用到它，为了避免这样的情况
            //定义了一个内部类Nested去初始化SingletonImpStatic.Instance
            ClassName = nameof(SingletonImpStatic);
        }
    }
}
