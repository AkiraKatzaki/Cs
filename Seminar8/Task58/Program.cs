namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
            Console.WriteLine();
            Console.WriteLine("Укажите размер первой матрицы\n кол-во строк: ");
            int heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во столбцов: ");
            int width = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = GetRandomArray2D(heigth, width);
            Console.WriteLine("Укажите размер второй матрицы\n кол-во строк: ");
            heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во столбцов: ");
            width = Convert.ToInt32(Console.ReadLine());
            int[,] matrix2 = GetRandomArray2D(heigth, width);

            Console.WriteLine("\nПервая матрица:");
            PrintArray2D(matrix);
            Console.WriteLine("\nВторая матрица:");
            PrintArray2D(matrix2);
            Console.WriteLine("\nРезультат произведения матриц:");
            int[,] result = Multiplication(matrix, matrix2);
            PrintArray2D(result);
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
        public static int[,] Multiplication(int[,] matrix, int[,] matrix2)
        {
            int[,] result = new int[matrix.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        result[i, j] += matrix[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
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
    }
}