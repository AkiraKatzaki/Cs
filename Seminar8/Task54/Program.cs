using System;
namespace Program;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine();
        Console.WriteLine("Укажите размер матрицы\n кол-во строк: ");
        int heigth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("кол-во столбцов: ");
        int width = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = GetRandomArray2D(heigth, width); 
        PrintArray2D(matrix);
        MatrixSort(matrix, heigth, width);
        PrintArray2D(matrix);

    }

    public static void PrintArray2D(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++) 
        {
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static int[,] MatrixSort(int[,] matrix, int heigth, int width)
    {
        int x = 0;
        for (int i = 0; i < heigth; i++)
        {
            for (int j = 0; j < width; j++)
            {
                for (int k = j; k < width; k++)
                {
                    if (matrix[i, k] > matrix[i, j])
                    {
                        x = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = x;
                    }
                }

            }
        }
        return matrix;
    }
    public static int[,] GetRandomArray2D(int heigth, int width) 
    {
        Random random = new Random();
        int[,] matrix = new int[heigth, width];

        for (int i = 0; i < heigth; i++) 
        {
            for (int j = 0; j < width; j++)
            { 
                matrix[i, j] = random.Next(0, 100);
            }
        }
        return matrix;
    }
}