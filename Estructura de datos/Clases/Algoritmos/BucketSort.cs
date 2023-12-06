using System;
using System.Collections.Generic;

namespace Estructura_de_datos_CSharp_Consola.Clases.Algoritmos
{
    public class BucketSort
    {
        private static Random _rand = new Random();

        public BucketSort() { }

        static void PrintBucketState(List<int>[] buckets)
        {
            Console.WriteLine("Current state of buckets:");
            for (int i = 0; i < buckets.Length; i++)
            {
                Console.Write($"Bucket {i}: ");
                foreach (var item in buckets[i])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void BucketSort_int(int[] array)
        {
            // Encuentra el valor máximo en el array
            int maxVal = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                    maxVal = array[i];
            }
            // Crea una lista de buckets vacíos
            List<int>[] buckets = new List<int>[maxVal + 1];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            // Distribuye los elementos en los buckets
            for (int i = 0; i < array.Length; i++)
            {
                buckets[array[i]].Add(array[i]);
            }
            PrintBucketState(buckets);

            // Ordena cada cubo individualmente
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i].Sort();
            }
            PrintBucketState(buckets);

            // Concatena los elementos ordenados de cada cubo
            int index = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                foreach (var item in buckets[i])
                {
                    array[index++] = item;
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
