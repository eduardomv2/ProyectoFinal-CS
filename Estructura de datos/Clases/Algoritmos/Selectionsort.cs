namespace Estructura_de_datos_CSharp_Consola.Clases.Algoritmos
{
    public class Selectionsort
    {
        public Selectionsort() { }

        public void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Encontrar el índice del mínimo elemento en el subarreglo no ordenado
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Intercambiar el mínimo encontrado con el primer elemento del subarreglo no ordenado
                Swap(ref arr[i], ref arr[minIndex]);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
