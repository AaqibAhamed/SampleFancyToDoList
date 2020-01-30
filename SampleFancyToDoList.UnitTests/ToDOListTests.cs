using SampleFancyToDoList.Domain;
using System;
using System.Linq;
using Xunit;

namespace SampleFancyToDoList.UnitTests
{
    public class ToDOListTests

    {
        [Fact]
        public void AddItem()
        {
            ToDoList toDOList = new ToDoList();

            ToDoListItem itemToAdd = new ToDoListItem();

            toDOList.AddItem(itemToAdd);

            var result = toDOList.GetAllTasks();

            Assert.Single(result);

            var actualItem = result.ElementAt(0);

            Assert.Equal(itemToAdd, actualItem);

        }

        [Fact]
        public void AddItem_Failed_NullItem()
        {
            ToDoList toDOList = new ToDoList();


            Assert.ThrowsAny<Exception>(() => toDOList.AddItem(null));
        }

        [Fact]
        public void CheckItemRemoved()
        {
            ToDoList toDoList = new ToDoList();

            ToDoListItem itemToRemove = new ToDoListItem();

            ToDoListItem toDoListItem2 = new ToDoListItem();

             toDoList.AddItem(toDoListItem2);

             toDoList.AddItem(itemToRemove);

            toDoList.RemoveItem(itemToRemove);

            var result = toDoList.GetAllTasks().Count();

            Assert.True(result == 0);

        }

        [Fact]
        public void CheckReOccuring()
        {
            ToDoList toDoList = new ToDoList();

            ToDoListItem toDoListItem = new ToDoListItem();

            toDoList.AddReOccuringTask(toDoListItem);

        }

        [Fact]
        public void CheckCompletedTask()
        {
            CompletedTasksList completedTasksList = new CompletedTasksList();

            ToDoListItem toDoListItem = new ToDoListItem();

            completedTasksList.AddToCompleted(toDoListItem);

        }

    }
}
