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

        //add an repeating task as completed
        public void RepeatCompleted(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            if (toDoListItem.IsCompleted == true)
            {
                tasks.Add(toDoListItem);
            }
            RepeatingTask repeatingTask = new RepeatingTask();

            if (repeatingTask.EndTime >= DateTime.Now)
            {
                tasks.Remove(toDoListItem);//task remove from completed
                ToDoList toDoList = new ToDoList();
                toDoList.AddItem(toDoListItem);//added to todo list again for next routine
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
                ToDoList toDoList = new ToDoList();
                toDoList.AddItem(toDoListItem);//add that item to todo list again as unfinish task-if a task marked as completed and possible mark as incompleted
            }

        }



    }
}
