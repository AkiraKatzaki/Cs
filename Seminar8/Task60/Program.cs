namespace Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу, которая построчно выведет элементы и их индексы.");
            Console.WriteLine();
            Console.WriteLine("Введите размеры массива: ");
            int[,,] vs = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            int[] array = new int[10];
            Random r = new Random();
            int n = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = r.Next(10, 100);
                n = array[i];
                if (i >= 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        while (array[i] == array[j])
                        {
                            array[i] = r.Next(10, 100);
                            j = 0;
                            n = array[i];
                        }

                        n = array[i];
                    }
                }
            
                Console.Write(array[i] + " ");
            }

            static int[,,] Array3D(int[] array)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        for (int k = 0; k < z; k++)
                        {
                                
                        }
                    }
                }
            }
            
                                   
        }
    }
}