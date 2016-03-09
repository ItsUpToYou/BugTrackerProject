using BLToolkit.EditableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public abstract class TaskModel : EditableObject<TaskModel>
    {
        public static TaskModel Create()
        {
            TaskModel model = TaskModel.CreateInstance();
            return model;
        }

        public abstract uint TaskID { get; set; }
        public abstract string TaskName { get; set; }
        public abstract string TaskDescription { get; set; }
        public abstract uint ProjectID { get; set; }
        public abstract uint UserID { get; set; }
        public abstract uint PriorityID { get; set; }
        public abstract DateTime TaskDateTimeStart { get; set; }
        public abstract uint StatusID { get; set; }
        public abstract string StatusName { get; set; }
        public abstract string ProjectName { get; set; }
        public abstract string UserName { get; set; }
        public abstract string PriorityName { get; set; }
        public abstract DateTime TaskDateTimeEnd { get; set; }
    }
}
