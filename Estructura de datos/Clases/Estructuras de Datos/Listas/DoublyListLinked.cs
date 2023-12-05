using System;

namespace Estructura_de_datos.Clases.Listas
{
    public class DoublyListLinked<T> : ImethodLists<T>
    {
        private DoubleNode<T> Head { get; set; }
        private DoubleNode<T> LastNode { get; set; }

        public DoublyListLinked()
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
                return;
            }
            if (Exist(NewNode.Data))
            {
                return;
            }
            if (NewNode.CompareTo(Head) <= 0)
            {
                Head.Back = NewNode;
                NewNode.Next = Head;
                Head = NewNode;
                return;
            }
            if (NewNode.CompareTo(LastNode) >= 0)
            {
                LastNode.Next = NewNode;
                NewNode.Back = LastNode;
                LastNode = NewNode;
                return;
            }
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.CompareTo(NewNode) <= 0)
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
            if (object.Equals(Head.Data, data))
            {
                Head = Head.Next;
                Head.Back = null;
                Console.WriteLine($"- Data [{data}] remove form List...");
                return;
            }
            if (object.Equals(LastNode.Data, data))
            {
                LastNode = LastNode.Back;
                LastNode.Next = null;
                Console.WriteLine($"- Data [{data}] remove form List...");
                return;
            }
            DoubleNode<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.CompareTo(data) <= 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Data, data))
            {
                CurrentNode.Back.Next = CurrentNode.Next;
                CurrentNode.Next.Back = CurrentNode.Back;
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
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
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
            Console.WriteLine("=== My Doubly Linked List ===");
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Node [{i}] and Data: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            }
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
            Console.WriteLine("=== My Doubly Linked List Revers ===");
            do
            {
                Console.WriteLine($"- Node [{i}] and Data: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Back;
                i++;
            } while (CurrentNode != null);
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
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
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