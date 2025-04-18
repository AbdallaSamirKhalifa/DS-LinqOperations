using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Converting the list to an array
        //int[] numbersArray = numbers.ToArray();
        //Displaying the array elements
        //Console.WriteLine($"Array elements: {string.Join(", ", numbersArray)}");

        int[] arrNums= new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<int> listNums = new List<int>(arrNums);
        Console.WriteLine($"List elements: {string.Join(", ", listNums)}");


        Console.ReadKey();
    }
}

