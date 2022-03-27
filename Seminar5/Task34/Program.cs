using System;

public class RandomClass
{
    public static void Main()
    {

        Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        Console.WriteLine();

        int[] array = RandArr();


    }
    public static int[] RandArr()
    {
        // Определение рандомного массива

        int[] array = new int[10];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(100, 1000);
        }

        // Вывод полученого массива

        Console.WriteLine("Вывод четных чисел массива");
        for (int i = 0; i < array.Length; i++)
        {
            int j = array[i] % 2;
            if (j == 0)
            {
                Console.Write($"{array[i]} ");
            }
        }
        Console.WriteLine();
        return array;
    }
}