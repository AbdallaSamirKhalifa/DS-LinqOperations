using System;
using System.Collections.Generic;


namespace UnionOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };  
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5};  


            //combine the elepments of two sets using UnionWith method
            //set1.UnionWith(set2);

            //Console.WriteLine("Union of sets:");
            //foreach (int item in set1)
            //{
            //    Console.WriteLine(item);
            //}

            //inetrsection of set1 and set2
            set1.IntersectWith(set2);
            Console.WriteLine("Intersection of sets:");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
