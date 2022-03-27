using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите первое число:");
        var i = Console.ReadLine();
        Console.WriteLine("Введите второе число:");
        var j = Console.ReadLine();
        int a = Convert.ToInt32(i);
        int b = Convert.ToInt32(j);

        if (a > b)
           Console.WriteLine($" Число {a} больше числа {b} ");
        else
           Console.WriteLine($" Число {b} больше числа {a} ");

    } 
}
