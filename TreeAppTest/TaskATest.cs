using NUnit.Framework;
using TreeApp.BO;

namespace TreeAppTest
{
    [TestFixture]
    class TaskATest
    {
        private CompositeTask tasks;

        [SetUp]
        public void Init()
        {
            CompositeTask.applyTaskType.Clear();
            tasks = new CompositeTask();
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
        }

        [Test]
        public void ShouldReturnAllTaskForTaskA()
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

            Assert.AreEqual(5, CompositeTask.applyTaskType.Count);
        }

    }
}
