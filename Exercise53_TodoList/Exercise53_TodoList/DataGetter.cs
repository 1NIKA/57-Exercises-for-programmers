using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise53_TodoList
{
    public class DataGetter
    {
        public static void DisplayAllData()
        {
            using (var db = new TodoListEntities())
            {
                Console.WriteLine("All Tasks in the database:\n");
                Console.WriteLine("TaskID | Task");
                Console.WriteLine("-------|------------------");

                foreach (var item in db.Tasks
                    .OrderBy(t => t.TaskID))
                {
                    Console.WriteLine(string.Format("{0, -6} | {1}", item.TaskID, item.Context));
                }
            }
        }
    }
}