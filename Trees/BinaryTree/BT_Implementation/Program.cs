using System;




internal class Program
{

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    static void Main(string[] args)
    {

        //var people = new BinaryTree<Person>();

        //people.Insert(new Person("Abdalla"));
        //people.Insert(new Person("Mohammed"));
        //people.Insert(new Person("Ahmed"));
        //people.Insert(new Person("Sam"));
        //people.Insert(new Person("Khalid"));
        //people.Insert(new Person("Mohamed"));
        //people.Insert(new Person("Hamed"));
        //people.Insert(new Person("Hady"));

        //people.PrintTree();
        //Console.WriteLine("\nPreOrder Traversal (Current - Left SubTree - Right SubTree):");
        //people.PreOrderTraversal();
        //Console.WriteLine("\nPostOrder Traversal (Left SubTree - Right SubTree - Current):");
        //people.PostOrderTraversal();
        //Console.WriteLine("\nPostOrder Traversal (Left SubTree - Current - Right SubTree):");
        //people.InOrderTraversal();

        //-------------------------------------------Numbers example------------------------------
        var binaryTree = new BinaryTree<int>();
        Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");

        binaryTree.Insert(5);
        binaryTree.Insert(3);
        binaryTree.Insert(8);
        binaryTree.Insert(1);
        binaryTree.Insert(4);
        binaryTree.Insert(6);
        binaryTree.Insert(9);

        binaryTree.PrintTree();

        Console.WriteLine("\nPreOrder Traversal (Current-Left SubTree - Right SubTree):");
        binaryTree.PreOrderTraversal();


        Console.WriteLine("\nPostorder Traversal (Left SubTree - Right SubTree - Current):");
        binaryTree.PostOrderTraversal();

        Console.WriteLine("\nInorder Traversal: Left-Current-Right");
        binaryTree.InOrderTraversal();
        Console.ReadKey();
 

    }
}

