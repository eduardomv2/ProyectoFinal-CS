using ArbolBinario_VisualStudio2019_FrameWork4._7._2;
using Estructura_de_datos.Clases.Extras;
using System;

namespace Estructura_de_datos.Clases.Menus
{
    public class MenuTree
    {
        public static string Name = "Tree";

        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static BinaryTree _Items = new BinaryTree();

        public static string[] _OptionTree = _Information.Tree;

        public MenuTree() { }

        public void CycleTree(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_OptionTree, Name);
                Console.Write("Select one option: ");
                Operation = OptionTree(Operation);
            } while (Operation != _OptionTree.Length);
            return;
        }

        public int OptionTree(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumOperationsTree)option;
            Console.Clear();
            MethosTree(x);
            return option;
        }

        public void MethosTree(EnumOperationsTree Tree)
        {
            int Data = 0;
            switch (Tree)
            {
                case EnumOperationsTree.Add:
                    Console.Write("Insert one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Add(Data);
                    break;

                case EnumOperationsTree.Delete:
                    Console.Write("Delete one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Delete(Data);
                    break;

                case EnumOperationsTree.Search:
                    Console.Write("Insert one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Search(Data);
                    break;

                case EnumOperationsTree.InOrder:
                    _Items.InOrden();
                    Console.ReadKey();
                    break;

                case EnumOperationsTree.PosOrder:
                    _Items.PostOrden();
                    Console.ReadKey();
                    break;

                case EnumOperationsTree.PreOrder:
                    _Items.PreOrden();
                    Console.ReadKey();
                    break;
            }
        }
    }
}