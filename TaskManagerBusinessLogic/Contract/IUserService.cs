using System.Collections.Generic;
using TaskManagerBusinessLogic.BusinessEntities;

namespace TaskManagerBusinessLogic.Contract
{
    public interface IUserService
    {
        List<BaseTask> GetAssignedTasks(int userId);
        User GetUser(int id);
        LoginStatus Login(string userId, string password);
        List<User> GetAllUsers();
    }
}