using System;
using System.Collections.Generic;
using System.Collections;

internal class Program
{
    public class CutomCollection <T>: IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                /*
                 * Usage of yield return: it is used within an iterator block to provide a value 
                 * to the enumerator object and then pauses the execution of the iterator block
                 * untill the next element is requested.
                 * Functionality: when a yield return statement is executed,
                 * it returns the current value to the caller but remembers the curren location
                 * in code for the next call. the next time the iterator is accessed,
                 * it resumees execution from the state it was left in,
                 * immediatly after the last yeild return statement.
                 */


                yield return items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() 
        { 
             return GetEnumerator();
        }

        public void Add(T item)
        {
            items.Add(item);
        }
    } 


     static void Main(string[] args)
     {
        var list = new List<int>() { 1, 2, 3 };

      

         var myCollection = new CutomCollection<int>();
        myCollection.Add(1);
        myCollection.Add(2);
        myCollection.Add(3);

        var enumerator = myCollection.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }

        foreach (var item in myCollection)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
     }
    
}
