using System;

namespace Estructura_de_datos.Clases.Estructuras_de_Datos.Colas
{
    internal class Nodo
    {
        public Nodo Next { get; set; }
        public int Data { get; set; }

        public Nodo(int data)
        {
            Data = data;
            Next = null;
        }
    }
    
    public class Queue
    {
        private Nodo Head { get; set; }
        private Nodo LastNode { get; set; }

        public Queue()
        {
            Head = null;
            LastNode = null;
        }

        public void Enqueue(int data)
        {
            Nodo NewNode = new Nodo(data);
            if (IsEmpty())
            {
                Head = NewNode;
                LastNode = NewNode;
                return;
            }
            if (Exist(NewNode.Data))
            {
                return;
            }
            if (NewNode.Data < Head.Data)
            {
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }
            Nodo CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data < NewNode.Data)
            {
                CurrentNode = CurrentNode.Next;
            }
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
            CurrentNode = Head;
            while (CurrentNode.Next != null)
            {
                CurrentNode = CurrentNode.Next;
            }
            LastNode = CurrentNode;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Void Queue");
                return;
            }
            if (Head.Next != null)
            {
                Head = Head.Next;
                return;
            }
            Clear();
        }

        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Void Queue");
                return;
            }
            int i = 0;
            Nodo CurrentNode = Head;
            Console.WriteLine("=== My Queue ===");
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Node[{i}] and Data: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            }
        }

        private bool Exist(int data)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (Head.Data == data)
            {
                return true;
            }
            Nodo CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.Data < data)
            {
                CurrentNode = CurrentNode.Next;
            }
            if (CurrentNode.Data == data)
            {
                return true;
            }
            return false;
        }

        private bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
            LastNode = null;
        }
    }
}