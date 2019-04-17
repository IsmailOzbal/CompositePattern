using NUnit.Framework;
using TreeApp.BO;

namespace TreeAppTest
{
    [TestFixture]
    class TaskCTest
    {
        private CompositeTask tasks;

        [SetUp]
        public void Init()
        {
            CompositeTask.applyTaskType.Clear();
            tasks = new CompositeTask();
            tasks.Add(new TaskC());
            tasks.Add(new TaskE());
        }

        [Test]
        public void ShouldReturnOnlyTaskE_CForTaskC()
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
