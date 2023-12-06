using Estructura_de_datos.Clases.Estructuras_de_Datos.Grafos;
using Estructura_de_datos.Clases.Extras;
using System;

namespace Estructura_de_datos.Clases.Menus.SubMenuGrafos
{
    public class SubMenuUndirectedGraph
    {
        public static string Name = "Undirected Graph";

        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static UndirectedGraph<int> _Items = new UndirectedGraph<int>();

        public static string[] _Option = _Information.Graph;

        public SubMenuUndirectedGraph() { }

        public void Menu(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_Option, Name);
                Console.Write("Select one option: ");
                Operation = Option(Operation);
            } while (Operation != _Option.Length);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumOperationsGraph)option;
            Console.Clear();
            Methos(x);
            return option;
        }

        private void Methos(EnumOperationsGraph Stack)
        {
            int DataF = 0, DataS = 0;
            switch (Stack)
            {
                case EnumOperationsGraph.AddVertex:
                    Console.WriteLine("Insert One data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.AddVertex(DataF);
                    break;

                case EnumOperationsGraph.AddEdge:
                    Console.WriteLine("Insert First data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    Console.WriteLine("Insert Second data: ");
                    try { DataS = int.Parse(Console.ReadLine()); } catch { }
                    _Items.AddEdge(DataF, DataS);
                    break;

                case EnumOperationsGraph.RemoveVertex:
                    Console.WriteLine("Insert One data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.RemoveVertex(DataF);
                    break;

                case EnumOperationsGraph.RemoveEdge:
                    Console.WriteLine("Insert First data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    Console.WriteLine("Insert Second data: ");
                    try { DataS = int.Parse(Console.ReadLine()); } catch { }
                    _Items.RemoveEdge(DataF, DataS);
                    break;

                case EnumOperationsGraph.ExistVertex:
                    Console.WriteLine("Insert One data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.VertexExists(DataF);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.ExistEdge:
                    Console.WriteLine("Insert First data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    Console.WriteLine("Insert Second data: ");
                    try { DataS = int.Parse(Console.ReadLine()); } catch { }
                    _Items.EdgeExists(DataF, DataS);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.GetAllVertex:
                    Console.WriteLine("Get All Vertices");
                    _Items.GetAllVertices();
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.GetAllEdge:
                    Console.WriteLine("Get All Edges");
                    _Items.GetAllEdges();
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.Transverse:
                    Console.WriteLine("Insert One data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.TraverseBFS(DataF);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.CalculateDegree:
                    Console.WriteLine("Insert One data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.CalculateDegree(DataF);
                    Console.ReadKey();
                    break;

                case EnumOperationsGraph.CalculateBFSLevels:
                    Console.WriteLine("Insert One data: ");
                    try { DataF = int.Parse(Console.ReadLine()); } catch { }
                    _Items.CalculateBFSLevels(DataF);
                    Console.ReadKey();
                    break;
            }
        }
    }
}