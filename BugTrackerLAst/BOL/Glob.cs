using BOL.Models;
using DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Glob
    {
        public static UserModel User { get; set; }
        //public static UtilityValueModel<RightModel> Rights { get; set; }     
        public static TaskModel Task { get; set; }
     
    }
}
