using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Tasks
{
    public class TaskModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Task Name is required")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Deadline is required")]
        public string Deadline { get; set; }
        [Required(ErrorMessage = "Detail is required")]
        public string Detail { get; set; }
        public string Status { get; set; }
        
    }
}
