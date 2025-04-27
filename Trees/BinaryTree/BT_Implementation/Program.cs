using System;




internal class Program
{

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    static void Main(string[] args)
    {

        var people = new BinaryTree<Person>();

        people.Insert(new Person("Abdalla"));
        people.Insert(new Person("Mohammed"));
        people.Insert(new Person("Ahmed"));
        people.Insert(new Person("Sam"));
        people.Insert(new Person("Khalid"));
        people.Insert(new Person("Mohamed"));
        people.Insert(new Person("Hamed"));
        people.Insert(new Person("Hady"));

        people.PrintTree();
        Console.ReadKey();
    }
}

