using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TaskManagerBusinessLogic.BusinessEntities;

namespace TaskManagerBusinessLogic.DAL
{
    public class TaskDb
    {
        public void CreateTask(BaseTask baseTask)
        {
            XmlSerializer xs = default(XmlSerializer);
            string path = $"..\\Db\\tasks\\";
            if (baseTask.GetType() == typeof(MarketPlaceTask))
            {
                xs = new XmlSerializer(typeof(MarketPlaceTask));
                path += "MarketPlaceTask\\";
            }
            else if(baseTask.GetType() == typeof(OrganizationTask))
            {
                xs = new XmlSerializer(typeof(OrganizationTask));
                path += "OrganizationTask\\";
            }
             
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            StreamWriter txtWriter = new StreamWriter($"{path}task_{baseTask.TaskId}.xml");
            xs.Serialize(txtWriter, baseTask);
            txtWriter.Close();
        }

        public void SupplierMessage(SupplierMessage supplierMessage)
        {
            XmlSerializer xs = default(XmlSerializer);
            string path = $"..\\Db\\SupplierMessage\\";
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            var fileName = $"{path}supplierMessage_{supplierMessage.TaskId}_1.xml";
            CheckFileName:
            if (File.Exists(fileName))
            {
                fileName = $"{path}supplierMessage_{supplierMessage.TaskId}_2.xml";
                goto CheckFileName;
            }
                
                
            StreamWriter txtWriter = new StreamWriter(fileName);
            xs = new XmlSerializer(typeof(SupplierMessage));
            xs.Serialize(txtWriter, supplierMessage);
            txtWriter.Close();
        }

        public OrganizationTask GetOrganizationTasks(int id)
        {
            string path = $"..\\Db\\tasks\\OrganizationTask\\";
            XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(OrganizationTask));
            StreamReader file = new StreamReader(
                $"{path}task_{id}.xml");

            OrganizationTask obj = (OrganizationTask) reader.Deserialize(file);
            
            file.Close();
            return obj;
        }

        public MarketPlaceTask GetMarketPlaceTasks(int id)
        {
            string path = $"..\\Db\\tasks\\MarketPlaceTask\\";
            XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(MarketPlaceTask));
            StreamReader file = new StreamReader(
                $"{path}task_{id}.xml");

            MarketPlaceTask obj = (MarketPlaceTask)reader.Deserialize(file);

            file.Close();
            return obj;
        }

        public BaseTask GetTask(int id)
        {
            XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(OrganizationTask));
            StreamReader file = new StreamReader(
                $"..\\Db\\tasks\\task_{id}.xml");
            
            var obj = reader.Deserialize(file);
            BaseTask baseTask = obj as BaseTask;       
            file.Close();
            return baseTask;
        }


        public List<BaseTask> GetTasks()
        {
            Directory.CreateDirectory("..\\Db\\tasks\\OrganizationTask");
            Directory.CreateDirectory("..\\Db\\tasks\\MarketPlaceTask");
            List<BaseTask> tasks = new List<BaseTask>();
            string[] files = Directory.GetFiles("..\\Db\\tasks\\OrganizationTask");            
            Array.Sort(files);            
            foreach (var file in files)
            {
                int taskId;
                int.TryParse(file.Replace("..\\Db\\tasks\\OrganizationTask\\task_", "").Replace(".xml",""), out taskId);
                tasks.Add(GetOrganizationTasks(taskId));
            }

            string[] files2 = Directory.GetFiles("..\\Db\\tasks\\MarketPlaceTask");
            Array.Sort(files2);
            foreach (var file in files2)
            {
                int taskId;
                int.TryParse(file.Replace("..\\Db\\tasks\\MarketPlaceTask\\task_", "").Replace(".xml", ""), out taskId);
                tasks.Add(GetMarketPlaceTasks(taskId));
            }
            return tasks;
        }
    }
}
