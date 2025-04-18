using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {

        //array wiht duplicate values
        int[] array = new int []{ 1, 2, 2, 3, 4, 4, 5 };



        HashSet<int> uniqueNumbers = new HashSet<int>(array);

        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }


        Console.ReadKey();
    }
}

