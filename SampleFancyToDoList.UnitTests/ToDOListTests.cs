using SampleFancyToDoList.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            var result = toDOList.GetAllItem();

            Assert.Single(result);

            var actualItem = result.ElementAt(0);

            Assert.Equal(itemToAdd, actualItem);


        }

        [Fact]
        public void AddItem_Failed_NullItem()
        {
            ToDoList toDOList = new ToDoList();


            Assert.ThrowsAny<Exception>( () => toDOList.AddItem(null));
        }

        [Fact]
        public void CheckItemRemoved()
        {

        }
            

    }
}
