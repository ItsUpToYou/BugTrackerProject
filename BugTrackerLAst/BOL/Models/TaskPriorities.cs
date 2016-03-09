using BLToolkit.EditableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public abstract class TaskPriorities : EditableObject<TaskPriorities>
    {
        public static TaskPriorities Create()
        {
            TaskPriorities model = TaskPriorities.CreateInstance();
            return model;
        }

        public abstract uint PriorityID { get; set; }
        public abstract string PriorityName { get; set; }
    }
}
