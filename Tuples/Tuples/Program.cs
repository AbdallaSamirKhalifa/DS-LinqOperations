using System;


internal class Program
{


    static void Main(string[] args)
    {
        //declare named tuple with modern syntax
        (int ID, string Name, double Height) person = (1, "Alice", 5.5);
        
        
        Console.WriteLine($"ID: {person.ID}.");
        Console.WriteLine($"Name: {person.Name}.");
        Console.WriteLine($"Height: {person.Height} feet.");

        var values = GetValues();

        Console.WriteLine($"\nUsing modern syntax:");
        Console.WriteLine($"Number: {values.Number}");
        Console.WriteLine($"Text: {values.Text}");
        


        var values2 = GetTuple();
        
        Console.WriteLine($"\nUsing tuple class (Older syntax):");
        Console.WriteLine($"Number: {values2.Item1}");
        Console.WriteLine($"Text: {values2.Item2}\n");

        //nested tuples

        var complexData = (Name: "Abdalla", Details: (Age: 23, Address: (City: "Cairo", Nation: "Egypt")));

        Console.WriteLine($"Name: {complexData.Name}, Age: {complexData.Details.Age}," +
            $" City: {complexData.Details.Address.City}, Nation: {complexData.Details.Address.Nation}");
        
            Console.ReadKey();
    }

    static (int Number,string Text) GetValues()
    {
        return (1, "One");
    }
    static Tuple<int , string> GetTuple()
    {

        return Tuple.Create(1, "One");
    }

}

