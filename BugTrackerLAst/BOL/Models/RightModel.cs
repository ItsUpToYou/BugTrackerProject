using BLToolkit.EditableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public abstract class RightModel : EditableObject<RightModel>
    {
        public static RightModel Create()
        {
            RightModel model = RightModel.CreateInstance();
            return model;
        }
        public abstract uint RightID { get; set; }
        public abstract string RightName { get; set; }
    }
}
