using System;
using System.Collections.Generic;

namespace TreeApp.BO
{
    public  class CompositeTask 
    {
        public List<CompositeTask> _tasks = new List<CompositeTask>();

        public static List<Type> applyTaskType = new List<Type>();

        public CompositeTask(){}

        public void Add(CompositeTask task)
        {
            _tasks.Add(task);
        }

        public void Remove(CompositeTask task)
        {
            _tasks.Remove(task);
        }

        public virtual void RunTask()
        {
            foreach (var item in _tasks)
            {
                if(!applyTaskType.Contains(item.GetType()))
                {
                    item.RunTask();
                    applyTaskType.Add(item.GetType());
                }
             
            }

        }
    }
}
