using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormNotes.Data.Models;
using LinqToDB;
using System.Windows.Forms;

namespace WinFormNotes.Data.Querys
{
    public class qTodoTask
    {
        /// <summary>
        /// Busca en la tabla "Tasks" los registros que cumplan los filtros que se envien por parametro.
        /// </summary>
        /// <param name="id">Identificador del registro</param>
        /// <returns>Devuelve una lista de objetos del tipo "Data.Models.Tasks"</returns>
        public static List<TodoTask> Get(int id = -1)
        {
            List<TodoTask> result;
            using (var db = new DataController())
            {
                IEnumerable<TodoTask> Filters;
                IQueryable<TodoTask> query;

                query = from t in db.tTodoTasks
                        orderby t.Date_start descending
                        select t;
                result = query.ToList();

                if (id > 0)
                {
                    Filters = result.Where(x => x.Id == id);
                    result = Filters.ToList();
                }
            }

            return result;
        }

        /// <summary>
        /// Obtiene el ultimo registro añadida a la tabla "Tasks"
        /// </summary>
        /// <returns>Devuelve un objeto del tipo "Data.Models.Tasks"</returns>
        public static TodoTask GetLastSaved()
        {
            TodoTask result = new TodoTask { Id = 0 };

            using (var db = new DataController())
            {
                IQueryable<TodoTask> query;
                query = from t in db.tTodoTasks
                        select t;

                List<TodoTask> tasks = query.ToList();
                foreach (TodoTask item in tasks)
                {
                    if (item.Id > result.Id)
                    {
                        result = item;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Carga un registro en la tabla "Tasks"
        /// </summary>
        /// <param name="task">Registro que se desea guardar en la base de datos</param>
        /// <returns>true = si el proceso se completo correctamente, 
        /// false = si no existe un menu con ese id</returns>
        public static bool Save(TodoTask task)
        {
            if (task.Id > 0)
            {
                if (Get(task.Id).Count != 0)
                {
                    MessageBox.Show($"Ya existe un {task.GetType()} con este ID");
                    return false;
                }
            }

            using (var db = new DataController())
            {
                db.Insert(task);
            }

            return true;
        }

        /// <summary>
        /// Actualiza un registro en la tabla "Tasks"
        /// </summary>
        /// <param name="task">Registro que se desea actualizar en la base de datos</param>
        /// <returns>
        /// true = si el proceso se completo correctamente, 
        /// false = ya el registro que se desea actualizar no existe
        /// </returns>
        public static bool Update(TodoTask task)
        {
            if (Get(task.Id).Count == 0)
            {
                MessageBox.Show($"No existe un {task.GetType()} con este ID");
                return false;
            }

            using (var db = new DataController())
            {
                db.Update(task);
            }

            return true;
        }

        /// <summary>
        /// Elimina un registro en la tabla "Tasks"
        /// </summary>
        /// <param name="task">Registro que se desea eliminar de la base de datos</param>
        /// <returns>
        /// true = si el proceso se completo correctamente, 
        /// false = El registro no existe
        /// </returns>
        public static bool Delete(TodoTask task)
        {
            if (Get(task.Id).Count == 0)
            {
                MessageBox.Show($"La {task.GetType()} que intenta eliminar no existe");
                return false;
            }

            using (var db = new DataController())
            {
                db.Delete(task);
            }

            return true;
        }
    }
}
