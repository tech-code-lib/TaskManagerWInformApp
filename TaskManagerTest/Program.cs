using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerBusinessLogic;
using TaskManagerBusinessLogic.BusinessEntities;

namespace TaskManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Internal Task?");
            

            TaskManagerService taskManagerService = new TaskManagerService();
            UserService userService = new UserService();

            

            //Login Method

            var loginStatus = userService.Login("rose@test.com", "Test1234");
            Console.WriteLine($"Login Status: {loginStatus.LoginSuccess}, {loginStatus.LoginMessage}");

            //Create Internal Task
            var taskInternal = taskManagerService.CreateATask("Issue with connecting API.", "Not able to connect production API from my Android app.", TaskPriority.High, false);

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Internal Task created. {taskInternal.TaskId}, {taskInternal.Title}, {taskInternal.Description}");


            //Assign to a User
            //var allUsers = (new UserService()).GetAllUsers();
            
            int userId = 2;

            taskInternal = taskManagerService.AssignATask(taskInternal, userId);

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Internal Task '{taskInternal.Title}' Assigned to  {taskInternal.TaskId}, {taskInternal.AssignedToId}");

            taskManagerService.UpdateStatus(taskInternal, TaskManagerBusinessLogic.BusinessEntities.TaskStatus.InProgress);

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Internal Task '{taskInternal.Title}', Status   {taskInternal.TaskStatus.ToString()}");

            taskManagerService.ResolveTask(taskInternal, "Resolved a tuf task");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Internal Task '{taskInternal.Title}', Status :{taskInternal.TaskStatus.ToString()}");
            Console.ReadLine();

            


        }
    }
}
