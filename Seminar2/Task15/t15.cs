//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Выберите день недели из списка введя соответствующую цифру: ");
Console.WriteLine("1 - Понедельник");
Console.WriteLine("2 - Вторник");
Console.WriteLine("3 - Среда");
Console.WriteLine("4 - Четверг");
Console.WriteLine("5 - Пятница");
Console.WriteLine("6 - Суббота");
Console.WriteLine("7 - Воскресенье");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Ошибка ввода данных"); 
}
else
    if (n > 7) 
{
    Console.WriteLine("Ошибка ввода данных");
}
else 
    if (n >= 6) 
{
    Console.WriteLine("Выходной");
}
else 
    if (n < 6) 
{
    Console.WriteLine("Будни");
}
