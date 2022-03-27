using System;

public class RandomClass
{
    public static void Main()
    {

        Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine();

        double[] array = RandArr(); 
    }

    public static double[] RandArr()
    {
        double[] array = new double[10];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next();
        }
        
        Console.WriteLine("Разница между максимальным и минимальным элементами массива");
        double max = 0, rezult = 0;
        double min = array[i];
        for (int i = 0; i < array.Length; i++)
        {         
            if (max < array[i])
            { 
                max = array[i];
            }
                else (min > array[i]) 
                {
                    min = array[i];
                }
        }
        rezult = max - min;
        
        Console.WriteLine();
        return rezult;
    }


}
