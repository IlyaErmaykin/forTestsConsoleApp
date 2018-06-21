using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading
{
    class Program
    {
        /// <summary>
        /// Перегрузка методов
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Method Overloading *****\n");

            // Вызов int-версии Add();
            Console.WriteLine(Add(10, 10));

            // Вызов long-версии Add();
            Console.WriteLine(Add(90000000000, 90000000000));

            // Вызов double-версии Add();
            Console.WriteLine(Add(4.3, 4.4));

            Console.ReadKey();
        }

        /// <summary>
        /// Перегруженный метод Add()
        /// </summary>
        /// <param name="x">Параметр типа int</param>
        /// <param name="y">Параметр типа int</param>
        /// <returns></returns>
        static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Перегруженный метод Add()
        /// </summary>
        /// <param name="x">Параметр типа double</param>
        /// <param name="y">Параметр типа double</param>
        /// <returns></returns>
        static double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Перегруженыый метод Add()
        /// </summary>
        /// <param name="x">Параметр типа long</param>
        /// <param name="y">Параметр типа long</param>
        /// <returns></returns>
        static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
