using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskTrackerBackend.Models;
using taskTrackerBackend.Services.Context;
namespace taskTrackerBackend.Services
{
    public class TaskTrackerService
    {
        private readonly DataContext _context;
        public TaskTrackerService(DataContext context){
            _context = context;
        }
         public bool AddTaskItem(TaskItemModel newTaskItem){
            _context.Add(newTaskItem);
            return _context.SaveChanges() != 0;
        }

        public IEnumerable<TaskItemModel> GetAllTaskItems(){
            return _context.TaskInfo;
        }


    }
}