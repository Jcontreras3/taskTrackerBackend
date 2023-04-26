using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskTrackerBackend.Models
{
    public class TaskItemModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool isToDo { get; set; }
        public bool isProgress { get; set; }
        public bool isCompleted { get; set; }

        TaskItemModel() { }
    }
}