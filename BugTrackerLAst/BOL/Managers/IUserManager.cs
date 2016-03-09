using BLToolkit.EditableObjects;
using BOL.Models;
using DAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Managers
{
    public interface IUserManager
    {
        UserModel ActiveModel { get; set; }
        // RightModel Rights { get; set; }
        bool LogIn(string UserName, string UserPassword);
        void Save();
        void SetRights();
        List<UtilityValueModel<uint>> Rights { get; set; }
        EditableList<UserModel> UserList { get; set; }
        void Refresh();
        void Delete(UserModel model);
    }
}
