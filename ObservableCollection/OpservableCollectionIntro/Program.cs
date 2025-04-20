using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


internal class Program
{
    static void Main(string[] args)
    {
        //--------------------------------------Craetion-----------------------------------------
        //ObservableCollection<string> names = new ObservableCollection<string>();

        //names.Add("Alice");
        //names.Add("Bob");
        //names.Add("James");
        //names.Add("Jack");

        //foreach (var item in names)
        //{
        //    Console.WriteLine(item);
        //}

        //--------------------------------------Reponding to changes-----------------------------------------

        ObservableCollection<string> Items = new ObservableCollection<string>();

        Items.CollectionChanged += Items_CollectionChanged;
        //modufying the collection

        Items.Add("Item 1");
        Items.Add("Item 2");
        Items.Add("Item 3");

        Items.RemoveAt(1);
        Items.Insert(0, "New Item");//this will fire the add event
        Items[1] = "Replaced Item";//Replace action
        Items.Move(0, 2);//move action

        /* 
         Explaning Move
        the first parameter (0) specifies the index of the item you want to move.
        The second parameter (2) specifies the index to which you want to move the item.
        In this specific case, Items.Move(0, 2);
        means you are moving the item at index 0 (the first item) to index 2 int the collection.
        After this operation, the item originally at index 0 will be inserted at index 2,
        and the other items will be shifted accordingly.
         */


        Console.WriteLine("\nFinal collection:");
        foreach (var item in Items)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
    static void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        Console.WriteLine("\nCollection changed:");
        switch(e.Action)
        {
            case NotifyCollectionChangedAction.Add:
            {
                Console.WriteLine("Added:");
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine("- " + item);
                }
                break;
            }

            case NotifyCollectionChangedAction.Remove:
            {
                Console.WriteLine("Removed:");
                foreach (var item in e.OldItems)
                {
                    Console.WriteLine("- " + item);
                }
                break;
            }
            case NotifyCollectionChangedAction.Replace:
            {
                Console.WriteLine("Replaced:");
                foreach (var item in e.OldItems)
                {
                    Console.WriteLine("- " + item);
                }

                Console.WriteLine("With:");
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine("- " + item);
                }
                break;
            }
            case NotifyCollectionChangedAction.Move:
            {
                Console.WriteLine("Moved:");

                Console.WriteLine($"- From Index: {e.OldStartingIndex} to index: {e.NewStartingIndex}");

                 break;
            }

        }

    }

}
    

