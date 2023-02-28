using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрР1_Червов
{
    public class MatrixClass
    {
        public static int positiveElementsCounter(int m, int n)
        {
            int positiveNum = 0;
            double[,] matrix = new double[m,n];

            string matrixLines = "";

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Math.Sin(i + j / 2);

                    matrixLines += Convert.ToString(matrix[i, j]) + " | ";
                    if (matrix[i, j] > 0.0)
                    {
                        positiveNum += 1;
                    }              
                }
                Console.WriteLine(matrixLines);
                matrixLines = "";
            }

            Console.WriteLine($"Количество положительных элементов = {positiveNum}");
            return positiveNum;
        }
    }
}
