using System;

namespace Task41
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
            Console.WriteLine();
            string[] array;
            int count;
            string s;
            string[] array2;
            int[] array3;

            Console.WriteLine("Enter strings:");

            count = 0;
            array = new string[count];

            do
            {
                s = Console.ReadLine();
                if (s != "")
                {
                    count++;
                    array2 = new string[count];
                    for (int i = 0; i < array2.Length - 1; i++)
                        array2[i] = array[i]; 
                    array2[count - 1] = s;
                    array = array2;
                }
            } while (s != "");

            array3 = new int[count];
            int j = 0;

            for (int i = 0; i < array3.Length; i++)
            {
               array3[i] = Convert.ToInt32(array[i]);
            }

            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] > 0)
                {
                    j++;
                }
                
            }
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}




