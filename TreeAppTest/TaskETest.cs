using NUnit.Framework;
using TreeApp.BO;

namespace TreeAppTest
{
    [TestFixture]
    class TaskETest
    {
        private CompositeTask tasks;

        [SetUp]
        public void Init()
        {
            CompositeTask.applyTaskType.Clear();
            tasks = new CompositeTask();
            tasks.Add(new TaskE());
        }

        [Test]
        public void ShouldReturnOnlyTaskEForTaskE()
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

            Assert.AreEqual(1, CompositeTask.applyTaskType.Count);

        }

    }
}
