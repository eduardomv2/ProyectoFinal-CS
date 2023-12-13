﻿using System;
using System.Collections.Generic;

namespace Estructura_de_datos_CSharp_Consola.Clases.Algoritmos
{
    public class BucketSort
    {
        private static Random _rand = new Random();

        public BucketSort() { }

        public void bucketSort(double[] array)
        { 
            // Crear buckets vacíos
            List<double>[] buckets = new List<double>[array.Length];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<double>();
            }

            // Insertar elementos en sus respectivos buckets
            foreach (double element in array)
            {
                buckets[(int)(element * array.Length)].Add(element);
            }

            // Imprimir el estado de los buckets después de la inserción
            PrintBucketState(buckets);

            // Ordenar los elementos de cada cubo
            for (int i = 0; i < array.Length; i++)
            {
                buckets[i].Sort();
            }

            // Imprimir el estado de los buckets después de la ordenación
            PrintBucketState(buckets);

            // Obtener los elementos ordenados
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                foreach (var item in buckets[i])
                {
                    array[k++] = item;
                }
            }
        }

        private void PrintBucketState(List<double>[] buckets)
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
    }
}
