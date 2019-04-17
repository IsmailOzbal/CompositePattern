using System;
using System.Collections.Generic;
using TreeApp.BO;

namespace TreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeTask tasks = new CompositeTask();
            tasks.Add(new TaskA());

            CompositeTask firstchild = new CompositeTask();
            firstchild.Add(new TaskB());
            firstchild.Add(new TaskC());
            tasks.Add(firstchild);

            CompositeTask secondchild = new CompositeTask();
            secondchild.Add(new TaskE());
            tasks.Add(secondchild);

            CompositeTask secondchild2 = new CompositeTask();
            secondchild2.Add(new TaskE());
            secondchild2.Add(new TaskD());
            tasks.Add(secondchild2);

            foreach (var item in tasks._tasks)
            {
                if (!CompositeTask.applyTaskType.Contains(item.GetType()))
                {
                    item.RunTask();
                }

                if (item.GetType().Name != "CompositeTask")
                    CompositeTask.applyTaskType.Add(item.GetType());
            }
        }
    }
}
