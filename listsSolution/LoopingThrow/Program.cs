using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine($"Number of items in the list: {nums.Count}");

        //looping throough
        Console.WriteLine("\nfor loop");
        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i] );

        }

        //Foreach loop
        Console.WriteLine("\nfor each");
        foreach (int i in nums) 
            Console.WriteLine(i);

        //list.froeach
        Console.WriteLine("\nList.ForEach");
        nums.ForEach(number => Console.WriteLine(number ));//lambda expression
        Console.ReadKey();
    }
}

