using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Поля данных;
        private string empName;
        private int empID;
        private float currPay;

        // Создание конструкторов;
        public Employee();
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }

        // Методы;
        /// <summary>
        /// Give bonus
        /// </summary>
        /// <param name="amount"></param>
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        /// <summary>
        /// Display status
        /// </summary>
        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
