using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        /// <summary>
        ///  метод funcCarForHenry описывает несколько вариантов объявление экземплярв классов;
        /// </summary>
        static public void funcCarForHenry()
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            //Разместить в памяти и сконфигурировать объект Car;
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            //Альтернативное объявление экземпляра класса Car;
            //Car myCar;
            //myCar = new Car();
            //myCar.petName = "Fred";

            //Увеличитm скорость автомобиля в несколько раз и вывести новое сообщение;
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.printState();
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Метод funcCarForChuck для вызова стандортного констуктора;
        /// </summary>
        static public void funcCarForChuck()
        { 
            Console.WriteLine("***** Fun the Class Types *****\n");
            
            // Создат объект Car по имени Chuck со скоростью 10 миль в час;
            Car chuck = new Car();
            chuck.printState();

            // Создать объект Car по имени Mery со скоростью 0 миль в час;
            Car mery = new Car("Mary");
            mery.printState();

            // Создать объект Car по имени Daisy со скоростью 75 миль в час;
            Car daisy = new Car("Daisy", 75);
            daisy.printState();
        }

        /// <summary>
        /// Вызов функций
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            funcCarForHenry();
            funcCarForChuck();
            
            Console.ReadKey();
        }
    }
}
