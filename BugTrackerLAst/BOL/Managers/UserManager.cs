using BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Repositories;
using DAL.Core;
using BLToolkit.Data;
using BLToolkit.EditableObjects;
namespace BOL.Managers
{
    public class UserManager : IUserManager
    {

        public UserModel ActiveModel { get; set; }
        public List<UtilityValueModel<uint>> Rights { get; set; }

        public EditableList<UserModel> UserList { get; set; }
        private UserManager()
        {

        }

        public static IUserManager CreateLogin()//to6ko
        {
            return new UserManager();
        }
        public static IUserManager CreateNew()
        {
            UserManager manager = new UserManager();
            manager.ActiveModel = UserModel.CreateInstance();
            manager.ActiveModel.AcceptChanges();
            manager.Rights = new List<UtilityValueModel<uint>>();
            manager.UserList = new EditableList<UserModel>();
            return manager;
        }

        //public static IUserManager CreatUserList()
        //{
        //    UserManager manager = new UserManager();
        //    manager.ActiveModel = UserModel.CreateInstance();
        //    manager.ActiveModel.AcceptChanges();

        //}
        public static IUserManager CreateEdit(uint id)
        {
            UserManager manager = new UserManager();
            manager.UserList = new EditableList<UserModel>();
            using (var db = Context.Conn())
            {
                manager.ActiveModel = UserRepository.Get(db, id);

            }
            manager.ActiveModel.AcceptChanges();
            manager.Rights = new List<UtilityValueModel<uint>>();
            return manager;
        }
        public void Save()
        {
            using (var db = Context.Conn())
            {
                UserRepository.Save(db, this.ActiveModel);
                this.ActiveModel.AcceptChanges();

            }
        }
        /// <summary>
        /// Запазва към БД новосъздадения запис
        /// </summary>
        public bool LogIn(string UserName, string UserPassword)
        {
            using (var db = Context.Conn())
            {

                Glob.User = UserRepository.LogIn(db, UserName, UserPassword);
                if (Glob.User == null)
                {
                    Glob.User = ActiveModel;
                    return false;
                }
            }
            return true;
        }

        public void SetRights()
        {
            // this.Rights.Clear();
            using (var db = Context.Conn())
            {
                //this.Rights.Clear();
                this.Rights.AddRange(UserRepository.GetRights(db));

            }
        }
        public void Refresh()
        {
            using (var db = Context.Conn())
            {
                this.UserList.Clear();
                this.UserList.AddRange(UserRepository.Get(db));
            }

        }
        public void Delete(UserModel model)
        {


            using (var db = Context.Conn())
            {
                UserRepository.Delete(db, model.UserID);
                this.UserList.Remove(model);

            }
            this.Refresh();
        }

    }
}
