using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise53_TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and save a new Chore or Task
            DataAdder.AddDataToDatabase();

            // Display all Blogs from the database
            DataGetter.DisplayAllData();

            // Remove Task from database
            DataRemover.RemoveDataFromDatabase();

            // Display Again
            Console.WriteLine();
            DataGetter.DisplayAllData();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}