﻿class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(","   , BubbleSort(new int[] { 5, 4, 7, 1, 2, 0 })));
    }
    private static int[] BubbleSort(int[] arreglo)
    {
        //HOla manu bueno dia
        for (int i = 0; i < arreglo.Length; i++)
        {
            for (int j = 0; j < arreglo.Length - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    var temp = arreglo[j + 1];
                    arreglo[j + 1] = arreglo[j];
                    arreglo[j] = temp;
                }
            }
        }
        return arreglo;
    }
}

