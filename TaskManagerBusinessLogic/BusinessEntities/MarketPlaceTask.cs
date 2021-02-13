using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskManagerBusinessLogic.Contract;
using TaskManagerBusinessLogic.DAL;

namespace TaskManagerBusinessLogic.BusinessEntities
{
    public class MarketPlaceTask : BaseTask
    {
        public MarketPlaceTask()
        {
            
        }

        public MarketPlaceTask(string title, string desc, int id, TaskPriority taskPriority) : base(title, desc, id, taskPriority)
        {
            SupplierService = new SupplierService();
        }

        [XmlIgnore]
        public ISupplierService SupplierService 
        { 
            get; set; 
        }
        
        [XmlElement("SupplierService")]
        public ISupplierService SupplierServiceSerializtion { get { return SupplierService; } }
        internal override void ResolveTask(string remarks, TaskDb taskDb)
        {
            base.ResolveTask(remarks, taskDb);
            if (SupplierService == null)
                SupplierService = new SupplierService();
            SupplierService.SendMessage("This issue has been closed and customer has been informed.", this.TaskId);
        }

        internal override void CreateTask(TaskDb taskDb)
        {
            base.CreateTask(taskDb);
            if (SupplierService == null)
                SupplierService = new SupplierService();
            SupplierService.SendMessage($"New Task - '{this.Title}' has been created for you.", this.TaskId);
        }
    }
}
