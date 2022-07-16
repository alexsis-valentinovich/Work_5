using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
//Определить сумму максимального и минимального элементов массива.
namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int[] array = new int[n];
            Random r = new Random();
            bool f = false;
            int max = 0;
            int sMax = 0;
            int kMax = 0;
            int min = 0; 
            int sMin = 0;
            int kMin = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(0,50);
                if (f == false)
                {
                    max = array[i];
                    min = array[i];
                    Console.WriteLine("{0}. {1}", i + 1, array[i]);
                    f = true;
                }
                else
                {
                    Console.WriteLine("{0}. {1}", i + 1, array[i]);
                    max = Math.Max(max, array[i]);
                    min = Math.Min(min, array[i]);
                }
            }

            foreach (int a in array)
            {
                if (a == max)
                {
                    kMax++;
                    sMax+=max;
                }
                if (a == min)
                {
                    kMin++;
                    sMin+=min;
                }
            }
            Console.WriteLine("Минимальное значение = {0}, кол-во = {1}, сумма = {2}", min, kMin, sMin);
            Console.WriteLine("Максимальное значение = {0}, кол-во {1}, сумма = {2}", max, kMax, sMax);
            Console.ReadKey();
        }
    }
}
