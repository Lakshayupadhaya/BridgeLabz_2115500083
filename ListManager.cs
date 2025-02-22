using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Qn3
{
    public class ListManager
    {
        public void AddElement(List<int> list, int element)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            list.Add(element);
        }

        public bool RemoveElement(List<int> list, int element)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            return list.Remove(element);
        }

        public int GetSize(List<int> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            return list.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qn3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListManager listManager = new ListManager();
            List<int> list = new List<int>();
            listManager.AddElement(list, 1);
            listManager.AddElement(list, 2);
            listManager.AddElement(list, 3);
            listManager.AddElement(list, 4);
            listManager.AddElement(list, 5);
            Console.WriteLine("Size of list: " + listManager.GetSize(list));
            listManager.RemoveElement(list, 3);
            Console.WriteLine("Size of list after removing element: " + listManager.GetSize(list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Qn3;
namespace ListManagerTests
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager List;
        private List<int> Test;

        [SetUp]
        public void Setup()
        {
            List = new ListManager();
            Test = new List<int>();
        }

        [Test]
        public void TestAddElement()
        {
            List.AddElement(Test, 5);
            Assert.That(Test, Contains.Item(5));
        }

        [Test]
        public void TestRemoveElement()
        {
            List.AddElement(Test, 10);
            bool removed = List.RemoveElement(Test, 10);

            Assert.That(removed, Is.True);
            Assert.That(Test, Does.Not.Contain(10));
        }

        [Test]
        public void TestGetSize()
        {
            List.AddElement(Test, 1);
            List.AddElement(Test, 2);
            List.AddElement(Test, 3);

            int size = List.GetSize(Test);
            Assert.That(size, Is.EqualTo(3));
        }

        [Test]
        public void TestRemoveElement_NotInList()
        {
            bool removed = List.RemoveElement(Test, 99);
            Assert.That(removed, Is.False);
        }

        [Test]
        public void TestNullList_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => List.AddElement(null, 1));
            Assert.Throws<ArgumentNullException>(() => List.RemoveElement(null, 1));
            Assert.Throws<ArgumentNullException>(() => List.GetSize(null));
        }
    }
}
