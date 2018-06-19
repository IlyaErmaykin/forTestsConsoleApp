using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
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
            Console.WriteLine("90 + 90 = {0}", ans);

            Console.ReadKey();
        }
    }
}
