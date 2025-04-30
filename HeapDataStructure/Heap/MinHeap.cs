using System;
using System.Collections.Generic;



public class MinHeap
{
    private List<int> _heap;

    public MinHeap()
    {
        _heap = new List<int>();
    }

    public void Insert(int item)
    {
        _heap.Add(item);
        HeapifyUp(_heap.Count - 1);
    }

    //this method restores the heap property by moving the element at the given index up the heap
    //until it's in the correct position for a min-heap
    private void HeapifyUp(int index)
    {
        /*
         * used by insert to ensure the newly added element is correctly positioned:
         * starts at the index of the newly added element.
         * if the element is samller than its parent, it swaps with the parent
         * and continues moving up until the min-heap property is satisfied
         * to get the parent of index i: (i-1)/2
         * 
         */

        int parentIndex = 0;
        while(index > 0)
        {
            //calculate the parent's index for the current node
            parentIndex = (index - 1) / 2;


            //if the current element is greater than or equal to its parent,
            //the heap property is satistfied, so we can stop
            if (_heap[index] >= _heap[parentIndex]) break;



            //is a shorthand way to swap the values of elements. it's known as tuple assinment or tuple swap
            //where the values on the left side are swapped with values on the right side in a single , cocise statement.
            //swaps with the parent
            (_heap[index], _heap[parentIndex]) = (_heap[parentIndex], _heap[index]);


            //update the index to the parent's indes to contiue checking up the tree
            index = parentIndex;
        }
    }


    public int Peek()
    {
        if (_heap.Count is 0)
            throw new InvalidOperationException("The heap is empty");

        return _heap[0];//the samllest element in the heap.
    }
    public int ExtractMin()
    {
        if (_heap.Count is 0)
            throw new InvalidOperationException("Heap is empty.");

        //step 1: store the minimum value (root element) to return later
        int minValue = _heap[0];

        //step 2: move the last element from the heap, as it has been moved to the root
        _heap[0] = _heap[_heap.Count - 1];
        
        //step 3: Remove the last element from the heap, as it has been moved to the root
        _heap.RemoveAt(_heap.Count - 1);

        //step 4: Restore the heap perperty by calling HeapifyDown on the root
        HeapifyDown(0);

        return minValue;
    }

    private void HeapifyDown(int index)
    {
        /*
         * starts at the root and compares it to its children.
         * swaps with the smaller child if the heap property is violated.
         * and contains moving down untill the property is restored
         */

        int lefChild, rightChild, smallestIndex;
        while(index < _heap.Count)
        {
            //calculates the indices of the left and right children of the current node
            lefChild = 2 * index + 1;
            rightChild = 2 * index + 2;

            //start by assuming the current index is the smallest
            smallestIndex = index;

            //check if the right child exist and is smaller than the current smallest element
            if (rightChild < _heap.Count && _heap[rightChild] < _heap[smallestIndex])
                smallestIndex = rightChild;

            //check if the left child exist and is smaller than the current smallest element
            if (lefChild < _heap.Count && _heap[lefChild] < _heap[ smallestIndex])
                smallestIndex = lefChild;
            
            //if the current node is already the smallest, stop the process
            if (smallestIndex == index) break;

            //swap the current element with the smaller ciled to restore the min-heap property
            (_heap[index], _heap[smallestIndex]) = (_heap[smallestIndex], _heap[index]);

            //update the index to continue checking down the tree
            index = smallestIndex;
        }
    }

    public void DisplayHeap()
    {

        Console.WriteLine("\nHeap Elements:");
        foreach (var item in _heap)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

}

