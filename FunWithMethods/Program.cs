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

        // Модификатор param        
        // Возвращение среднего из некоторого количства значений double
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            
            double sum = 0;
            
            if (values.Length == 0)
            {
                return sum;
            }
            
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            
            return (sum / values.Length);
        }

        // Определение необязательных параметров
        static void EnterLogData(string message, string owner = "Programmer")
        // Значение, присваемое необязательному параметру должно быть изместно во время компиляции
        // и не может вычисляться во время выполнения (на этапе компиляции будет сообщене об ошибке)
        //static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp = DateTime.Now)
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
            // Сообщение об ошибке
            //Console.WriteLine("Time of Error: {0}", timeStamp);
        }

        // Вызов меотодов с использованием именованных параметров
        static void DisplayFrancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        { 
            // Сохранить старые цвета с целью их восстановлния после вывода сообщения
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;

            // Устновить новые цвета и вывести сообщение
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            //Восстановить предыдущие цвета
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Fun with Method *****\n");

            //// Присваиваем начальные значения локальныи переменным,
            //// используеммым как выходные параметры, не обязательно,
            //// при условии, что в таком качестве они используются первый раз.
            //int ans;
            //Add(90, 90, out ans);
            //Console.WriteLine("90 + 90 = {0} \n", ans);

            ////Возврат множества выходных методов
            //int i; string str; bool b;
            //FillTheseValues(out i, out str, out b);

            //Console.WriteLine("int is: {0}", i);
            //Console.WriteLine("String is: {0}", str);
            //Console.WriteLine("Boolean is: {0} \n", b);

            ////Ссылочны параметры
            //string str1 = "Flip";
            //string str2 = "Flop";
            
            //Console.WriteLine("Before: {0}, {1}", str1, str2);
            //SwapStrings(ref str1, ref str2);
            //Console.WriteLine("After: {0}, {1}", str1, str2);

            // Передать разделяемый запятыми список значений double...
            //double average;
            //average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            //Console.WriteLine("Average of data is: {0}", average);

            //// ...или передать масссив значений double
            //double[] data = { 4.0, 3.2, 5.7 };
            //average = CalculateAverage(data);
            //Console.WriteLine("Average of data is: {0}", average);

            ////Средний из 0 ровно 0!
            //Console.WriteLine("Average of data is: {0}", CalculateAverage());

            //// Определение необязательных параметров
            ////Вызов EnterLogData двумя способами
            //EnterLogData("Oh no! Grid can't find data");
            //EnterLogData("Oh no! I can't find the payroll data", "CFO");

            DisplayFrancyMessage(message: "Wow! Very Fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);

            DisplayFrancyMessage(backgroundColor: ConsoleColor.Green,
                message: "Testing...",
                textColor: ConsoleColor.DarkBlue);
            
            Console.ReadKey();  
        }
    }
}
