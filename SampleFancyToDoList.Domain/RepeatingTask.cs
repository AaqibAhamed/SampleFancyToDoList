using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFancyToDoList.Domain
{
    public class RepeatingTask : ToDoListItem
    {
        
        public DateTime EndTime { get; set; }
        public bool IsReOccuring { get; set; }





    }
}
