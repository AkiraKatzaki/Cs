Console.WriteLine("Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();
Console.WriteLine("Задайте количество строк массива");
int heigth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива");
int width = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int[,] array = new int[heigth, width];
int[] average = new int[width];

for (int i = 0; i < heigth; i++) 
{
    for (int j = 0; j < width; j++) 
    {
        array[i, j] = random.Next(10);
    }
}
Console.WriteLine("Матрица");

for (int i = 0; i < heigth; i++)
{
    for (int j = 0; j < width; j++)
    {

        Console.Write(array[i, j] + " ");
        average[i] += array[j, i];      
    }
    Console.WriteLine();
}
Console.WriteLine();

foreach (int elem in average)
{

    Console.Write(elem / width + " "); 
}
