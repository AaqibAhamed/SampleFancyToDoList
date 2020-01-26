using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFancyToDoList.Domain
{
    class CompletedTasksList
    {
        private List<ToDoListItem> tasks;


        public CompletedTasksList()
        {
            tasks = new List<ToDoListItem>();

        }
        //public void Add(ToDoListItem toDoListItem)
        //{
        //    ToDoList toDoList = new ToDoList();
        //    toDoList.AddItem(toDoListItem);

        //}

        //Add item to completed item list
        public void AddToCompleted(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            if (toDoListItem.IsCompleted == true)
            {
                tasks.Add(toDoListItem);

            }
        }
        //return all completed items as a list with CRUD
        public IEnumerable<ToDoListItem> GetAllCompleted()
        {
            return tasks;
        }


        //Delete finished task from list-permanently 
        public void Delete(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            tasks.Remove(toDoListItem);
        }



        //Mark a completed item as not finished
        public void MarkAsInComplete(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            if (toDoListItem.IsCompleted == false)
            {
                tasks.Remove(toDoListItem);//remove item from completed list -if it is unfinish
                ToDoList toDoList = new ToDoList();//add that item to todo list again as unfinish task-if a task marked as completed and possible mark as incompleted
                toDoList.AddItem(toDoListItem);
            }

        }


    }
}
