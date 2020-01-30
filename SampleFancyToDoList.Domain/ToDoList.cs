using System;
using System.Collections.Generic;

namespace SampleFancyToDoList.Domain
{
    public class ToDoList
    {
        private List<ToDoListItem> items;


        public ToDoList()
        {
            items = new List<ToDoListItem>();
        }

        //add an item to todo list
        public void AddItem(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            items.Add(toDoListItem);

        }

        //return all to do items as a list with CRUD-All unfinished tasks 
        public IEnumerable<ToDoListItem> GetAllTasks()
        {
            return items;
        }

        //Remove an item from List-if a task no needed 
        public void RemoveItem(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            items.Remove(toDoListItem);
        }

        //add an repeating or reoccuring task to list
        public void AddReOccuringTask(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            RepeatingTask repeatingTask = new RepeatingTask();
            if (repeatingTask.IsReOccuring == true)
            {
                items.Add(toDoListItem);// #@ this can be merge with add item of to do list  
            }

        }

        public void AddSubTask(ToDoListItem toDoListItem)
        {

            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }


            SubTaskToDoList subTask = new SubTaskToDoList();

            if (subTask.HasSubTask == true)
            {
                items.Add(subTask);
            }





        }





    }
}
