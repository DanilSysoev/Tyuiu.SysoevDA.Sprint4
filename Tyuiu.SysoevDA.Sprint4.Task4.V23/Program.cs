using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SysoevDA.Sprint4.Task4.V23.Lib;

namespace Tyuiu.SysoevDA.Sprint4.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Сысоев Д.А | ПКТБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Сысоев Данил Алексеевич | ПКТБ-23-1                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8. Найдите сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцев в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rows, columns];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива: ");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

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
                if (i != rows - 1)
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

            Console.WriteLine("Сумма нечетных элементов массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
