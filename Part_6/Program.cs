using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами,
//вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. Магическим квадратом
//называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.
namespace Part_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];   // массив чисел пользователя
            int[] arrayStroki = new int[n]; // массив суммы строк
            int[] arrayStolb = new int[n];  // массив суммы столбцов
            int DiagL = 0;                  // суммы первой диагонали
            int DiagR = 0;                  // суммы второй диагонали
            int i;
            bool f = true;
            Console.WriteLine("Введите элементы массива"); // заполнение массива чисел пользователя
            for (i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    array[j, i] = m;
                    if ((i == n - 1) && (j == n - 2))
                        Console.WriteLine("Последний элемент");
                }
            }                                            // заполнение массива чисел пользователя
            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    arrayStroki[i] += array[j, i]; // вычесления суммы
                    arrayStolb[j] += array[j, i];
                    if (i == j)
                    {
                        DiagL += array[j, i];
                    }
                    if (i + j == n - 1)
                    {
                        DiagR += array[j, i];     // вычесления суммы
                    }
                    if (j == 0)   // печать суммы строк
                    {
                        Console.Write("          {0,3} ", array[j, i]);
                    }
                    else
                    {
                        Console.Write("  {0,3} ", array[j, i]);
                    }
                }
                Console.Write("  Сумма = {0,3} ", arrayStroki[i]);
            }                    // печать суммы строк
            Console.WriteLine(); // печать суммы столбцов
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write("  Сумма = {0,3} ", arrayStolb[i]);
                }
                else
                {
                    Console.Write("  {0,3} ", arrayStolb[i]);
                }
            }                   // печать суммы столбцов
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  Сумма диаг левая = {0}", DiagL);  // печать суммы диагоналей
            Console.WriteLine("  Сумма диаг правая = {0}", DiagR);  // печать суммы диагоналей
            if (DiagL == DiagR)
            {
                for (i = 0; i < n; i++)
                {
                    if ((DiagR != arrayStroki[i]) || (DiagR != arrayStolb[i]))
                    {
                        f = false;
                    }
                }
            }
            else
            {
                f = false;
            }

            Console.WriteLine();
            if (f == true)
            {
                Console.WriteLine("ПОЗДРАВЛЯЕМ.");
                Console.WriteLine("У вас МАГИЧЕСКАЯ матрица");
            }
            else
            {
                Console.WriteLine("ИЗВИНИТЕ.");
                Console.WriteLine("У вас простая матрица");

            }
            Console.ReadKey();
        }
    }
}
