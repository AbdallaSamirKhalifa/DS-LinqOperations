using System;
using System.Collections.Generic;
using System.Collections;



internal class Program
{

    public class SimpleCollection<T> : ICollection<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;
        public bool IsReadOnly => false;

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Clear() 
        {
            items.Clear(); 
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }
        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        public void CopyTo(T[] arr, int index)
        {
            items.CopyTo(arr, index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }

    static void Main(string[] args)
    {
        SimpleCollection<string> shoppingCart = new SimpleCollection<string>();
        shoppingCart.Add("Apple");
        shoppingCart.Add("Banana");
        shoppingCart.Add("Carrot");

        Console.WriteLine($"Items in shopping cart: {shoppingCart.Count}");

        if (shoppingCart.Contains("Banana"))
        {
            shoppingCart.Remove("Banana");
            Console.WriteLine("Banan removed from the cart");

        }

        Console.WriteLine("\nFinal items in the cart:");
        foreach (var item in shoppingCart)
        {
            Console.WriteLine(item);

        }






        Console.ReadKey();
    }
}

