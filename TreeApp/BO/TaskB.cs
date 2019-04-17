using System;

namespace TreeApp.BO
{
    public class TaskB : CompositeTask
    {
        public override void RunTask()
        {
            Console.WriteLine("Task B run succesfully");
        }
    }
}
