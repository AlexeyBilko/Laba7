using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] B = Init();
            Func(B);
        }

        static double[] Init()
        {
            Console.Write("Enter count of number in array: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int count = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            double[] array = new double[count];
            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                array[i] = rand.Next(-100, 100) + rand.NextDouble(); 
            }

            PrintArray(array);
            return array;
        }

        static void PrintArray(double[] array)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (var item in array)
            {
                Console.WriteLine("{0:0.000}", item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        static void Func(double[] array)
        {
            double max = Math.Abs(array[0] - array[1]);
            double min = Math.Abs(array[0] - array[1]);

            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    if (Math.Abs(array[i] - array[i + 1]) > max)
                    {
                        max = Math.Abs(array[i] - array[i + 1]);
                    }
                    if (Math.Abs(array[i] - array[i + 1]) < min)
                    {
                        min = Math.Abs(array[i] - array[i + 1]);
                    }
                }
            }

            Console.WriteLine($"The largest value of the modulus of the difference between adjacent elements: {max}");
            Console.WriteLine($"The smallest value of the modulus of the difference between adjacent elements: {min}");
        }
    }
}
