using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerBusinessLogic.Contract;
using TaskManagerBusinessLogic.DAL;

namespace TaskManagerBusinessLogic
{
    public class SupplierService : ISupplierService
    {
        TaskDb taskDb;
        public SupplierService()
        {
            taskDb = new TaskDb();
        }
        public void SendMessage(string message, int taskId)
        {
            var supplierMessage = new SupplierMessage { TaskId = taskId, Message = message };
            taskDb.SupplierMessage(supplierMessage);
        }

    }
}
