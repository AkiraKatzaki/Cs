
Console.WriteLine("Введите число: ");
var n = Convert.ToInt32(Console.ReadLine());


if (n <= 99)
{
    Console.WriteLine("Введите хотябы трехзначное число");
}
else
    while (n >= 1000)
        n /= 10;
    if (n <= 999)
{
    n %= 10;
    Console.WriteLine($"Третья цифра числа: {n} ");
}
