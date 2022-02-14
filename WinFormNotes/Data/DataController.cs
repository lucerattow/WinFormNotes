using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using WinFormNotes.Data.Models;

namespace WinFormNotes.Data
{
    public class DataController : LinqToDB.Data.DataConnection
    {
        public DataController() : base("SqlConnection")
        {
            InitializeDb();
        }

        public ITable<Category> tCategorys => GetTable<Category>();
        public ITable<TodoTask> tTodoTasks => GetTable<TodoTask>();

        /// <summary>
        /// comprueba que la base de datos y sus tablas esten correctamente creados, y si no es asi, los crea.
        /// </summary>
        public void InitializeDb()
        {
            var sp = this.DataProvider.GetSchemaProvider();
            var dbSchema = sp.GetSchema(this);

            if (!dbSchema.Tables.Any(t => t.TableName == "Categorys")) this.CreateTable<Category>();
            if (!dbSchema.Tables.Any(t => t.TableName == "TodoTasks")) this.CreateTable<TodoTask>();
        }
    }
}
