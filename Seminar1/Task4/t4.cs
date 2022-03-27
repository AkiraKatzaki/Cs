using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите первое число:");   // ввод данных
        var i = Console.ReadLine();
        Console.WriteLine("Введите второе число:");   // ввод данных
        var j = Console.ReadLine();
        Console.WriteLine("Введите третье число:");   // ввод данных
        var z = Console.ReadLine();

        int a = Convert.ToInt32(i);   // конвертация из string в int
        int b = Convert.ToInt32(j);   // конвертация из string в int
        int c = Convert.ToInt32(z);   // конвертация из string в int

        if (a > b)
            if (a > c)
                Console.WriteLine($"Самое большое число{a}");
            else
                 if (b > c)
                Console.WriteLine($"Самое большое число{b}");
            else
                Console.WriteLine($"Самое большое число{c}");

    }
}
