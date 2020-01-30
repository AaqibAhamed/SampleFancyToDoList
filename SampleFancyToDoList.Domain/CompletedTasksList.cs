using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFancyToDoList.Domain
{
    public class CompletedTasksList
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
        public void RepeatCompleted(ToDoListItem toDoListItem ,RepeatingTask repeatingTask)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            if (toDoListItem.IsCompleted == true)
            {
                tasks.Add(toDoListItem);
            }
            

            if (repeatingTask.EndTime <= DateTime.Now)
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

        //Add a task  as Completed Task which has sub tasks
        public void CompleteSubTask(ToDoListItem toDoListItem,SubTaskToDoList subTaskTo)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            if (toDoListItem.IsCompleted == true & subTaskTo.HasSubTask == false)
            {
                tasks.Add(toDoListItem);
            }

            if(subTaskTo.HasSubTask ==true)
            {
                foreach(var item in subTaskTo.GetAllSubTasks())
                {
                    if(item.IsCompleted == true)
                    {
                        tasks.Add(subTaskTo);//if every sub task items completed only main task consider as completed task
                    }
                }
            }
        }

    }
}
