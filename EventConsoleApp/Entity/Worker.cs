using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventConsoleApp.Entity
{
    public class Worker
    {
        public event EventHandler<WorkEventFormedArgs>? WorkEventFormedHandler;
        public event EventHandler<WorkCompletedEventArgs> WorkCompletedHandler;

        public void DoWork(int hours, WorkType type)
        {
            Console.WriteLine("被调用一次");
            for (int i = 0; i < hours; i++)
            {
                Thread.Sleep(1000);
                OnWorkPerfor(i + 1, type);
            }

            OnWorkCompleted();
        }

        protected virtual void OnWorkCompleted()
        {
            WorkCompletedHandler?.Invoke(this, new WorkCompletedEventArgs(this));
        }

        protected virtual void OnWorkPerfor(int v, WorkType type)
        {
            WorkEventFormedHandler?.Invoke(this, new WorkEventFormedArgs(v, type));
        }
    }
}
