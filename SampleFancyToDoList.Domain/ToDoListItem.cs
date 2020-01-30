using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SampleFancyToDoList.Domain
{
    public class ToDoListItem
    {

        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        [Display(Name ="Is Completed ")]
        public bool IsCompleted { get; set; }



    }
}
