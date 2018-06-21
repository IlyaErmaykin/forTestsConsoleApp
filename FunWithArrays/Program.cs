using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    /// <summary>
    /// Массивы в C#
    /// </summary>
    class Program
    {
        /// <summary>
        /// Создание массива с элементами типа int
        /// </summary>
        static void SipleIntArray()
        {
            Console.WriteLine("=> Simple Array Creation");
            // Создать массив int, сдержащий 3 элемента с индексами 0, 1, 2
            int [] myInts = new int [3];
            //Заполнение массива
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        static void SipleStringArray()
        {
            Console.WriteLine("=> Simple Array Creation");
             // Создать массив string, содержащий 100 элементов с индексом 0-99
            string[] booksOnDotNet = new String[100];
            
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrys *****");
            SipleIntArray();
            SipleStringArray();

            Console.ReadKey();
        }
    }
}
