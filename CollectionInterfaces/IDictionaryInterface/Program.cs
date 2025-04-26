using System;
using System.Collections.Generic;
using System.Collections;

internal class Program
{


    public class SimpleDictionary<TKey,TValue> : IDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> list=new List<KeyValuePair<TKey, TValue>>();

        public TValue this[TKey key]
        {
            get
            {
                foreach(var kvp in list)
                {
                    if (Equals(kvp.Key, key))
                    {
                        return kvp.Value;
                    }
                }
                throw new KeyNotFoundException($"The given key '{key}' was not present in the dictionary.");
            }
            set
            {
                bool found = false;

                for(int i =0; i < list.Count; i++)
                {
                    if(Equals(list[i].Key, key))
                    {
                        list[i] = new KeyValuePair<TKey, TValue>(key,value);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    list.Add(new KeyValuePair<TKey, TValue>(key,value));
                }
            }

        }
        public ICollection<TKey> Keys => list.ConvertAll(kpv => kpv.Key);
        public ICollection<TValue> Values => list.ConvertAll(kpv => kpv.Value);

        public int Count => list.Count;
        public bool IsReadOnly => false;

        public void Add(TKey key, TValue value)
        {
            foreach (var kpv in list)
            {
                if (Equals(kpv.Key, key))
                {
                    throw new ArgumentException("An element with the same key already exists.");
                }
            }
            list.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public void Add(KeyValuePair<TKey, TValue> item)=> Add(item.Key,item.Value);

        public void Clear()=> list.Clear();
        public bool Contains(KeyValuePair<TKey, TValue> item) => list.Contains(item);
        public bool ContainsKey(TKey key)
        {
            foreach (var kpv in list)
            {
                if (Equals(kpv.Key, key))
                    return true;
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) => list.CopyTo(array, index);

        public IEnumerator<KeyValuePair<TKey,TValue>> GetEnumerator()=> list.GetEnumerator();

        public bool Remove(TKey key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (Equals(list[i].Key, key))
                {
                    list.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool Remove(KeyValuePair<TKey, TValue> item) => list.Remove(item);

        public bool TryGetValue(TKey key, out TValue value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (Equals(list[i].Key, key))
                {
                    value = list[i].Value;
                    return true;
                }
            }
            value = default;
            return false;

        }

        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
    }
    static void Main(string[] args)
    {
        var myDictionary =new SimpleDictionary<int,string>();

        //Adding elements to the dictionary
        myDictionary.Add(1, "One");
        myDictionary.Add(2, "Two");
        myDictionary.Add(3, "Three");


        //Accessing elements by key
        Console.WriteLine($"Element with key 2: {myDictionary[2]}");

        //updating element by key 
        myDictionary[2] = "Two Updated";
        Console.WriteLine($"Updated element with key 2: {myDictionary[2]}");

        //Iterating through dictionary
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"Kye: {item.Key}, Value: {item.Value}");

        }

        //Demonstrating the containskey and remove functionality
        if (myDictionary.ContainsKey(3))
        {
            Console.WriteLine($"\nContains key 3, removing...");
            myDictionary.Remove(3);
        }

        //displaying dictionary after removal
        Console.WriteLine($"\nDictionary after removing key 3:");
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"Kye: {item.Key}, Value: {item.Value}");

        }
        Console.ReadKey();
    }
}

