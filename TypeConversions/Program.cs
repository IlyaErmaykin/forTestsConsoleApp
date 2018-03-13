using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TypeConversions
{
    class Program
    {
        /// <summary>
        /// Сужающие и расширяющие типы данных
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with type conversations ****");

            //Добавить 2 переменные типа short и вывести резульятат;
            //short numb1 = 9, numb2 = 10;

            //Console.WriteLine("{0}+ {1} = {2}", numb1, numb2, Add(numb1, numb2));

            short numb1 = 30000, numb2 = 30000;

            //Вызов ошибки комниляции;
            //short answer = Add(numb1, numb2);

            //Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

            //Явное прведение int к short(с разрешением потери данных)
            short answer = (short)Add(numb1, numb2);

            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            //NarrowingAttempt();
            ProcessButes();

            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Явное приведение типов
        /// </summary>
        private static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;

            //Явно привести int к byte (без потери данных);
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        ///// <summary>
        ///// Ключевое слово Checked
        ///// </summary>
        //private static void ProcessButes()
        //{0
        //    byte b1 = 100;
        //    byte b2 = 250;
        //    byte sum = (byte)Add(b1, b2);

        //    //В sum должно сдержаться значение 350. Однако там оквзывается значение94!
        //    Console.WriteLine("sum = {0}", sum);
        //}
    }
}
