using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTrees
{
    
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name.ToLower();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Tree<string> CompanyTree = new Tree<string>("CEO");
            TreeNode<string> Finance = new TreeNode<string>("CFO");
            TreeNode<string> Tech = new TreeNode<string>("CTO");
            TreeNode<string> Marketing = new TreeNode<string>("CMO");


            //Adding departments to the CEO
            CompanyTree.Root.AddChild(Finance);
            CompanyTree.Root.AddChild(Tech);
            CompanyTree.Root.AddChild(Marketing);

            //adding employees to departments
            Finance.AddChild(new TreeNode<string>("Acountant"));
            Tech.AddChild(new TreeNode<string>("Developer"));
            Tech.AddChild(new TreeNode<string>("UX Dessigner"));
            Marketing.AddChild(new TreeNode<string>("Social Media Manager"));

            CompanyTree.PrintTree();




            Console.ReadKey();
        }



    }
}
