using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SysoevDA.Sprint4.Task3.V1.Lib;

namespace Tyuiu.SysoevDA.Sprint4.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Сысоев Д.А | ПКТБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                            * ");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Сысоев Данил Алексеевич | ПКТБ-23-1                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Найдите сумму элементов  *");
            Console.WriteLine("* в последнем столбце массива. { { 3, 4, 3, 4, 1 }, { 8, 1, 6, 6, 9 },    *");
            Console.WriteLine("* { 9, 8, 5, 1, 3 }, { 1, 8, 7, 1, 2 }, { 9, 9, 7, 5, 6 } }               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");

            int[,] array = { { 3, 4, 3, 4, 1 },
                             { 8, 1, 6, 6, 9 },
                             { 9, 8, 5, 1, 3 },
                             { 1, 8, 7, 1, 2 },
                             { 9, 9, 7, 5, 6 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.Write($"Массив: \n {"{"} ");
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                Console.Write("\t { ");
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($" {array[i, j]}");
                    }
                    else
                    {
                        Console.Write($", {array[i, j]}");
                    }
                }
                if (i != rows-1)
                {
                    Console.Write(" },");
                }
                else
                {
                    Console.Write(" } ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" }");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма элементов в последнем столбце массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
