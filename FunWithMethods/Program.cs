using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        // По умолчанию аргументы передаются по значению
        static int Add(int x, int y)
        {
            int ans = x + y;

            //Вызывающий код не увидит эти изменения 
            // т.к. изменяется копия исходных данных.
            x = 10000;
            y = 88888;

            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Method *****\n");

            //Передать две переменных по значению
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

            Console.Read();
        }
    }
}
