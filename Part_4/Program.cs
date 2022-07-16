using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4. Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество
//нечетных положительных элементов, стоящих на четных местах.
namespace Part_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] array = new int[n];
            Random r = new Random();
            int k = 0;
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(-50, 50);
                Console.WriteLine("{0}. {1}", i, array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            Console.WriteLine("Четные места");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    k++;
                    Console.WriteLine("{0}. {1}", i, array[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Четные места и нечетные элементы");
            for (int i = 0; i < n; i++)
            {
                if ((i % 2 == 0) && (array[i] % 2 != 0))
                {
                    k++;
                    Console.WriteLine("{0}. {1}", i, array[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Четные места и нечетные, положительные элементы");
            for (int i = 0; i < n; i++)
            {
                if ((i%2==0) && (array[i] % 2 != 0) && (array[i] >0))
                {
                        k++;
                        Console.WriteLine("{0}. {1}", i, array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
