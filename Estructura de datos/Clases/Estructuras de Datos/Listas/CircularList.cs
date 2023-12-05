using System;

namespace Estructura_de_datos.Clases.Listas
{
	public class CircularList<T> : ImethodLists<T>
	{
		private Node<T> Head { get; set; }
		private Node<T> LastNode { get; set; }

		public int Lenght { get; set; }

		public CircularList()
		{
			Clear();
		}

		public void Add(T data)
		{
			Node<T> NewNode = new Node<T>(data);
			if (IsEmpty())
			{
				Head = NewNode;
				Head.Next = Head;
				LastNode = NewNode;
				Lenght++;
				return;
			}
			if (Exist(NewNode.Data))
			{
				return;
			}
			if (NewNode.CompareTo(Head) <= 0)
			{
				NewNode.Next = Head;
				Head = NewNode;
				LastNode.Next = Head;
                Lenght++;
                return;
			}
			if (NewNode.CompareTo(LastNode) >= 0)
			{
				LastNode.Next = NewNode;
				NewNode.Next = Head;
				LastNode = NewNode;
                Lenght++;
                return;
			}
			Node<T> CurrentNode = Head;
			while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(NewNode) <= 0)
			{
				CurrentNode = CurrentNode.Next;
			}
			NewNode.Next = CurrentNode.Next;
			CurrentNode.Next = NewNode;
            Lenght++;
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
				LastNode.Next = Head;
				Console.WriteLine($"- Data [{data}] remove form List...");
                Lenght--;
                return;
			}

			Node<T> CurrentNode = Head;
			while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(data) < 0)
			{
				CurrentNode = CurrentNode.Next;
			}
			if (CurrentNode.Next == LastNode && object.Equals(LastNode.Data, data))
			{
				CurrentNode.Next = CurrentNode.Next.Next;
				LastNode = CurrentNode;
				LastNode.Next = Head;
                Console.WriteLine($"- Data [{data}] remove form List...");
                Lenght--;
                return;
			}
			if (object.Equals(CurrentNode.Next.Data, data))
			{
				CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Data [{data}] remove form List...");
                Lenght--;
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
			Node<T> CurrentNode = Head;
			while (CurrentNode.Next != Head && CurrentNode.Next.CompareTo(data) < 0)
			{
				CurrentNode = CurrentNode.Next;
			}
			if (object.Equals(CurrentNode.Next.Data, data))
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
			Node<T> CurrentNode = Head;
			int i = 0;
			Console.WriteLine("=== My Circular List ===");
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
            Node<T> CurrentNode = Head;
            int x = 0;
            Console.WriteLine("=== My Circular List Revers ===");
            for (int i = Lenght - 1; i > -1; i--)
            {
                CurrentNode = Head;
                x = 0;
                while (CurrentNode != null && x != i)
                {
                    CurrentNode = CurrentNode.Next;
                    x++;
                }
                Console.WriteLine($"- Node [{i}] and Data: " + CurrentNode.Data);
            }
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
			Node<T> CurrentNode = Head;
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
