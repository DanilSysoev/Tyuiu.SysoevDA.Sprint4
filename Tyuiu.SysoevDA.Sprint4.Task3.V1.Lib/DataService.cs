using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SysoevDA.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int s = 0;
            for (int i = rows - 1; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    s += array[i, j];
                }
            }
            return s;
        }
    }
}
