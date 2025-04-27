using System;
using GeneralTrees;

namespace FolderHier
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            //--------------------------------Foldr hir uisng array of treenodes------------------------------

            Tree<string> rootFolder = new Tree<string>("Root Folder");
            TreeNode<string>[] childrens = new TreeNode<string>[]
            {
                new TreeNode<string>("SubFolder1"),
                new TreeNode<string>("SubFolder2"),
                new TreeNode<string>("SubFolder3"),
                new TreeNode<string>("SubFolder4"),

            };

            TreeNode<string>[] GChildrens = new TreeNode<string>[]
            {
                new TreeNode<string>("SSFolder1"),
                new TreeNode<string>("SSFolder2"),
                new TreeNode<string>("SSFolder3"),
                new TreeNode<string>("SSFolder4"),

            };



            for (int i = 0; i < childrens.Length; i++)
            {

                GChildrens[i].AddChild(new TreeNode<string>($"File1"));
                GChildrens[i].AddChild(new TreeNode<string>($"File2"));
                GChildrens[i].AddChild(new TreeNode<string>($"File3"));
                childrens[i].AddChild(GChildrens[i]);

                rootFolder.Root.AddChild(childrens[i]);
            }
            rootFolder.PrintTree();
        }
    }
}
