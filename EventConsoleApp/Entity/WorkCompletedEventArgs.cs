using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventConsoleApp.Entity
{
    public class WorkCompletedEventArgs:EventArgs
    {
        public Worker Worker { get;  }

        public WorkCompletedEventArgs(Worker worker)
        {
            Worker = worker;
        }
    }
}
