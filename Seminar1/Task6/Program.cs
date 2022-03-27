using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine($"Введите число: ");
        var i = Console.ReadLine();
        int a = Convert.ToInt32(i);

        if (a % 2 == 0)
            Console.WriteLine("Число четное");
        else
            Console.WriteLine("Число не четное");
    }
}