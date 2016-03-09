using BLToolkit.Data;
using BOL.Models;
using DAL.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Repositories
{
    public class UserRepository
    {
        public static UserModel Get(DbManager db, uint id)
        {
            string sql =@"SELECT u.UserID,u.UserName,u.UserPassword,u.FirstName,u.SecondName,u.LastName,r.RightName, ur.RightID 
                        FROM  users u 
                        INNER JOIN user_rights ur
                        ON u.UserID = ur.UserID 
                        INNER JOIN rights r 
                        ON ur.RightID = r.RightID   
                        WHERE u.UserID=@UserID";
            db.SetCommand(sql, new MySqlParameter("UserID", id));
            var model = db.ExecuteObject<UserModel>();
            return model;

        }

        public static void Save(DbManager db, UserModel userModel)
        {
            if (userModel.UserID == 0)
            {
                string sql = @"INSERT INTO users (UserName,UserPassword,FirstName,SecondName,LastName) 
                                                    VALUES(@UserName,@UserPassword,@FirstName,@SecondName,@LastName)";
                db.SetCommand(sql,
                    new MySqlParameter("@UserName", userModel.UserName),
                    new MySqlParameter("@UserPassword", userModel.UserPassword),
                    new MySqlParameter("@FirstName", userModel.FirstName),
                    new MySqlParameter("@SecondName",userModel.SecondName),
                    new MySqlParameter("@LastName",userModel.LastName)
                    );
                db.ExecuteNonQuery();
                db.SetCommand("select last_insert_id();");
                userModel.UserID = db.ExecuteScalar<uint>();
               
                string slqRights = "INSERT INTO user_rights (UserID,RightID) VALUES (@UserID,@RightID)";
                db.SetCommand(slqRights,
                db.Parameter("UserID", userModel.UserID),
                db.Parameter("RightID", userModel.RightID));
                db.ExecuteNonQuery();
            }
            else
            {
                string sql = @"UPDATE users u SET   u.UserName=@UserName,
                                                    u.UserPassword=@UserPassword,
                                                    u.FirstName=@FirstName, 
                                                    u.SecondName=@SecondName, 
                                                    u.LastName=@LastName                       
                                                    WHERE UserID = @UserID;";
                db.SetCommand(sql,
                    new MySqlParameter("@UserID",userModel.UserID),
                    new MySqlParameter("@UserName", userModel.UserName),
                    new MySqlParameter("@UserPassword", userModel.UserPassword),
                    new MySqlParameter("@FirstName", userModel.FirstName),
                    new MySqlParameter("@SecondName", userModel.SecondName),
                    new MySqlParameter("@LastName", userModel.LastName)
                    );
                db.ExecuteNonQuery();

                string slqRights = "UPDATE user_rights SET RightID = @RightID WHERE UserID = @UserID";
                db.SetCommand(slqRights,
                db.Parameter("UserID", userModel.UserID),
                db.Parameter("RightID", userModel.RightID));
              
                //string sql1 = @"UPDATE rights r SET r.RightID=@RightID, r.RightName=@RightName";
                //db.SelectCommand(sql1,
                //    new MySqlParameter("@RightName", this.);

                db.ExecuteNonQuery();
            }

        }
        public static UserModel LogIn(DbManager db, string UserName, string UserPassword)
        {
            string sql= @"SELECT u.UserID,u.UserName,u.UserPassword,ur.RightID FROM users u INNER JOIN user_rights ur ON u.UserID=ur.UserID Where UserName=@UserName AND UserPassword=@UserPassword";
            db.SetCommand(sql,
                    db.Parameter("UserName",UserName),
                    db.Parameter("UserPassword",UserPassword)
                    );
            //db.ExecuteNonQuery();
            var model = db.ExecuteObject<UserModel>();
            return model;

        }

        public static List<UtilityValueModel<uint>> GetRights(DbManager db)
        {
            if (db == null)
            throw new ArgumentNullException("db");
            string sql = "SELECT r.RightID AS ValueMember, r.RightName AS DisplayMember FROM rights r";            
            db.SetCommand(sql);
            List<UtilityValueModel<uint>> model = db.ExecuteList<UtilityValueModel<uint>>();
            return model;
        }

        public static List<UserModel> Get(DbManager db)
        {
            string sql = "select u.UserID,u.UserName,u.UserPassword,u.FirstName,u.SecondName,u.LastName,r.RightName FROM users u INNER JOIN rights r INNER JOIN user_rights ur ON u.UserID = ur.UserID AND r.RightID = ur.RightID ";
            db.SetCommand(sql);
            var model = db.ExecuteList<UserModel>();
            return model;
        }

        public static void Delete(DbManager db,uint id)
        {
            if (db == null)
                throw new ArgumentNullException("db");
            string sql="Delete from user_rights Where UserID=@UserID";
            db.SetCommand(sql, new MySqlParameter("UserID",id));
            db.ExecuteNonQuery();

            string sql1 = "Delete from users where UserID=@UserID ";
            db.SetCommand(sql1,new MySqlParameter("UserID",id));
            db.ExecuteNonQuery();
        }

    }
}
