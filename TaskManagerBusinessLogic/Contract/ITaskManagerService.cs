using TaskManagerBusinessLogic.BusinessEntities;

namespace TaskManagerBusinessLogic.Contract
{
    public interface ITaskManagerService
    {
        BaseTask AssignATask(BaseTask task, int userId);
        BaseTask CreateATask(string title, string detail, TaskPriority taskPriority, bool internalTask = false);
        BaseTask UpdateStatus(BaseTask task, TaskStatus status);
        BaseTask ResolveTask(BaseTask task, string message);
    }
}