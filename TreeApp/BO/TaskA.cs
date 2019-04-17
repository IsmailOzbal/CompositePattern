using System;

namespace TreeApp.BO
{
    public class TaskA : CompositeTask
    {
        public override void RunTask()
        {
            Console.WriteLine("Task A run succesfully");
        }
    }
}
