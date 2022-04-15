namespace Program
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
            Console.WriteLine();
            Console.WriteLine("Укажите размер матрицы\n кол-во строк: ");
            int heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во столбцов: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = GetRandomArray2D(heigth, width);
            int[] array = new int[heigth];
            int index = 0;
            PrintArray2D(matrix);
            Console.WriteLine($"Cумма строк равна: ");
            SumArray(matrix, array, heigth, width);
            PrintArray1D(array);
            int min = array[0];            
            for (int i = 0; i < array.Length; i++)    
            {
                if (min > array[i])           
                {
                    min = array[i];
                    index = i;                   
                }
            }           
            Console.WriteLine($"Строка {index + 1} содержит наименьшую сумму {min}");                                   
        }
        public static int[,] GetRandomArray2D(int heigth, int width) // creates a 2D-array of Integers of height and width
        {
            Random random = new Random();
            int[,] array = new int[heigth, width];

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }

            return array;
        }
        public static int[] SumArray2D(int[,] matrix, int width)
        {
            int[] array = new int[width];
            int k = 0;
            if (k < width - 1)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sum += matrix[i, j];
                    }
                    array[k] = sum;
                    k++;
                    Console.Write(sum + " ");
                }
            }
            return array;
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
        public static void PrintArray1D(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Сумма {i+1} строки равна {array[i]} ");
            }
            Console.WriteLine();
        }
        public static int[] SumArray(int[,] matrix, int [] array, int heigth, int width)
        {
            int sum = 0;
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sum += matrix[i, j];
                    array[i] = sum;
                }
                sum = 0;
            }
            return array;
        }
    }
}