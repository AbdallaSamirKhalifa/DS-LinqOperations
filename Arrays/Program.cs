using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums= { 1, 2, 3, 4, 5 };


            ////using LINQ to filter and transform data
            //var evenSquare = nums.Where(n => n % 2 == 0).Select(n => n * n);


            //Console.WriteLine("Squares of even numbers");
            //foreach (var item in evenSquare)
            //{
            //    Console.WriteLine(item);
            //}


            //---------------------------Advanced Linq operations-----------------------------

            //var people = new[]
            //{
            //    new { Name = "Alice",Age = 30},
            //    new { Name = "Bob",Age = 25},
            //    new { Name = "Charlie",Age = 35},
            //    new { Name = "Diana",Age = 30},
            //    new { Name = "Ethan",Age = 25},
            //};

            ////Grouping people by Age, then ordering within each group

            //var groupByAge = people.GroupBy(x => x.Age).Select(group => new
            //{
            //    Age = group.Key
            //    ,
            //    People = group.OrderBy(p => p.Age)
            //});


            //foreach (var group in groupByAge)
            //{
            //    Console.WriteLine($"Age Group: {group.Age}");
            //    foreach (var person in group.People)
            //    {
            //        Console.WriteLine($" - {person.Name}, {person.Age}");
            //    }
            //}


            //---------------------------3rd Advanced Linq operations-----------------------------

            var employees = new[]
            {
                new { ID = 1, Name="Alice", DepartmentID = 2},
                new { ID = 2, Name="Bob", DepartmentID = 1},
            };
            //array of departements

            var departments = new[]
            {
                new{ID = 1, Name ="Human Resources"},
                new{ID = 2, Name ="Development"},
            };

            //joining emplyees with departments and projecting the results
            var employeesDetails = employees.Join(departments
                , Employee => Employee.DepartmentID,
                department => department.ID,
                (emp, dep) => new { emp.Name,Department = dep.Name});

            foreach (var item in employeesDetails)
            {
                Console.WriteLine($"Employee: {item.Name}, Department: {item.Department}");
            }
            Console.ReadKey();
        }
    }
}
