using System;
using System.Collections.Generic;
using System.Linq;
using EFTest.Models;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the application");

          //  int name = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Hello World! " + name);

            
            using(DataEntity context = new DataEntity())
            {
            //Add object to the regular table
                //context.Table.Add(new Table { Name = "FirstTest" });

            //Delete object
                //Table table = context.Table.FirstOrDefault(r => r.Name == "SecondTest");
                //context.Table.Remove(table);

            //Add object to the table with the foreign key
                //Category category = context.Category.FirstOrDefault(c => c.Name == "Breakfast");
                //category.Table.Add(new Table{ Name="Tetst2" });

            //Select objects that have "Breakfast" category
                //Category category = context.Category.FirstOrDefault(c => c.Name == "Breakfast");
                //List<Table> tables = category.Table.ToList();
                //tables.ForEach(r => Console.WriteLine(r.Name));
                
            //Write category of the object
                //Table tableT = context.Table.FirstOrDefault(r => r.Name == "Tetst3");
                //Console.WriteLine(tableT.Category.Name);

            //Proper way to get an object from database(as I think)
                //Table table = context.Table.FirstOrDefault(r => r.Name == "SuperFirst");
                //if(table != null)
                //Console.WriteLine($"ID {table.Id} - CATEGORY {table.Category.Name} - old NAME {table.Name.Trim()} - new NAME {table.Name = "FirstTest"}");
                //else
                //Console.WriteLine("table is null");

            //Save Changes at the end
                // context.SaveChanges();
            }


            Console.WriteLine("Finishing the application");
        }
    }
}