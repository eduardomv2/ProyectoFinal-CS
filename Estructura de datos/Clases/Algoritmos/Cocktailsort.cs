namespace Estructura_de_datos_CSharp_Consola.Clases.Algoritmos
{
    public class Cocktailsort
    {
        public Cocktailsort() { }

        public void Sort(int[] arr)
        {
            bool swapped;
            int start = 0; 
            int end = arr.Length;

            do
            {
                // Fase de ida (de izquierda a derecha)
                swapped = false;
                for (int i = start; i < end - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                // Disminuir el límite superior porque el elemento más grande ya está en su posición correcta
                end--;

                // Fase de vuelta (de derecha a izquierda)
                swapped = false;
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                        swapped = true;
                    }
                }

                // Aumentar el límite inferior porque el elemento más pequeño ya está en su posición correcta
                start++;
            } while (swapped);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
