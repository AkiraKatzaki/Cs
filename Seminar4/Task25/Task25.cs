
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.");
Console.WriteLine();

Console.WriteLine("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write($"{a} в степени {b} = ");
Console.WriteLine(Math.Pow(a, b));