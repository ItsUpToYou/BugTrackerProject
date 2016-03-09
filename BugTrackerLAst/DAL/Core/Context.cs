using BLToolkit.Data;
using BLToolkit.Data.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Core
{
    public class Context
    {
        static string sql = "Server=localhost;Database=bugtracker;Port=3306;Uid=root;Pwd=123";
        public static DbManager Conn()
        {
            return new DbManager(new MySqlDataProvider(), sql);
        }
    }
}
