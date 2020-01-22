using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFancyToDoList.Domain
{
     public class ToDoList
    {
        private List<ToDoListItem> items;

        public ToDoList()
        {
            items = new List<ToDoListItem>();
        }

        public void AddItem(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            items.Add(toDoListItem);
            //items.Add(new ToDoListItem());

        }

        public IEnumerable<ToDoListItem> GetAllItem()  //return all to do items as a list with CRUD
        {
            return items;
        }

        public void RemoveItem(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            items.Remove(toDoListItem);
        }

        public void AddToComplete(ToDoListItem toDoListItem)
        {
            if (toDoListItem is null)
            {
                throw new ArgumentNullException(nameof(toDoListItem));
            }

            if(toDoListItem.IsCompleted == true)
            {

            }

        }


        
    }
}
