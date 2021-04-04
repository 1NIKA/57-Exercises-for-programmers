using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise53_TodoList
{
    public class DataRemover
    {
        public static void RemoveDataFromDatabase()
        {
            using (var db = new TodoListEntities())
            {
                Console.Write("\nDo you want to remove any Task? y/n ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    Console.Write("\nPlease enter TaskID to remove it --> ");
                    int taskId = int.Parse(Console.ReadLine());

                    var taskDelete = db.Tasks.Find(taskId);
                    if (taskDelete != null)
                    {
                        db.Tasks.Remove(taskDelete);
                        db.SaveChanges();
                        Console.WriteLine("Task removed successfully");
                    }
                    else
                    {
                        Console.WriteLine("Task with this Id can't find");
                    }
                }
                else if (keyInfo.Key == ConsoleKey.N)
                {

                }
                else
                {
                    Console.WriteLine("\nThis Key is not valid");
                }
            }
        }
    }
}
