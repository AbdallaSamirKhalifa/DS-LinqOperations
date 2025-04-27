using System;
using System.IO;
using System.Security;
using GeneralTrees;

namespace FindOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<string> CompanyTree = new Tree<string>("CEO");
            TreeNode<string> Finance = new TreeNode<string>("CFO");
            TreeNode<string> Tech = new TreeNode<string>("CTO");
            TreeNode<string> Marketing = new TreeNode<string>("CMO");
            CompanyTree.Root.AddChild(Finance);
            CompanyTree.Root.AddChild(Tech);
            CompanyTree.Root.AddChild(Marketing);

            TreeNode<string> TechLead = new TreeNode<string>("Tech Leed");
            TechLead.AddChild(new TreeNode<string>("Developer"));
            TechLead.AddChild(new TreeNode<string>("UX Designer"));
            Tech.AddChild(TechLead);
            
            TreeNode<string> FinanceManager = new TreeNode<string>("Finance Manager");
            FinanceManager.AddChild(new TreeNode<string>("Accountant"));
            FinanceManager.AddChild(new TreeNode<string>("Trainee"));
            Finance.AddChild(FinanceManager);

            TreeNode<string> MarketingManager = new TreeNode<string>("Marketing Manager");
            MarketingManager.AddChild(new TreeNode<string>("Socical Media Manager"));
            Marketing.AddChild(MarketingManager);
            CompanyTree.PrintTree();

            //Find Operation
            Console.WriteLine("\nFinding Developer");
            if (CompanyTree.Find("Developer") == null)
                Console.WriteLine("Not Found!");
            else 
                Console.WriteLine("Found!");

            
            Console.WriteLine("\nFinding DBA");
            if (CompanyTree.Find("DBA") == null)
                Console.WriteLine("Not Found!");
            else 
                Console.WriteLine("Found!");


                Console.ReadKey();


        }
    }
}
