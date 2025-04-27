using System;
using GeneralTrees;
namespace FamilyTree
{
    internal class Program3
    {
        static void Main(string[] args)
        {

            //--------------------------------------------Family Tree-----------------------------------------

            Tree<Person> Jhon = new Tree<Person>(new Person("John"));
            TreeNode<Person> Alice = new TreeNode<Person>(new Person("Alice"));
            TreeNode<Person> Bob = new TreeNode<Person>(new Person("Bob"));
            TreeNode<Person> Carol = new TreeNode<Person>(new Person("Carol"));
            TreeNode<Person> Semon = new TreeNode<Person>(new Person("Semon"));


            TreeNode<Person> GDavid = new TreeNode<Person>(new Person("David"));
            TreeNode<Person> GEmily = new TreeNode<Person>(new Person("Emily"));
            TreeNode<Person> GJasmin = new TreeNode<Person>(new Person("Jasmin"));
            TreeNode<Person> GTom = new TreeNode<Person>(new Person("Tom"));
            TreeNode<Person> GRoy = new TreeNode<Person>(new Person("Roy"));


            TreeNode<Person> GGZaina = new TreeNode<Person>(new Person("Zaina"));
            TreeNode<Person> GGZain = new TreeNode<Person>(new Person("Zain"));
            TreeNode<Person> GGSam = new TreeNode<Person>(new Person("Sam"));
            TreeNode<Person> GGSamantha = new TreeNode<Person>(new Person("Samantha"));




            //This block demonstrates the hierarchicy of the family
            Jhon.Root.AddChild(Alice);
                Alice.AddChild(GDavid);
                    GDavid.AddChild(GGZaina);
                    GDavid.AddChild(GGSamantha);
            Jhon.Root.AddChild(Bob);
                Bob.AddChild(GEmily);
            Jhon.Root.AddChild(Carol);
                Carol.AddChild(GJasmin);
            Jhon.Root.AddChild(Semon);
                Semon.AddChild(GTom);
                    GTom.AddChild(GGSam);
                    GTom.AddChild(GGZain);
            Semon.AddChild(GRoy);
                    GRoy.AddChild(GGZaina);

           PrintFamilyTree(Jhon.Root);
        }

        internal static void PrintFamilyTree(TreeNode<Person> node, string indent = "|- ")
        {
            Console.WriteLine(indent + node.Value.Name);
            foreach (var child in node.Children)
            {
                PrintFamilyTree(child, indent + "----");
            }
        }
    }
}
