using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Heap
{
    public class MaxHeap
    {

        private List<int> heap;
        public MaxHeap() { heap = new List<int>(); }


        //this method inserts a new element into the heap while maintaining the max-heap peroperty
        public void Insert(int item) 
        {
            heap.Add(item);
            HeapifyUp(heap.Count - 1);
        }

        //this mehtod restores the heap property by moving the element at the givien index up heap
        //until it's in the correct position for a max-heap
        private void HeapifyUp(int index)
        {
            //used by insert to ensure the newly added element is correctly positioned in a max-heap
            //uf the element is greater than its parent, it swaps with the parent and contiues moving up
            //untill the max-heap property is satisfied

            int parentIndex = 0;

            while(index > 0)
            {
                //calculate the parent index for the current node
                parentIndex = (index - 1) / 2;

                //if the current element is less than the or equal to its parent,
                //the heap property is satisfied so we can stop
                if (heap[index] <= heap[parentIndex])
                    break;

                //swap if the current element is greater than its parent
                (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);

                //update the index to the parent's index to ocontiue checking up the tree
                index=parentIndex;
            }
        }


        //this mehtod removes and returns the max element from the heap, maintaining the max-heap property
        public int ExtractMax()
        {

            if (heap.Count is 0)
                throw new InvalidOperationException("Heap is empty.");

            //step 1: store the max value (root element) to return later
            int maxValue = heap[0];

            //step 2: move the last element in the heap to the root position
            heap[0]= heap[heap.Count-1];

            //step 3: remove the last element from the heap, as it has been moved to the root
            heap.RemoveAt(heap.Count - 1);

            //step 4: restore the heap property by calling this method
            HeapifyDown(0);

            return maxValue;
        }

        //this helper method restores the heap property by moving an element down the heap 
        //if it is smaller than its children, ensuring the max-heap structure is maintained
        private void HeapifyDown(int index)
        {
            /*
             * satrts with the root and compares it to its children 
             * swaps with the larger child if the heap property is violated
             * and continues moving down until the property is restored
             */

            int leftChild, rightChild, largestIndex;

            while(index < heap.Count)
            {
                //calculating the indices of the left and right children
                leftChild = 2 * index + 1;
                rightChild = 2 * index + 2;


               //start by assuming the current node is the largest
                largestIndex = index;

                //check if the right child exists and is greater than the currnt largest element
                if (rightChild < heap.Count && heap[rightChild] > heap[largestIndex])
                    largestIndex = rightChild;

                //check if the left child exists and is greater than the currnt largest element
                if (leftChild < heap.Count && heap[leftChild] > heap[largestIndex])
                    largestIndex = leftChild;


                //if the current node is already the largest, stop the process
                if (largestIndex == index)
                    break;

                //swap the current element with the larger child to restore the max-heap property
                (heap[index], heap[largestIndex]) = (heap[largestIndex], heap[index]);


                //update the index to continue cheching down the tree
                index = largestIndex;

            }

        }

        public int Peek()
        {
            if (heap.Count is 0)
                throw new InvalidOperationException("Heap is empty.");

            return heap[0];
        }
        public void DisplayHeap()
        {

            Console.WriteLine("\nHeap Elements:");
            foreach (var item in heap)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
