using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaskManagerBusinessLogic.BusinessEntities;

namespace TaskManagerBusinessLogic.DAL
{
    public class UserDb
    {
        public List<User> GetUsers()
        {
            string path = $"DAL\\Data\\Users.xml";
            XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Users));
            StreamReader file = new StreamReader(path);            

            var obj =(Users) reader.Deserialize(file);

            file.Close();
            return obj;
        }
    }
}
