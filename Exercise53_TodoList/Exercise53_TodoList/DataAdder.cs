using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise53_TodoList
{
    public class DataAdder
    {
        public static void AddDataToDatabase()
        {
            using (var db = new TodoListEntities())
            {
                Console.WriteLine("enter a Chore or Task:");
                var userEnter = Console.ReadLine();

                var task = new Tasks { Context = userEnter };

                while (!string.IsNullOrWhiteSpace(task.Context))
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();

                    Console.WriteLine("enter a Chore or Task:");
                    userEnter = Console.ReadLine();
                    task = new Tasks { Context = userEnter };
                }
            }
        }
    }
}
