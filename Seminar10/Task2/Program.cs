namespace pro
{
    class Prog
    {
        static void Main()
        {
            Console.WriteLine("Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз. " +
                "Дано число m. Выведите первые m членов этой последовательности.");
            Console.WriteLine();
            Console.WriteLine("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            MonotonicSequence(n,m,0);
        }
        public static void MonotonicSequence(int n, int m, int j)
        {
            
            do
            {
                for(int i = 0; i < n; i++)
                {
                    Console.Write(n + " ");
                    j++;
                    if (j >= m)
                    {
                        return;
                    }
                }
            
            MonotonicSequence(n+1, m, j);
            } while (n == m) ;              
        }
    } 
}
