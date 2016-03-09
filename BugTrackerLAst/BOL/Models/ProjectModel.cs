using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLToolkit.Data;
using DAL;
using BLToolkit.EditableObjects;

namespace BOL.Models
{
    public abstract class ProjectModel : EditableObject<ProjectModel>
    {
        public static ProjectModel Create()
        {
            ProjectModel model = ProjectModel.CreateInstance();
            return model;
        }

        public abstract uint ProjectID { get; set; }
        public abstract string ProjectName { get; set; }
        public abstract string ProjectDescription { get; set; }
    }
}
