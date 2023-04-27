using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using taskTrackerBackend.Models;
using taskTrackerBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace taskTrackerBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskTrackerController : ControllerBase
    {
        private readonly TaskTrackerService _data;

        public TaskTrackerController(TaskTrackerService dataFromService){
            _data = dataFromService;
        }

        [HttpPost]
        [Route("AddTaskItem")]
        public bool AddTaskItem(TaskItemModel newTaskItem){
            return _data.AddTaskItem(newTaskItem);
        }

        [HttpGet]
        [Route("GetAllTaskItems")]
        public IEnumerable<TaskItemModel> GetAllTaskItems(){
            return _data.GetAllTaskItems();
        }
    }
}