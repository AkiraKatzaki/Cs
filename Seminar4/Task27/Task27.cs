Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine();


        Console.WriteLine("Введите число: ");
        string x = Console.ReadLine();
        int sum = 0;
        int index = 0;
        int i = x.Length - 1;

        if (i > 0)
        {
            sum += x[index];
            index++;
            i--;
        }
        else
        {
            Console.WriteLine(sum);
        }