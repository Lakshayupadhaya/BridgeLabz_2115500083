using System;
using System.Threading;
namespace PerformanceTesting
{
    public class TaskManager
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000);
            return "Task Completed";
        }
    }
}

using NUnit.Framework;
using PerformanceTesting;
namespace PerformanceTests
{
    [TestFixture]
    public class TaskManagerTests
    {
        private TaskManager _taskManager;
        [SetUp]
        public void Setup()
        {
            _taskManager = new TaskManager();
        }
        [Test, Timeout(2000)]
        public void TestLongRunningTask_TimesOut()
        {
            _taskManager.LongRunningTask();
        }
    }
}
