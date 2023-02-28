using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрР1_Червов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrixClass.positiveElementsCounter(4,5);
            Console.ReadLine();
            MatrixClass.positiveElementsCounter(2,4);
            Console.ReadLine();
            MatrixClass.positiveElementsCounter(1,7);
            Console.ReadLine();
            MatrixClass.positiveElementsCounter(3,3);
            Console.ReadLine();
        }
    }
}
