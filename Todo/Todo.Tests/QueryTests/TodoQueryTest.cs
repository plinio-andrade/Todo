using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTest
    {
        private List<TodoItem> _items;
        public TodoQueryTest()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("New task one", "plinioandrade", DateTime.Now));
            _items.Add(new TodoItem("New task two", "userA", DateTime.Now));
            _items.Add(new TodoItem("New task three", "userB", DateTime.Now));
            _items.Add(new TodoItem("New task four", "plinioandrade", DateTime.Now));
            _items.Add(new TodoItem("New task five", "userC", DateTime.Now));
        }

        [TestMethod]
        public void ShouldReturnOnlyTasksOfUserPlinioAndrade()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("plinioandrade"));
            Assert.AreEqual(2, result.Count());
        }
    }
}
