Console.WriteLine("Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine();

Console.WriteLine("Задайте количество строк массива");
int heigth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива");
int width = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
double[,] array = new double[heigth, width];
for (int i = 0; i < heigth; i++) // номер строки
{
    for (int j = 0; j < width; j++) // номер столбца
    {
        array[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", array[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();

Console.WriteLine($"Введите строку массива от 0 до {heigth - 1}:");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите столбец массива от 0 до {width - 1}:");
int w = Convert.ToInt32(Console.ReadLine());
if (h <= heigth - 1 & w <= width - 1)
{
    Console.WriteLine("{0,6:F2}", array[h,w]);
}
else 
{ 
    Console.WriteLine("Такого элемента нет"); 
}
