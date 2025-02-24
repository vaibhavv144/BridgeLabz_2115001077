using NUnit.Framework;
using ListManagerApp;
using System.Collections.Generic;

namespace ListManagerTest
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager _listManager;
        private List<int> _list;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _list = new List<int> { 1, 2, 3 };
        }

        [Test]
        public void AddElement_ShouldAddElementToList()
        {
            _listManager.AddElement(_list, 4);
            Assert.Contains(4, _list);
        }

        [Test]
        public void RemoveElement_ShouldRemoveElementFromList()
        {
            _listManager.RemoveElement(_list, 2);
            Assert.IsFalse(_list.Contains(2));
        }

        [Test]
        public void GetSize_ShouldReturnCorrectSize()
        {
            int size = _listManager.GetSize(_list);
            Assert.AreEqual(3, size);
        }

        [Test]
        public void AddElement_NullList_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _listManager.AddElement(null, 4));
        }

        [Test]
        public void RemoveElement_NullList_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _listManager.RemoveElement(null, 2));
        }

        [Test]
        public void GetSize_NullList_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _listManager.GetSize(null));
        }
    }
}