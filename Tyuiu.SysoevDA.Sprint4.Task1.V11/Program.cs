using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SysoevDA.Sprint4.Task1.V11.Lib;

namespace Tyuiu.SysoevDA.Sprint4.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Сысоев Д.А | ПКТБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Сысоев Данил Алексеевич | ПКТБ-23-1                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 6 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива. С клавиатуры: 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, *");
            Console.WriteLine("* 6, 6, 1, 6                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");

            int len;
            Console.WriteLine("Введите количество элементов: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];

            for(int i = 0; i <= len - 1; i++)
            {
                Console.Write($"Введите значение {i} элемента массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Массив = {");
            for (int element = 0; element < array.Length; element++)
            {
                if (element == 0)
                {
                    Console.Write($" {array[element]}");
                }
                else
                {
                    Console.Write($", {array[element]}");
                }
            }
            Console.WriteLine(" }");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество четных элементов = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
