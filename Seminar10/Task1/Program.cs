namespace pro
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано число n. Получите число, записанное в обратном порядке.");
            Console.WriteLine();
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Coup(a, 0, 0); 
        }
        public static int Coup(int a,int b, int i)
        {   
            b = a % 10;
            i += b;
            a /= 10;
            i *= 10;            
            while (a > 0)
            {
                Coup(a, b, i);
                return i;
            }
            i/=10;
            Console.WriteLine("Ваше число на оборот ;)");
            Console.WriteLine(i);
            return i;
        }
    }
}