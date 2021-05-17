using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Tasks
{
    public class ApplicationTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        
        public string Username { get; set; }
      
        public string Deadline { get; set; }
   
        public string Detail { get; set; }

        public string Status { get; set; }
    }
}
