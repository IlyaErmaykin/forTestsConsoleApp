﻿using System;
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
            //Ошибка, невозможно обратиться к закрытым полям объекта;
            Employee emp = new Employee();
            //emp.empName = "Marv";
        }
    }
}
