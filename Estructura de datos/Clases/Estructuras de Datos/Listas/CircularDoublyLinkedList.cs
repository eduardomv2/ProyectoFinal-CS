using System;

namespace Estructura_de_datos.Clases.Listas
{
    public class CircularDoublyLinkedList<T> : ImethodLists<T>
    {
        private DoubleNode<T> Head { get; set; }
        private DoubleNode<T> LastNode { get; set; }

        public CircularDoublyLinkedList()
        {
            Clear();
        }

        public void Add(T data)
        {
            DoubleNode<T> NewNode = new DoubleNode<T>(data);
            if (IsEmpty())
            {
                Head = NewNode;
                LastNode = NewNode;
                Head.Back = LastNode;
                LastNode.Next = Head;
                return;
            }
            if (Exist(NewNode.Data))
            {
                return;
            }
            if (NewNode.CompareTo(Head) <= 0)
            {
                NewNode.Next = Head;
                NewNode.Back = LastNode;
                Head.Back = NewNode;
                Head = NewNode;
                LastNode.Next = Head;
                return;
            }
            if (NewNode.CompareTo(LastNode) >= 0)
            {
                LastNode.Next = NewNode;
                NewNode.Back = LastNode;
                NewNode.Next = Head;
                LastNode = NewNode;
                Head.Back = LastNode;
                return;
            }
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(NewNode) <= 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            NewNode.Next = CurrentNode.Next;
            NewNode.Back = CurrentNode;
            CurrentNode.Next.Back = NewNode;
            CurrentNode.Next = NewNode;
        }

        public void Delete(T data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (object.Equals(Head.Data, LastNode.Data))
            {
                Clear();
                Console.WriteLine($"- Data [{data}] remove form List...");
                return;
            }
            if (object.Equals(Head.Data, data))
            {
                Head = Head.Next;
                Head.Back = LastNode;
                LastNode.Next = Head;
                Console.WriteLine($"- Data [{data}] remove form List...");
                return;
            }
            if (object.Equals(LastNode.Data, data))
            {
                LastNode = LastNode.Back;
                LastNode.Next = Head;
                Head.Back = LastNode;
                Console.WriteLine($"- Data [{data}] remove form List...");
                return;
            }
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && !object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode.Next.Next.Back = CurrentNode;
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Data [{data}] remove form List...");
                return;
            }
            Console.WriteLine($"- Data [{data}] no remove form List...");
        }

        public void Search(T data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (object.Equals(Head.Data, data))
            {
                Console.WriteLine($"- Data [{data}] exist form List...");
                return;
            }
            if (object.Equals(LastNode.Data, data))
            {
                Console.WriteLine($"- Data [{data}] exist form List...");
                return;
            }
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && !object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Data, data))
            {
                Console.WriteLine($"- Data [{data}] exist form List...");
                return;
            }
            Console.WriteLine($"- Data [{data}] no exist form List...");
        }

        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Void List");
                return;
            }
            DoubleNode<T> CurrentNode = Head;
            int i = 0;
            Console.WriteLine("=== My Cicular Doubly Linked List ===");
            do
            {
                Console.WriteLine($"- Node [{i}] and Data: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            } while (CurrentNode != Head);
        }

        public void ShowRevers()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Void List");
                return;
            }
            DoubleNode<T> CurrentNode = LastNode;
            int i = 0;
            Console.WriteLine("=== My Cicular Doubly Linked List Revers===");
            do
            {
                Console.WriteLine($"- Node [{i}] and Data: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Back;
                i++;
            } while (CurrentNode != LastNode);
        }

        public bool Exist(T data)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (object.Equals(Head.Data, data))
            {
                return true;
            }
            if (object.Equals(LastNode.Data, data))
            {
                return true;
            }
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != Head && !object.Equals(CurrentNode.Data, data))
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Data, data))
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
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