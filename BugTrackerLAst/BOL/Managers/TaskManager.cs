using BLToolkit.EditableObjects;
using BOL.Models;
using BOL.Repositories;
using DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Managers
{ 
    public interface ITaskManager
    {
        TaskModel ActiveModel { get; set; }
        EditableList<TaskModel> ListModels { get; set; }
        List<UtilityValueModel<uint>> ListPriorities { get; set; }
        List<UtilityValueModel<uint>> ListStatuses { get; set; }
        List<UtilityValueModel<uint>> ListProjects { get; set; }
        void Refresh();
        void SetStatuses();
        void SetPriorities();
        void SetProjects();
        void Save();
        bool IsAdmin();

 
      
    }
    public class TaskManager : ITaskManager
    {
        public TaskModel ActiveModel { get; set; }
        public static ITaskManager Create()
        {
            TaskManager manager = new TaskManager();
            manager.ActiveModel = TaskModel.CreateInstance();
            manager.ListModels = new EditableList<TaskModel>();
            manager.ListPriorities = new List<UtilityValueModel<uint>>();
            manager.ListProjects = new List<UtilityValueModel<uint>>();
            manager.ListStatuses = new List<UtilityValueModel<uint>>();
            
            return manager;
        }

        public static ITaskManager CreateEdit(uint id)
        {
            TaskManager manager = new TaskManager();
            using (var db = Context.Conn())
            {
                manager.ActiveModel = TaskRepository.GetID(db,id);     
            }
            manager.ListModels = new EditableList<TaskModel>();
            manager.ListPriorities = new List<UtilityValueModel<uint>>();
            manager.ListProjects = new List<UtilityValueModel<uint>>();
            manager.ListStatuses = new List<UtilityValueModel<uint>>();
            manager.ActiveModel.AcceptChanges();
            return manager;
        }
        public EditableList<TaskModel> ListModels { get; set; }

        private TaskManager()
        {
        }

        public void Refresh()
        {
            using(var db=Context.Conn())
            {
                this.ListModels.Clear();
                this.ListModels.AddRange(TaskRepository.Get(db));
            }
        }

        public List<UtilityValueModel<uint>> ListStatuses { get; set; }
        public void SetStatuses()
        {
            using (var db = Context.Conn())
            {
                this.ListStatuses.AddRange(TaskRepository.GetStatus(db));
            }
        }

        public List<UtilityValueModel<uint>> ListPriorities { get; set; }
        public void SetPriorities()
        {
            using (var db = Context.Conn())
            {
                this.ListPriorities.AddRange(TaskRepository.GetPriority(db));
            }
        }
        
        public List<UtilityValueModel<uint>> ListProjects { get; set; }
        public void SetProjects()
        {
            using (var db = Context.Conn())
            {
                this.ListProjects.AddRange(TaskRepository.GetProjects(db));             
            }
        }

        public void Save()
        {
            using(var db=Context.Conn())
            {
                TaskRepository.Save(db, this.ActiveModel);
                this.ActiveModel.AcceptChanges();
            }
        }



        public bool IsAdmin()
        {
            using (var db = Context.Conn())
            {
              var isadmin =   UserRepository.GetRights(db);
              foreach (var item in isadmin)
              {
                //  if (item == 9)
                  {
                      
                  }
              }
            }
            return true;
        }
    }
}
