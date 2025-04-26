using System;
using System.Collections.Generic;
using System.Linq;



internal class Program
{

    public class Person:IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    
        public int CompareTo(Person Other)
        {
            if(Other == null) return 1;

            return this.Age.CompareTo(Other.Age);
        }
    
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }
    }


    static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person("Jhon",30),
            new Person("Jane",25),
            new Person("Doe",28)
        };

        people.Sort();

        Console.WriteLine("People sorted by age:");
        foreach (var item in people)
        {
            Console.WriteLine(item.ToString());
        }




        Console.ReadKey();
    }
}

