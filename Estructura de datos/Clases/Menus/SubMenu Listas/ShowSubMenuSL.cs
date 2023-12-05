using Estructura_de_datos.Clases;
using Estructura_de_datos.Clases.Extras;
using System;

namespace Estructura_de_datos
{
    public class SubMenu_SL
    {
        public static string Name = "Simple List";

        public static Random _Random = new Random();
        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static SimpleList<int> _Items = new SimpleList<int>();

        public static string[] _OptionList = _Information.List;

        public SubMenu_SL() { }

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
            var x = (EnumOperationsList)option;
            Console.Clear();
            Methos(x);
            return option;
        }

        private void Methos(EnumOperationsList Lists)
        {
            int Data = 0;
            switch (Lists)
            {
                case EnumOperationsList.Generate:
                    Console.Write("Generate: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    for (int i = 0; i < Data; i++)
                    {
                        _Items.Add(_Random.Next(100000));
                    }
                    Console.WriteLine("Finish");
                    Console.ReadKey();
                    break;

                case EnumOperationsList.Add:
                    Console.Write("Insert one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Add(Data);
                    break;

                case EnumOperationsList.Delete:
                    Console.Write("Delete one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Delete(Data);
                    break;

                case EnumOperationsList.Search:
                    Console.Write("Search one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Search(Data);
                    break;

                case EnumOperationsList.Show:
                    _Items.Show();
                    Console.ReadKey();
                    break;

                case EnumOperationsList.ShowRevers:
                    _Items.ShowRevers();
                    Console.ReadKey();
                    break;

                case EnumOperationsList.Clear:
                    _Items.Clear();
                    break;
            }
        }
    }
}