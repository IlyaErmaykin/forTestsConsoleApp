using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        //Ссылочные параметры
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
        
        //Возврат множества выходных методов
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }
        
        // Значениея выходных параметров должны быть установлены вызвваемым методом.
        static int Add(int x, int y, out int ans)
        {
            ans = x + y;

            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Method *****\n");

            // Присваиваем начальные значения локальныи переменным,
            // используеммым как выходные параметры, не обязательно,
            // при условии, что в таком качестве они используются первый раз.
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0} \n", ans);

            //Возврат множества выходных методов
            int i; string str; bool b;
            FillTheseValues(out i, out str, out b);

            Console.WriteLine("int is: {0}", i);
            Console.WriteLine("String is: {0}", str);
            Console.WriteLine("Boolean is: {0} \n", b);

            //Ссылочны параметры
            string str1 = "Flip";
            string str2 = "Flop";
            
            Console.WriteLine("Before: {0}, {1}", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {1}", str1, str2);
            
            Console.ReadKey();
        }
    }
}
