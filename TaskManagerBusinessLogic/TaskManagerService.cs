using System;
using System.Collections.Generic;
using TaskManagerBusinessLogic.BusinessEntities;
using TaskManagerBusinessLogic.Contract;
using TaskManagerBusinessLogic.DAL;
using System.Linq;

namespace TaskManagerBusinessLogic
{
    public class TaskManagerService : ITaskManagerService
    {
        TaskDb taskDb;
        public TaskManagerService()
        {
            taskDb = new TaskDb();
        }
        public BaseTask AssignATask(BaseTask task, int userId)
        {
            task.AssignedToId = userId;
            task.SaveTask(taskDb);
            return task;
        }

        public BaseTask CreateATask(string title, string detail, TaskPriority taskPriority, bool internalTask = false)
        {
            BaseTask task = null;
            int newTaskId = GetNewTaskId();
            if (internalTask)
            {

                task = new OrganizationTask(title, detail, newTaskId, taskPriority);
            }
            else
            {
                task = new MarketPlaceTask(title, detail, newTaskId, taskPriority);
            }

            task.CreateTask(taskDb);
            return task;
        }

        private int GetNewTaskId()
        {
            int id = 0;
            var allTasks = GetAllTasks();
            id = (allTasks != null && allTasks.Count() > 0) ? allTasks.OrderByDescending(x => x.TaskId).First().TaskId : 0;
            id++;
            return id; 
        }
        public List<BaseTask> GetAllTasks()
        {
            return taskDb.GetTasks();
        }

        public BaseTask ResolveTask(BaseTask task, string message)
        {            
            task.ResolveTask(message, taskDb);
            return task;
        }

        public BaseTask UpdateStatus(BaseTask task, TaskStatus status)
        {
            task.TaskStatus = status;
            task.SaveTask(taskDb);
            return task;
        }
    }
}
