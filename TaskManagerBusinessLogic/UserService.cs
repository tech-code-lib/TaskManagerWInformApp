using System.Collections.Generic;
using TaskManagerBusinessLogic.BusinessEntities;
using TaskManagerBusinessLogic.Contract;
using TaskManagerBusinessLogic.DAL;

namespace TaskManagerBusinessLogic
{
    public class UserService : IUserService
    {
        private TaskDb userDb;
        public UserService()
        {
            userDb = new TaskDb();
        }
        public User GetUser(int id)
        {
            User foundUser = null;
            List<User> allUsers = GetAllUsers();
            foreach (User user in allUsers)
            {
                if (user.Id == id)
                {
                    foundUser = user;
                    break;
                }
            }
            return foundUser;
        }

        public List<BaseTask> GetAssignedTasks(int userId)
        {
            return new List<BaseTask>();
        }

        public LoginStatus Login(string userId, string password)
        {
            List<User> users = GetAllUsers();
            foreach (var user in users)
            {
                if (user.UserId == userId && user.Password == password)
                {
                    return new LoginStatus { LoginMessage = "Logged In Successfully.", LoginSuccess = true };
                }
            }
            return new LoginStatus { LoginMessage = "Login failed.", LoginSuccess = false };
        }

        public List<User> GetAllUsers()
        {
            return (new UserDb()).GetUsers();
        }
    }
}
