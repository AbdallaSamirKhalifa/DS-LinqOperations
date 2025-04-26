using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;




internal class Program
{
   
    public class SimpleList<T> : IList<T>
    {
        private List<T> items = new List<T>();

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }

        public int Count => items.Count;
        public bool IsReadOnly => false;

        public void Add(T item) => items.Add(item);

        public void Clear() => items.Clear();

        public bool Contains(T item) => items.Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
        public int IndexOf(T item) => items.IndexOf(item);

        public void Insert(int index, T item) => items.Insert(index, item);

        public bool Remove(T item) => items.Remove(item);

        public void RemoveAt(int index) => items.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();


    }
    static void Main(string[] args)
    {
        SimpleList<string> mylist = new SimpleList<string>();
        mylist.Add("First");
        mylist.Add("Second");
        mylist.Insert(1, "Inserted");

        Console.WriteLine("List after adding and inserting:");
        foreach (var item in mylist)
        {
            Console.WriteLine(item);
        }

        mylist.RemoveAt(1);
        mylist[0] = "Updata First";

        Console.WriteLine("\nList after removing and updating:");
        foreach (var item in mylist)
        {
            Console.WriteLine(item);    
        }

        Console.ReadKey();
    }
}

