using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskManagerBusinessLogic.DAL;

namespace TaskManagerBusinessLogic.BusinessEntities
{
    public enum TaskPriority
    {
        High,
        Medium,
        Low
    }
    public enum TaskStatus
    {
        Open,
        InProgress,
        Closed
    }
    
    public abstract class BaseTask
    {
        public BaseTask()
        {

        }

        public BaseTask(string title, string desc, int id, TaskPriority taskPriority)
        {
            this.TaskId = id;
            this.Description = desc;
            this.Title = title;
            this.TaskPriority = taskPriority;
        }
        
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AssignedToId { get; set; }
        public User AssignedTo { get; set; }
        public TaskPriority TaskPriority { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public string ResolutionRemarks { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ClosedDate { get; set; }


        internal virtual void ResolveTask(string remarks, TaskDb taskDb)
        {
            TaskStatus = TaskStatus.Closed;
            ResolutionRemarks = remarks;
            this.ClosedDate = DateTime.Now;
            taskDb.CreateTask(this);
        }

        internal virtual void CreateTask(TaskDb taskDb)
        {
            TaskStatus = TaskStatus.Open;
            this.CreateDate = DateTime.Now;
            taskDb.CreateTask(this);
        }
        internal virtual void SaveTask(TaskDb taskDb)
        {            
            taskDb.CreateTask(this);
        }

    }
}
