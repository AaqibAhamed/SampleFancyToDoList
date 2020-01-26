using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFancyToDoList.Domain
{
    public class RepeatingTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsReOccuring { get; set; }




    }
}
