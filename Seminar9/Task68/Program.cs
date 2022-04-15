namespace pro
{
    class Prog
    {
        static void Main()
        {
            Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. ");
            Console.WriteLine();
            Console.Write("Введите значение m: \t");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение n: \t");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AckermannFunc(m, n));
            Console.WriteLine(i);
        }

        public static int i = 0;
        public static int AckermannFunc(int m, int n) 
        {
            i++;
            if (m == 0)
                return n + 1;
            if (m > 0)
                if (n == 0)
                    return AckermannFunc(m - 1, 1);
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }

    
    }
}