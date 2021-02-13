using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskManagerBusinessLogic.BusinessEntities
{
    [Serializable()]
    [XmlRoot(ElementName = "OrganizationTask")]
    public class OrganizationTask : BaseTask
    {
        public OrganizationTask()
        {

        }

        public OrganizationTask(string title, string desc, int id, TaskPriority taskPriority) : base(title, desc, id, taskPriority)
        {

        }

        
    }
}
