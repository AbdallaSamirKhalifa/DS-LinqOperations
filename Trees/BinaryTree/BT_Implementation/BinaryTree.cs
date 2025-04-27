

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class BinaryTree<T>
{
    public BinaryTreeNode<T> Root { get; private set; }

    public BinaryTree()
    {
        Root = null;
    }


    public void Insert(T value)
    {
        /*
         * we use Lvel-Order Insertion strategy.
         * LOI: in binary tree is a strategy that fills the tree level by level,
         * form left to right. this approach ensure that every level of the tree is completely
         * filled before any nodes are added to a new leve,
         * and each parent node has at most two children before moving to the nex node in the sequence.
         * 
         */

        var newNode= new BinaryTreeNode<T>(value);
        if (Root == null)
        {
            Root= newNode;
            return;
        }

        //using queue to perform level-order insertion
        Queue<BinaryTreeNode<T>>queue= new Queue<BinaryTreeNode<T>>();

        queue.Enqueue(Root);

        
        while(queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (current.Left == null)
            {
                current.Left= newNode;
                return;
            }
            else
            {
                queue.Enqueue(current.Left);
            }
            if(current.Right == null)
            {
                current.Right= newNode;
                return;

            }else
                queue.Enqueue(current.Right);
        }
    }


    public void PrintTree()
    {
        PrintTree(Root, 0); 
    }

    private void PrintTree(BinaryTreeNode<T>Node, int spaces)
    {
        int COUNT = 10; //Distance between levels to adjust the visual representation
        if (Node == null)
            return;

        spaces += COUNT;
        PrintTree(Node.Right, spaces);//Print the right subtree first, then roo, and left 

        Console.WriteLine();
        for (int i = COUNT; i < spaces; i++) 
            Console.Write(" ");

        Console.WriteLine(Node.Value.ToString());//print the current node after space
        PrintTree(Node.Left, spaces);//Recur on the lift child
    }
}

