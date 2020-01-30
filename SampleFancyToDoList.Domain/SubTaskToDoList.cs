using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFancyToDoList.Domain
{
    public class SubTaskToDoList : ToDoListItem
    {
        public bool HasSubTask { get; set; }

        private List<SubTaskToDoList> subTasks;

        public SubTaskToDoList()
        {
            subTasks = new List<SubTaskToDoList>();
        }

        //add an item to todo list
        public void AddItem(SubTaskToDoList subTaskToDo)
        {
            if (subTaskToDo is null)
            {
                throw new ArgumentNullException(nameof(subTaskToDo));
            }

            subTasks.Add(subTaskToDo);

        }

        public IEnumerable<SubTaskToDoList> GetAllSubTasks()
        {
            return subTasks;
        }
    }
}
