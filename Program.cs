using System;
using System.Collections.Generic;
using System.Linq;
using EFTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the application\n");

          //  int name = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Hello World! " + name);

            
            using(DataEntity context = new DataEntity())
            {
            //Add object to the regular table
                //context.Table.Add(new Table { Name = "Test1"});


            //Delete object
                //Table table = context.Table.FirstOrDefault(r => r.Name == "SecondTest");
                //context.Table.Remove(table);


            //Add object to the table with the foreign key
                //Category category = context.Category.FirstOrDefault(c => c.Name == "Breakfast");
                //category.Table.Add(new Table{ Name="Tetst2" });


            //Select objects that have "Breakfast" category + LINQ Method Syntax
                //Category category = context.Category.Include(x=>x.Table).FirstOrDefault(c => c.Name == "Breakfast");
                //List<Table> tables = category.Table.ToList();
            //or like this    
                //var tables = context.Table.Where(t => t.Category.Name == "Breakfast").ToList();
                
                //tables.ForEach(r => Console.WriteLine(r.Name)); //Returns nothing (tables.Count == 0)


            //Select objects that have "Breakfast" category + LINQ Query Syntax
                //var tablesQuery = (from t in context.Table
                //                   where t.Category.Name == "Breakfast"
                //                   select t).ToList();
                
                //tablesQuery.ForEach(t  => Console.WriteLine((t as Table).Name)); //Returns proper data (tables.Count == 2)


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
                //context.SaveChanges();
            }

            
            IList<string> stringList = new List<string>() 
            { 
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java" 
            };

        // LINQ Query Syntax
            //var resultQuery = from s in stringList
            //where s.Contains("Tutorials") 
            //select s;
            //resultQuery.ToList().ForEach(x => { Console.WriteLine(x); });
            //Console.WriteLine();


        // LINQ Method Syntax
            //var resultMethod = stringList.Where(s => s.Contains("Tutorials"));
            //resultMethod.ToList().ForEach(x => { Console.WriteLine(x); });

            Console.WriteLine("\nFinishing the application");
        }
    }
}