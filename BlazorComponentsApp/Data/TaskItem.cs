using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentsApp.Data
{
    public class TaskItem
    {
        [Required(ErrorMessage = "Task Title required.")]
        public string TaskTitle { get; set; }
        public bool IsComplete { get; set; }
    }
}
