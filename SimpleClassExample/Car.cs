using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //"Состояние" объекта Car;
        public string petName;
        public int currSpeed;

        /// <summary>
        /// Специальный стандартный конструктор;
        /// </summary>
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //  currSpeed получает стандартное значеие для типа int (0);
        public Car(string pn)
        {
            petName = pn;   
        }

        //Позволяет вызывающему коду установить полное состояние Car
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        /// <summary>
        /// Функциональность класса Car;
        /// </summary>
        public void printState()
        {
            Console.WriteLine("{0} is going {1} MPH", petName, currSpeed);
        }

        /// <summary>
        ///  Method for speed changes
        /// </summary>
        /// <param name="delta"></param>
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
