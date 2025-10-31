namespace EventConsoleApp.Entity
{
    public class WorkEventFormedArgs: EventArgs
    { 
        public int Hours { get; }
        public WorkType WorkType { get; }

        //public WorkEventFormedArgs(int hours,WorkType type)
        //{
        //    Hours = hours;
        //    WorkType = type;
        //}
        public WorkEventFormedArgs(int hours, WorkType type)
        {
            Hours = hours;
            WorkType = type;
        }
    }

    public enum WorkType
    {
        NetWork,
        OutWork,
        ReWork
    }
}