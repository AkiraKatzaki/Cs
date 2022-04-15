namespace pro
{
    class Prog
    {
        static void Main()
        {
            Console.WriteLine("Дано натульное число n > 1. Вывести все простые множители данного числа.");
            Console.WriteLine();
            Console.WriteLine("Введите число больше 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 2;
            SearchMultiplier(n, m);
        }
        public static void SearchMultiplier(int n,int m)
        {
            while (n > m)
            {
                int i = n % m;
                if (i == 0)
                {
                    Console.Write(m + " ");
                }
                m++;
            }
        }
    }
}

