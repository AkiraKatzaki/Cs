
//Вариант 1

int reverse = 0, rem;
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 0)
{
    rem = n % 10;
    reverse = reverse * 10 + rem;
    n /= 10;
}
Console.WriteLine($"Число с цифрами в обратном порядке:, { reverse }");


//Вариант 2

int num, reverseNumber = 0;
do
{
    Console.WriteLine("input number");
} while (!int.TryParse(Console.ReadLine(), out num));
while (num > 0)
{
    reverseNumber = reverseNumber * 10 + num % 10;
    num /= 10;
}
Console.WriteLine(reverseNumber);
Console.ReadKey(true);
