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
        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            //а -  на самом деле int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            //b - на самом деле double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a:{0}", b.ToString());

            //c - на самом деле string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a:{0}", c.ToString());
            Console.WriteLine();
        }
        
        /// <summary>
        /// Разбор синтаксиса иницмализации массивов 
        /// </summary>
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization");

            // Синтаксис инициализации массива с использованием ключевого слова new
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Синтаксис инициализации массива без ипользования ключевого слова new
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //Синтаксис инициализации массива с использованием ключевого слова new и размера
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);

            Console.WriteLine();

        }

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
            //SipleIntArray();
            //SipleStringArray();
            //ArrayInitialization();
            DeclareImplicitArrays();

            Console.ReadKey();
        }
    }
}
