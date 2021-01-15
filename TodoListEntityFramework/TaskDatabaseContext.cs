using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListEntityFramework
{
    class TaskDatabaseContext : DbContext
    {

        const string databasename = "todolistdatabase.mdf";
        static string DbPath = Path.Combine(Environment.CurrentDirectory, databasename);

        public TaskDatabaseContext() : base($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DbPath};Integrated Security=True;Connect Timeout=30")
        {

        }
        public DbSet<Task> DbTask { get; set; }
    }
}
