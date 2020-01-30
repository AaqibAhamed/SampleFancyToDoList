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

            Assert.True(result == 1);

        }

        [Fact]
        public void CheckReOccuring()
        {
            ToDoList toDoList = new ToDoList();

            ToDoListItem toDoListItem = new ToDoListItem();

            RepeatingTask repeatingTask = new RepeatingTask();

            repeatingTask.IsReOccuring = true;

            toDoList.AddReOccuringTask(toDoListItem,repeatingTask);

            var result = toDoList.GetAllTasks().Count();

            Assert.True(result == 1);

        }

        [Fact]
        public void CheckCompletedTask()
        {
            CompletedTasksList completedTasksList = new CompletedTasksList();

            ToDoListItem toDoListItem = new ToDoListItem();

            toDoListItem.IsCompleted = true;

            completedTasksList.AddToCompleted(toDoListItem);

            var result = completedTasksList.GetAllCompleted();
            
            var expect = result.ElementAt(0);

            Assert.Equal(toDoListItem, expect);

        }

        [Fact]
        public void RepeatCompleted()
        {
            RepeatingTask repeatingTask = new RepeatingTask();

            ToDoListItem toDoListItem = new ToDoListItem();

            CompletedTasksList completedTasksList = new CompletedTasksList();

            toDoListItem.IsCompleted = true;

            repeatingTask.EndTime = DateTime.Today.AddDays(+2);

            completedTasksList.RepeatCompleted(toDoListItem,repeatingTask);

            var result = completedTasksList.GetAllCompleted().Count();

            Assert.False(result == 0);


            

           

        }


    }
}
