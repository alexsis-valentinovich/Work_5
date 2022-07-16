using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить
//по возрастанию, вторые 5 – по убыванию.
namespace Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] array = new int[n];
            Random r = new Random();
            int s = 0;
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(-50, 50);
                if (i == n / 2)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив");
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    for (int j = i + 1; j < n / 2; j++)
                    {
                        if (array[i] > array[j])
                        {
                            s = array[i];
                            array[i] = array[j];
                            array[j] = s;
                        }
                    }
                }
                else
                {
                    for (int j = i; j < n; j++)
                    {
                        if (array[i] < array[j])
                        {
                            s = array[i];
                            array[i] = array[j];
                            array[j] = s;
                        }
                    }
                }
                if (i == n / 2)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("{0}. {1}", i + 1, array[i]);
            }
            Console.ReadKey();
        }
    }
}
