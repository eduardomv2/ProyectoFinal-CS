using Estructura_de_datos.Clases.Extras;
using Estructura_de_datos_CSharp_Consola.Clases.Algoritmos;
using System;
using System.Runtime.InteropServices;

namespace Estructura_de_datos.Clases.Menus
{
    public class MenuAlgorithm
    {
        public static string Name = "Algorithm";

        public static Random _Random = new Random(); 
        public static Information _Information = new Information();
        public static MenuStructures _MenuStructures = new MenuStructures();
        public static BubbleSort _Bubblesort = new BubbleSort();
        public static Cocktailsort _Cocktailsor = new Cocktailsort();
        public static Insertionsort _Insertionsort = new Insertionsort();
        public static BubbleSort _Bucketsort = new BubbleSort();
        public static Countingsort _Countingsort = new Countingsort();
        public static Mergesort _Mergesort = new Mergesort();
        public static Binarytreesort _Binarytreesort = new Binarytreesort();
        public static Pigeonhole _Pigeonhole = new Pigeonhole();
        public static Radixsort _Radixsort = new Radixsort();
        public static Gnomesort _Gnomesort = new Gnomesort();
        public static Shellsort _Shellsort = new Shellsort();
        public static Combsort _Combsort = new Combsort();
        public static Selectionsort _Selectionsort = new Selectionsort();
        public static Heapsort _Heapsort = new Heapsort();
        public static QuickSort _Quicksort = new QuickSort();

        public static string[] _TypeStack = _Information.TypeAlgorithm;

        public MenuAlgorithm() { }

        public void CycleAlgorithm(int Operation)
        {
            do
            {
                Operation = 0;
                _MenuStructures.PrintArray(_TypeStack, Name);
                Console.Write("Select one option: ");
                Operation = Option(Operation);
            } while (Operation != _TypeStack.Length);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumAlgorithm)option;
            Console.Clear();
            Menu(x);
            return option;
        }

        private void Menu(EnumAlgorithm Algorithm)
        {
            switch (Algorithm)
            {
                case EnumAlgorithm.None:
                    break;
                case EnumAlgorithm.Bubblesort:
                    Name = "Bubblesort";
                    int[] a = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(a);
                    _Bubblesort.bubbleSort(a);
                    Console.WriteLine("Bubblesort: ");
                    Print(a);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Cocktailsort:
                    Name = "Cocktailsort";
                    int[] b = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(b);
                    _Cocktailsor.Sort(b);
                    Console.WriteLine("Cocktailsort: ");
                    Print(b);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Insertionsort:
                    Name = "Insertionsort";
                    int[] c = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(c);
                    _Insertionsort.InsertionSortAlgorithm(c);
                    Console.WriteLine("Insertionsort: ");
                    Print(c);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Bucketsort:
                    Name = "Bucketsort";
                    int[] d = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(d);
                    _Bubblesort.bubbleSort(d);
                    Console.WriteLine("Bucketsort: ");
                    Print(d);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Countingsort:
                    Name = "Countingsort";
                    int[] e = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(e);
                    _Countingsort.Sort(e);
                    Console.WriteLine("Countingsort: ");
                    Print(e);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Mergesort:
                    Name = "Mergesort";
                    int[] f = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(f);
                    _Mergesort.MergeSort(f);
                    Console.WriteLine("Mergesort: ");
                    Print(f);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Binarytreesort:
                    Name = "Binarytreesort";
                    int[] g = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(g);
                    _Binarytreesort.Sort(g);
                    Console.WriteLine("Binarytreesort: ");
                    Print(g);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Pigeonhole:
                    Name = "Pigeonhole";
                    int[] h = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(h);
                    _Pigeonhole.PigeonholeSort(h);
                    Console.WriteLine("Pigeonhole: ");
                    Print(h);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Radixsort:
                    Name = "Radixsort";
                    int[] i = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(i);
                    _Radixsort.Sort(i);
                    Console.WriteLine("Radixsort: ");
                    Print(i);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Gnomesort:
                    Name = "Gnomesort";
                    int[] s = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(s);
                    _Gnomesort.Sort(s);
                    Console.WriteLine("Gnomesort: ");
                    Print(s);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Shellsort:
                    Name = "Shellsort";
                    int[] r = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(r);
                    _Shellsort.ShellSort(r);
                    Console.WriteLine("Shellsort: ");
                    Print(r);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Combsort:
                    Name = "Combsort";
                    a = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(a);
                    _Combsort.Sort(a);
                    Console.WriteLine("Combsort: ");
                    Print(a);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Selectionsort:
                    Name = "Selectionsort";
                    e = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(e);
                    _Selectionsort.Sort(e);
                    Console.WriteLine("Selectionsort: ");
                    Print(e);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Heapsort:
                    Name = "Heapsort";
                    int[] l = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(l);
                    _Heapsort.Sort(l);
                    Console.WriteLine("Heapsort: ");
                    Print(l);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Quicksort:
                    Name = "Quicksort";
                    c = Multipurpose();
                    Console.WriteLine("Original: ");
                    Print(c);
                    _Quicksort.quicksort(ref c, 0, c.Length - 1);
                    Console.WriteLine("Quicksort: ");
                    Print(c);
                    Console.ReadKey();
                    break;
                case EnumAlgorithm.Exit:
                    break;
            }
        }

        private int[] Multipurpose()
        {
            var x = 0;

            Console.Clear();
            Console.Write("Insert one data: ");
            x = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\t@Israel I22050327 Algorithm: " + Name + "\n");
            int[] array = new int[x];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = _Random.Next(10000);
            }
            return array;
        }

        private void Print(int[] collection)
        {
            Console.Write("[");
            foreach (var item in collection)
            {
                Console.Write($" {item}, ");
            }
            Console.Write("]\n\n");
        }
    }
}