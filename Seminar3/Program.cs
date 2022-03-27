using System;
    //Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
  
    class Palindr
{
       public static bool Palindromtest(string s)
       {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                {
                   return false;
                }
            }
            return true;

       }

    static void Main()
    {
        string s;
        Console.WriteLine("Анализ палиндромов\n\nВведите строку:");
        s = Console.ReadLine();
        if (Palindromtest(s))
            Console.WriteLine("Эта строка - палиндром");
        else Console.WriteLine("Эта строка - не палиндром");
        Console.ReadLine();
    }
}

    //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    Console.Write("Введите x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Введите y1: ");
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("Введите x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите y2: ");
    double y2 = double.Parse(Console.ReadLine());
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine($"Расстояние между точками: {result}");
     


    //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    Console.WriteLine("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    int j = 1;
    for (int i = 1; i <= j; j++)
    {
        if (j <= x)
        {
           Console.Write(Math.Pow(j, 3) + " ");
        }
    }