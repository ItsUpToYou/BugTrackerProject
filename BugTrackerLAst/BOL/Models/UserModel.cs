using BLToolkit.EditableObjects;
using BOL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Models
{
    public abstract class UserModel : EditableObject<UserModel>
    {
        public static UserModel Create()
        {
            UserModel model = UserModel.CreateInstance();
            return model;
        }
        public abstract uint UserID { get; set; }
        public abstract string UserPassword { get; set; }
        public abstract string UserName { get; set; }
        public abstract string FirstName { get; set; }
        public abstract string SecondName { get; set; }
        public abstract string LastName { get; set; }
        public abstract uint RightID { get; set; }
        public abstract string RightName { get; set; }
    }
}
