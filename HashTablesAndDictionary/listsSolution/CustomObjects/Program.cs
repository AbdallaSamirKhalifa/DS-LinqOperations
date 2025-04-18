using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}




internal class Program
{
    static void Main(string[] args)
    {

        List<Person> people = new List<Person>
        {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35),
            new Person("David", 40),
            new Person("Eve", 29),
            new Person("Frank", 31),
            new Person("Grace", 24),
            new Person("Helen", 27),

        };

        // Iterating over the list and printing details of each person
        Console.WriteLine("Current state of the people list:");
        foreach (Person person in people)
        {
            Console.WriteLine($"Found person: Name: {person.Name}, Age: {person.Age}");
        }

        //Using Find
        Person FoundPerson = people.Find(p => p.Name == "David");
        if ( FoundPerson != null )
            Console.WriteLine($"\nFound person: Name: {FoundPerson.Name}, Age: {FoundPerson.Age}");


        // Find and updating the age of a person named "Alice"
        //the FirstOrDefault same as Find but its in the LINQ
        Person searchResult = people.FirstOrDefault(person => person.Name == "Alice");
        if(searchResult != null)
        {
            searchResult.Age = 31;
            Console.WriteLine($"Updated Alice's Age to: {searchResult.Age}");
        }

        // Using Find All
        List<Person> peopleOver30 = people.FindAll(p => p.Age >= 30);
        Console.WriteLine("\nPeople over 30:");

        foreach(var person in peopleOver30)
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        //using Any to check by name
        Console.WriteLine($"\nList contains person name 'Alice': {people.Any(person => person.Name == "Alice")}");


        //using Exists to check by name
        Console.WriteLine($"Exists person over 40: {people.Exists(person => person.Age > 40)}");


        //Removing people under the age 30
        people.RemoveAll(p => p.Age < 30);
        Console.WriteLine($"\nRemoved people under the age of 30.");


        //Iterating over the list of people and printing details of each person
        Console.WriteLine("Current state of the people list:");
        foreach(var person in people)
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");


        Console.ReadKey();
    }
}

