using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN
//следующего вида:

//1 0 1 0 1

//0 1 0 1 0

//1 0 1 0 1

//0 1 0 1 0

//1 0 1 0 1
namespace Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            int i;
            for (i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i == j) || (i + j == n-1))
                    {
                        array[j,i] = 1;
                    }
                    else
                    {
                        array[j,i] = 0;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("  {0} ", array[j, i]);
                    }
                    else
                    {
                        Console.Write("{0} ", array[j, i]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
