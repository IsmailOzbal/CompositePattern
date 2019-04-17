using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeApp.BO;

namespace TreeAppTest
{
    [TestFixture]
    class TaskBTest
    {
        private CompositeTask tasks;

        [SetUp]
        public void Init()
        {
            CompositeTask.applyTaskType.Clear();
            tasks = new CompositeTask();
            tasks.Add(new TaskB());
            tasks.Add(new TaskD());
        }

        [Test]
        public void ShouldReturnOnlyTaskB_DForTaskB()
        {

            foreach (var item in tasks._tasks)
            {
                if (!CompositeTask.applyTaskType.Contains(item.GetType()))
                {
                    item.RunTask();
                    if (item.GetType().Name != "CompositeTask")
                        CompositeTask.applyTaskType.Add(item.GetType());
                }
            }

            Assert.AreEqual(2, CompositeTask.applyTaskType.Count);

        }

    }
}
