using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFancyToDoList.Domain
{
    class SubTaskToDoList : ToDoListItem
    {
        public bool HasSubTask { get; set; }
    }
}
