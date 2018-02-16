using ForTestsConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTestsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Pushok = new Animal();
            Animal Tuzik = new Animal();
            Pushok.Eat();
            Pushok.Eat();
            Pushok.Eat();
            Tuzik.Eat();

            Console.WriteLine("{0}, {1}", Pushok.GetMass(), Pushok.GetHeight());
            Console.WriteLine("{0}, {1}", Tuzik.GetMass(), Tuzik.GetHeight());
            
            Console.ReadKey();
        }
    }
}
