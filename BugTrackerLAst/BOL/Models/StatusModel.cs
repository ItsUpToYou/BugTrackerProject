using BLToolkit.EditableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public abstract class StatusModel : EditableObject<StatusModel>
    {

        public static StatusModel Create()
        {
            StatusModel model = StatusModel.CreateInstance();
            return model;
        }
        public abstract uint StatusID { get; set; }
        public abstract string StatusName { get; set; }
    }
}