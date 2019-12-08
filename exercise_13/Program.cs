using System;

namespace exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите 5 чисел ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int average = (n1 + n2 + n3 + n4 + n5)/5;
            Console.WriteLine($"Среднее арифметическое {average} ");
            Console.ReadLine();
            /*Console.Write("введите n чисел ");
            int n = int.Parse(Console.ReadLine());
            int[] average = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"введите {i} элемент массива ");
                average[i] = int.Parse(Console.ReadLine());
                int result  = average[i] + average[i] / i;
                Console.WriteLine(average);
            }*/


        }
    }
}
