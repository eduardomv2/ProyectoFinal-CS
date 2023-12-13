using Estructura_de_datos.Clases.Extras;
using Estructura_de_datos.Clases.Menus.SubMenuGrafos;
using System;

namespace Estructura_de_datos.Clases.Menus
{
    public class MenuGraph
    {
        public static string Name = "Graph";
        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static SubMenuDirectedGraph _SubMenuDirectedGraph = new SubMenuDirectedGraph();
        public static SubMenuUndirectedGraph _SubMenuUndirectedGraph = new SubMenuUndirectedGraph();

        public static string[] _TypeGraph = _Information.TypeGraph;

        public MenuGraph() { }

        public void CycleGraph(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_TypeGraph, Name); 
                Console.Write("Select one option: ");
                Operation = Option(Operation);
            } while (Operation != _TypeGraph.Length);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumTypeGraph)option;
            Console.Clear();
            Methos(option, x);
            return option;
        }

        private void Methos(int option, EnumTypeGraph Graph)
        {
            switch (Graph)
            {
                case EnumTypeGraph.DirectedGraph:
                    _SubMenuDirectedGraph.Menu(option);
                    break;

                case EnumTypeGraph.UndirectedGraph:
                    _SubMenuUndirectedGraph.Menu(option);
                    break;
            }
        }
    }
}