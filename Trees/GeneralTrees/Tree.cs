using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTrees
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }


        public Tree(T rootValue) 
        {
            Root = new TreeNode<T>(rootValue);
        }

        public void PrintTree(string indent = "|- ")
        {
            PrintTree(this.Root,indent);
        }
        private void PrintTree(TreeNode<T> node, string indent = "|- ")
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "----");
            }
        }

        public TreeNode<T>Find(T Value)
        {
            return Root?.Find(Value);
        }
    }
}
