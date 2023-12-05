using System;
using System.Collections.Generic;

namespace Estructura_de_datos.Clases.Estructuras_de_Datos.Colas
{
    public class PriorityQueue<T>
    {
        public class Element<T>
        {
            public T Value { get; set; }
            public int Priority { get; set; }

            public Element(T value, int priority)
            {
                Value = value;
                Priority = priority;
            }
        }

        private List<Element<T>> Items;
        public int Count { get; set; }

        public PriorityQueue()
        {
            Items = new List<Element<T>>();
        }

        public void Enqueue(T Value, int Priority)
        {
            var element = new Element<T>(Value, Priority);
            Items.Add(element);
            HeapifyUp(Items.Count - 1);
        }

        public T Dequeue()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Void Queue");
                return default(T);
            } 
            var result = Items[0].Value;
            Items[0] = Items[Items.Count - 1];
            Items.RemoveAt(Items.Count - 1);
            HeapifyDown(0);
            return result;
        }

        private void HeapifyUp(int Index)
        {
            while (Index > 0)
            {
                int parentIndex = (Index - 1) / 2;

                if (Items[Index].Priority < Items[parentIndex].Priority)
                {
                    Swap(Index, parentIndex);
                    Index = parentIndex;
                }
                else
                {
                    break;
                }
            }
        }

        private void HeapifyDown(int Index)
        {
            int leftChild = 2 * Index + 1;
            int rightChild = 2 * Index + 2;
            int smallest = Index;

            if (leftChild < Items.Count && Items[leftChild].Priority < Items[smallest].Priority)
            {
                smallest = leftChild;
            }

            if (rightChild < Items.Count && Items[rightChild].Priority < Items[smallest].Priority)
            {
                smallest = rightChild;
            }

            if (smallest != Index)
            {
                Swap(Index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void Swap(int Index1, int Index2)
        {
            var temp = Items[Index1];
            Items[Index1] = Items[Index2];
            Items[Index2] = temp;
        }

        public void Show()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Void Queue");
                return;
            }
            Console.WriteLine("=== My Priority Queue ===");
            foreach (var element in Items)
            {
                Console.WriteLine("Data: " + element.Value + " Priority: " + element.Priority);
            }
            Console.WriteLine();
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}