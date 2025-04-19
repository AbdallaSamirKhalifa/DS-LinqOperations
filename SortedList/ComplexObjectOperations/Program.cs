using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

internal class Program
{
    static void Main(string[] args)
    {
        SortedList<int, Employee> employees = new SortedList<int, Employee>
        {
            {1, new Employee("Alice", "HR", 50000) },
            {2, new Employee("Bob", "IT", 70000) },
            {3, new Employee("Charlie", "HR", 52000) },
            {4, new Employee("Daisy", "IT", 80000) },
            {5, new Employee("Ethan", "Marketing", 45000) }
        };

        var query = employees.Where(e => e.Value.Department == "IT").
            OrderByDescending(e => e.Value.Salary)
            .Select(e => e.Value.Name);

        
        Console.WriteLine("IT department employees sorted by salary (Descending):");
        foreach (var name in query)
        {
            Console.WriteLine(name);
        }


        var groups = employees.GroupBy(e => e.Value.Department);

        Console.WriteLine("\nGrouping employees by department:");
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Key}: " +
                $"{string.Join(", ", group.Select(e => new {e.Value.Name,e.Value.Salary}))} ");
        }

        Console.ReadKey();
    }
}

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string department, decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}