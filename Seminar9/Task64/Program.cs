namespace pro 
{ 
    class Prog 
    {
        static void Main()
        {
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.");
            Console.WriteLine();
            Console.Write("Введите минимальное значение: \t");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное значение: \t");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write($"В промежутке между {min} и {max} следующие числа кратны 3: \t");
            while (min <= max)
            {
                if (min % 3 == 0)
                {
                    int i = min / 3;
                    Console.Write($"{min} ");
                }
                min++;
            }
        }
        
    }
}