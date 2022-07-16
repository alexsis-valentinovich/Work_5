using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Обязательная задача*. Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры,
//определить среднее арифметическое элементов.
namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] array = new int[n];
            float s = 0;
            Console.WriteLine("Введите семь произвольных чисел");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int a in array)
            {
                s += a;
            }
                Console.WriteLine("Cреднее арифметическое всех чисел ={0:f2}", s / n);
            Console.ReadKey();
        }
    }
}
