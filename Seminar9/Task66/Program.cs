namespace pro
{
    class Prog
    {
        static void Main()
        {
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
            Console.WriteLine();
            Console.Write("Введите минимальное значение: \t");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное значение: \t");
            int max = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            Console.Write($"Сумма натуральных элементов в промежутке между {min} и {max}: ");
            while (min <= max)
            {
                i += min;
                min++;
            }
            Console.Write($"{i} ");
        }

    }
}