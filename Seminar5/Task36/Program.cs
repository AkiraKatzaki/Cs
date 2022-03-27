using System;

public class RandomClass
{
    public static void Main()
    {

        Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
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
            array[i] = rand.Next(100);
        }

        // Вывод полученого массива

        Console.WriteLine("Вывод суммы с нечетными индексами массива");
             int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            
            if (i % 2 != 0)
            {
                j += array[i]; 
                
            }
        }
        Console.WriteLine(j);
        return array;
    }
        
    
}
