using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil204Odev2_3
{
    public class Heap
    {
        // bil210 10.Hafta ders notlarından aldım ve kendi koduma implemente ettim 
        public int currentSize;
            public int maxSize;
            public HeapNode[] heapArray;


        private int GetParent(int index) => (index - 1) / 2;
        private int GetLeftChild(int index) => 2 * index + 1;
        private int GetRightChild(int index) => 2 * index + 2;

        

        public Heap(int _maxSize)
            {
                currentSize = 0;
                maxSize = _maxSize;
                heapArray = new HeapNode[maxSize];
            }

            public bool Insert(Word word)
            {
                if (currentSize == maxSize)
                {
                    return false;
                }

                HeapNode newHeap = new HeapNode(word);
                heapArray[currentSize] = newHeap;
                MoveToUp(currentSize++);
                return true;
            }

            private void MoveToUp(int index)
            {
                int parent = GetParent(index);
                HeapNode bottom = heapArray[index];

            while (index > 0 && heapArray[parent].Word.Sıklık < bottom.Word.Sıklık)
            {
                    heapArray[index] = heapArray[parent];
                    index = parent;
                    parent = GetParent(parent);
                }

                heapArray[index] = bottom;
            }

            public HeapNode RemoveMax()
            {
                HeapNode heapNode = heapArray[0];
                heapArray[0] = heapArray[--currentSize];
                MoveToDown(0);
                 return heapNode;
             }

            private void MoveToDown(int index)
            {
                int largerChild;
                HeapNode top = heapArray[index];

                while (index < currentSize / 2)
                {
                    int leftChild = GetLeftChild(index);
                    int rightChild = GetRightChild(index);

                    if (rightChild < currentSize && heapArray[leftChild].Word.Sıklık < heapArray[rightChild].Word.Sıklık)
                    {
                        largerChild = rightChild;
                    }
                    else
                    {
                        largerChild = leftChild;
                    }

                    if (top.Word.Sıklık >= heapArray[largerChild].Word.Sıklık)
                    {
                        break;
                    }

                    heapArray[index] = heapArray[largerChild];
                    index = largerChild;
                }

                heapArray[index] = top;
            }
        public bool IsEmpty()
        {
            if (currentSize == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Word[] Sort(Word[] words)
        {
            Heap tempHeap = new Heap(10000);
            Word[] sorted = new Word[words.Length];
            foreach (var word in words)
            {
                tempHeap.Insert(word);
            }
            int i = 0;
            while (!tempHeap.IsEmpty())
            {
                sorted[i++] = tempHeap.RemoveMax().Word;
            }
            return sorted;
        }





    }

}
