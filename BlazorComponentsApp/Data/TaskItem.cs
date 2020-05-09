using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentsApp.Data
{
    public class TaskItem
    {
        [Required]
        public string TaskTitle { get; set; }
        public bool IsComplete { get; set; }
    }
}
