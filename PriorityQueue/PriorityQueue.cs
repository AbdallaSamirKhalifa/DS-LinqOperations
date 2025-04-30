using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;


public class MinHeapPriorityQueue
{
    private List<PriorityQueueNode> heap;

    public int Count => heap.Count;
    public MinHeapPriorityQueue()
    {
        heap = new List<PriorityQueueNode>();
    }

    public void Insert(string name, int value)
    {
        var node = new PriorityQueueNode(name, value);
        heap.Add(node);
        HeapfyUp(heap.Count - 1);

    }

    private void HeapfyUp(int index)
    {
        int parentIndex;
        while (index > 0)
        {
            parentIndex = (index - 1) / 2;

            if (heap[index].Priority >= heap[parentIndex].Priority)
                break;

            (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);

            index = parentIndex;
        }
    }

    public PriorityQueueNode ExtractMin()
    {
        if (heap.Count is 0)
            throw new InvalidOperationException("Heap is empty.");

        var minVal = heap[0];
       
        heap[0]=heap[heap.Count-1];
       
        heap.RemoveAt(heap.Count-1);
      
        HeapifyDown(0);

        return minVal;

    }

    private void HeapifyDown(int index)
    {
        int leftChild, rightChild, smallestIndex;
        while (index < heap.Count)
        {
            leftChild = 2 * index + 1;
            rightChild = 2 * index + 2;

            smallestIndex = index;
            
            if (rightChild < heap.Count && heap[rightChild].Priority < heap[index].Priority)
                smallestIndex = rightChild;

            if (leftChild < heap.Count && heap[leftChild].Priority < heap[index].Priority)
                smallestIndex = leftChild;

            if (smallestIndex == index)
                break;

            (heap[index], heap[smallestIndex]) = (heap[smallestIndex], heap[index]);

            index = smallestIndex;
        }
    }

    public PriorityQueueNode Peek()
    {
        if (heap.Count is 0)
            throw new InvalidOperationException("Heap is empty.");
        return heap[0];
    }
}

