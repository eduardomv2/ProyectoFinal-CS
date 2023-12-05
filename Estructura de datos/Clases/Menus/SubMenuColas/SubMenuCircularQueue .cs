using Estructura_de_datos.Clases.Estructuras_de_Datos;
using Estructura_de_datos.Clases.Extras;
using System;

namespace Estructura_de_datos.Clases.Menus.SubMenuColas
{
    public class SubMenuCircularQueue
    {
        public static string Name = "Circular Queue";

        public static Random _Random = new Random();
        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static CircularQueue _Items = new CircularQueue(20);

        public static string[] _OptionList = _Information.Queue;

        public SubMenuCircularQueue() { }

        public void MenuOption(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_OptionList, Name);
                Console.Write("Select one option: ");
                Operation = Option(Operation);
            } while (Operation != _OptionList.Length - 1);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumOperationsQueue)option;
            Console.Clear();
            Methos(x);
            return option;
        }

        public void Methos(EnumOperationsQueue Stack)
        {
            int Data = 0;
            switch (Stack)
            {
                case EnumOperationsQueue.Generate:
                    Console.Write("Generate: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    for (int i = 0; i < Data; i++)
                    {
                        _Items.Enqueue(_Random.Next(100000));
                    }
                    Console.WriteLine("Finish");
                    Console.ReadKey();
                    break;

                case EnumOperationsQueue.Enqueue:
                    Console.WriteLine("Insert one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Enqueue(Data);
                    break;

                case EnumOperationsQueue.Dequeue:
                    _Items.Dequeue();
                    break;

                case EnumOperationsQueue.Show:
                    _Items.Show();
                    Console.ReadKey();
                    break;

                case EnumOperationsQueue.Clear:
                    _Items.Clear();
                    break;
            }
        }
    }
}