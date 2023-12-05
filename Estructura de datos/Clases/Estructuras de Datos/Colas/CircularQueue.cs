using System;
using System.Collections.Generic;

namespace Estructura_de_datos.Clases.Estructuras_de_Datos
{
    public class CircularQueue
    {
        private int Size, Front, Rear;
        private List<int> Queue = new List<int>();

        public CircularQueue(int size)
        {
            this.Size = size;
            this.Front = this.Rear = -1;
        }

        public void Enqueue(int Value)
        {
            if ((Front == 0 && Rear == Size - 1) || (Rear == (Front - 1) % (Size - 1)))
            {
                Console.Write("Queue is Full");
            }
            else if (Front == -1)
            {
                Front = 0;
                Rear = 0;
                Queue.Add(Value);
            }
            else if (Rear == Size - 1 && Front != 0)
            {
                Rear = 0;
                Queue[Rear] = Value;
            }
            else
            {
                Rear = (Rear + 1);
                if (Front <= Rear)
                {
                    Queue.Add(Value);
                }
                else
                {
                    Queue[Rear] = Value;
                }
            }
        }

        public int Dequeue()
        {
            int Temp;
            if (Front == -1)
            {
                Console.Write("Queue is Empty");
                return -1;
            }
            Temp = Queue[Front];
            if (Front == Rear)
            {
                Front = -1;
                Rear = -1;
            }
            else if (Front == Size - 1)
            {
                Front = 0;
            }
            else
            {
                Front = Front + 1;
            }
            return Temp;
        }

        public void Show()
        {
            if (Front == -1)
            {
                Console.Write("Queue is Empty");
                return;
            }
            else if (Queue.Count == 0)
            {
                Console.Write("Queue is Empty");
                return;
            }
            Console.WriteLine("=== My Circular Queue ===");
            if (Rear >= Front)
            {
                for (int i = Front; i < Rear; i++)
                {
                    Console.WriteLine($"- Node[{i}] and Data: " + Queue[i]);
                }
            }
            else
            {
                for (int i = Front; i < Size; i++)
                {
                    Console.WriteLine($"- Node[{i}] and Data: " + Queue[i]);
                }
                for (int i = 0; i <= Rear; i++)
                {
                    Console.WriteLine($"- Node[{i}] and Data: " + Queue[i]);
                }
            }
        }

        public void Clear()
        {
            Queue.Clear();
        }
    }
}