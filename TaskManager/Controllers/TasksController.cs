using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Authentication;
using TaskManager.Tasks;

namespace TaskManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
       
        [HttpPost]
        [Route("CreateTask")]
        public async Task<IActionResult> CreateTask([FromBody] TaskModel model)
        {
            
                ApplicationTask task = new ApplicationTask()
                {
                    TaskName = model.TaskName,
                    Username = model.Username,
                    Deadline = model.Deadline,
                    Detail = model.Detail,
                    Status = model.Status,
                };
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-7Q4NIDE;Initial Catalog=TaskManager;Integrated Security=True";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                string insertQuery = "insert into Tasks(TaskName,Username,Deadline,Detail,Status)values ('" + task.TaskName + "','" + task.Username + "','" + task.Deadline + "','" + task.Detail + "','" + task.Status + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return Ok(new Response { Status = "Success", Message = "Task Created Successfully" });

           
        }
    }
}
