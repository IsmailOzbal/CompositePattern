using System;

namespace TreeApp.BO
{
    public class TaskC : CompositeTask
    {
        public override void RunTask()
        {
            Console.WriteLine("Task C run succesfully");
        }
    }
}
