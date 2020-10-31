using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Entities;

namespace Todo.Tests
{
    [TestClass]
    public class TodoItemTest
    {
        private readonly TodoItem _validTodo = new TodoItem("Go to the market", "plinioandrade", DateTime.Now);
        [TestMethod]
        public void GivenANewTodoCannotBeCompleted()
        {
            Assert.AreEqual(_validTodo.Done, false);
        }
    }
}
