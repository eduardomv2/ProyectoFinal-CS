using System;

namespace Estructura_de_datos.Clases
{
    public class DoubleNode<T> : IComparable<DoubleNode<T>>
    {
        public DoubleNode<T> Back { get; set; }
        public DoubleNode<T> Next { get; set; }
        public T Data { get; set; }

        public DoubleNode(T data)
        {
            Data = data;
            Next = null;
            Back = null;
        }

        public int CompareTo(DoubleNode<T> AnotherData)
        {
            // Caso 1: Ambos tipos son numericos
            if (EsNumero(Data) && EsNumero(AnotherData.Data))
            {
                long Value1 = Convert.ToInt64(Data);
                long Value2 = Convert.ToInt64(AnotherData.Data);
                return Value1.CompareTo(Value2);
            }

            // Caso 2: Solo el dato del nodo que esta comparando es numerico
            if (EsNumero(Data) && AnotherData.Data is string || AnotherData.Data is char)
            {
                long Value1 = Convert.ToInt64(Data);
                long Value2 = Convert.ToInt64(AnotherData.Data.ToString().Length);
                return Value1.CompareTo(Value2);
            }

            // Caso 3: Solo el dato del nodo a comparar es numerico
            if (EsNumero(AnotherData.Data) && Data is string || Data is char)
            {
                long Value1 = Convert.ToInt64(Data.ToString().Length);
                long Value2 = Convert.ToInt64(AnotherData.Data);
                return Value1.CompareTo(Value2);
            }

            // Case 4: Son diferentes tipos que se pueden comparar
            if (Data is IComparable ComparableData && AnotherData.Data is IComparable ComparableAnotherData)
            {
                return ComparableData.ToString().Length.CompareTo(ComparableAnotherData.ToString().Length);
            }

            return 0;
        }

        public int CompareTo(T AnotherData)
        {
            // Caso 1: Ambos tipos son numericos
            if (EsNumero(Data) && EsNumero(AnotherData))
            {
                long Value1 = Convert.ToInt64(Data);
                long Value2 = Convert.ToInt64(AnotherData);
                return Value1.CompareTo(Value2);
            }

            // Caso 2: Solo el dato del nodo que esta comparando es numerico
            if (EsNumero(Data) && AnotherData is string || AnotherData is char)
            {
                long Value1 = Convert.ToInt64(Data);
                long Value2 = Convert.ToInt64(AnotherData.ToString().Length);
                return Value1.CompareTo(Value2);
            }

            // Caso 3: Solo el dato del nodo a comparar es numerico
            if (EsNumero(AnotherData) && Data is string || Data is char)
            {
                long Value1 = Convert.ToInt64(Data.ToString().Length);
                long Value2 = Convert.ToInt64(AnotherData);
                return Value1.CompareTo(Value2);
            }

            // Case 4: Son diferentes tipos que se pueden comparar
            if (Data is IComparable ComparableData && AnotherData is IComparable ComparableAnotherData)
            {
                return ComparableData.ToString().Length.CompareTo(ComparableAnotherData.ToString().Length);
            }
            return 0;
        }

        private bool EsNumero(object Value)
        {
            return Value is sbyte || Value is byte || Value is short || Value is ushort ||
                   Value is int || Value is uint || Value is long || Value is ulong ||
                   Value is float || Value is double || Value is decimal;
        }
    }
}