using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Теперь все в порядке;
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStatus();
                        
            //Использование get/set для взаимодействия с именами объектов;
            emp.SetName ("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());
            Console.ReadKey();
        }
    }
}
