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
    public class TaskRepository
    {
        public static List<TaskModel> Get(DbManager db)
        {
            string sql = @"SELECT t. TaskName, t.TaskDescription, t.TaskDateTimeStart, s.StatusName, p.PriorityName, p1.ProjectName,u.UserName 
                            FROM bugtracker.tasks t
                              INNER JOIN statuses s ON t.StatusID = s.StatusID
                              INNER JOIN priorities p ON t.PriorityID = p.PriorityID
                              INNER JOIN projects p1 ON t.ProjectID = p1.ProjectID 
                              INNER JOIN users u ON u.UserID=t.UserID";
            db.SetCommand(sql);
            db.ExecuteNonQuery();
            var model = db.ExecuteList<TaskModel>();
            return model;
        }
        public static TaskModel GetID(DbManager db, uint id)
        {
            string sql = "SELECT * FROM tasks t WHERE t.TaskID=@TaskID";
            db.SetCommand(sql,
                new MySqlParameter("@TaskID",id));
            db.ExecuteNonQuery();
            var model = db.ExecuteObject<TaskModel>();
            return model;

        }

        public static List<UtilityValueModel<uint>> GetStatus(DbManager db)
        {
            if (db == null)
            {
                throw new ArgumentNullException("db");
            }
            string sql = "Select s.StatusID as ValueMember, s.StatusName as DisplayMember FROM statuses s";
            db.SetCommand(sql);
            var model = db.ExecuteList<UtilityValueModel<uint>>();
            return model;
        }

        public static List<UtilityValueModel<uint>> GetPriority(DbManager db)
        {
            if (db == null)
            {
                throw new ArgumentNullException("db");
            }
            string sql = "Select p.PriorityID as ValueMember, p.PriorityName as DisplayMember FROM priorities p";
            db.SetCommand(sql);
            var model = db.ExecuteList<UtilityValueModel<uint>>();
            return model;
        }

        public static List<UtilityValueModel<uint>> GetProjects(DbManager db)
        {
            if (db == null)
            {
                throw new ArgumentNullException("db");
            }
            string sql = "Select p.ProjectID as ValueMember, p.ProjectName as DisplayMember FROM projects p";
            db.SetCommand(sql);
            var model = db.ExecuteList<UtilityValueModel<uint>>();
            return model;
        }
        public static void Save(DbManager db, TaskModel taskModel)
        {
            if(taskModel.TaskID==0)
            {
                string sql = @"INSERT INTO tasks( TaskName, TaskDescription, ProjectID, UserID, PriorityID, TaskDateTimeStart, StatusID,TaskDateTimeEnd)
                                      VALUES (@TaskName,@TaskDescription,@ProjectID,@UserID,@PriorityID,@TaskDateTimeStart,@StatusID,@TaskDateTimeEnd);";
                db.SetCommand(sql,
                    new MySqlParameter("@TaskName", taskModel.TaskName),
                    new MySqlParameter("@TaskDescription", taskModel.TaskDescription),
                    new MySqlParameter("@ProjectID", taskModel.ProjectID),
                    new MySqlParameter("@UserID", taskModel.UserID),
                    new MySqlParameter("@PriorityID", taskModel.PriorityID),
                    new MySqlParameter("@TaskDateTimeStart", taskModel.TaskDateTimeStart),
                    new MySqlParameter("@StatusID", taskModel.StatusID),
                     new MySqlParameter("@TaskDateTimeEnd", taskModel.TaskDateTimeEnd)
                    );

                db.ExecuteNonQuery();
                db.SetCommand("select last_insert_id();");
                taskModel.TaskID = db.ExecuteScalar<uint>();
           }
            else
            {
                string sql = @"UPDATE tasks u SET   
                                                    u.TaskName=@TaskName,
                                                    u.TaskDescription=@TaskDescription,
                                                    u.ProjectID=@ProjectID, 
                                                    u.UserID=@UserID, 
                                                    u.PriorityID=@PriorityID ,                      
                                                    u.StatusID=@StatusID                       
                                                    WHERE TaskID = @TaskID;";
                db.SetCommand(sql,
                    new MySqlParameter("@TaskID", taskModel.TaskID),
                    new MySqlParameter("@TaskName", taskModel.TaskName),
                    new MySqlParameter("@TaskDescription", taskModel.TaskDescription),
                    new MySqlParameter("@ProjectID", taskModel.ProjectID),
                    new MySqlParameter("@UserID", taskModel.UserID),
                    new MySqlParameter("@PriorityID", taskModel.PriorityID),
                    new MySqlParameter("@StatusID", taskModel.StatusID)
                    );
                db.ExecuteNonQuery();

            }

        }

        //public static void Delete(DbManager db, TaskModel model)
        //{
        //    string sql = @" delete from tasks WHERE TaskID = @TaskID;";
        //    db.SetCommand(sql, new MySqlParameter("@TaskId", model));
        //    db.ExecuteNonQuery();
        //}

    }
}
