﻿class Program
{

    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 15);
        }
        return array;
    }

    static void WriteArray(int[] array)
    {
        Console.WriteLine("Вывод массива");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void rar(int[] array)
    {
        int j = 1;
        for (int i = 0; i < array.Length/2; i++)
        {
            int res = array[i] * array[array.Length - j];
            Console.Write(" ");
            Console.Write(res);
            j++;
        }
    }



    static void Main(string[] args)
    {
        int[] array = CreaterArray(8);
        WriteArray(array);
       Console.Write(" - ");
        rar(array);
    }
}