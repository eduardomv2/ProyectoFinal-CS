using System;

namespace Estructura_de_datos_CSharp_Consola.Clases.Algoritmos
{
    public class Insertionsort 
    {
        public Insertionsort() { }

        public void InsertionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Mover los elementos del subarreglo arr[0..i-1] que son mayores que key
                // a una posición adelante de su posición actual
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        public void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
