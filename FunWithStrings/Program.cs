using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FunWithStrings
{
    class Program
    {
        /// <summary>
        /// Базовые строковые манипуляции 
        /// </summary>
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=>Basic String functionality:");
            string firstName = "Freddy";

            //значение firstName; 
            Console.WriteLine("Value of firstName: {0}", firstName);

            //Длина firstName;
            Console.WriteLine("firstName has {0} characters.", firstName.Length);

            //firstName в верхнем регистре;
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());

            //firstName в нижнем регистре;
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());

            //Содержит ли firstName букву "y"?
            Console.WriteLine("firstName Contains theLetter 'y'?: {0}", firstName.Contains("y"));

            //firstName после замены
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }

        /// <summary>
        /// Конкатенация строк(сцепление переменных типа string при помощи операции "+")
        /// </summary>
        static void StringConcatenation()
        {
            Console.WriteLine("=>String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PhuchjDrill (PTP)";
            //string s3 = s1 + s2; //Первый вариант;
            string s3 = String.Concat(s1, s2); //Второй вариант;
            //Console.WriteLine(s1 + "+ " + s2 + " = " + s3); //Первый вариант;
            Console.WriteLine(s3); //Второй вариант;
            Console.WriteLine();

        }

        /// <summary>
        /// Система выдавет звуковой сигнал
        /// </summary>
 
        static void MakeSound()
        {
            Console.WriteLine("\a");
        }

        /// <summary>
        /// Добавление дословных строк
        /// </summary>
        static void UseVerbatimString()
        {
            // При использовании дословных строк пробельные символы предохраняются,
            string myLongString = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(myLongString);
        }

        /// <summary>
        /// Выполнение прверки на предмет равенства ссылочного типа 
        /// </summary>
        private static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello";
            string s2 = "Yo!";

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine("\a");

            // Проверить строки на предмет равенства
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
        }

        /// <summary>
        /// Изменение первоначального значения типа string
        /// </summary>
        private static void StringAreImmutable()
        {
            //Установить первоначальное значение две строки
            string s1 = "This id my string";
            Console.WriteLine("s1 = {0}", s1);

            //Преобразовать s1 в верхний регистр?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            //Нет! s1 по-преджнему остается в том же формате!
            Console.WriteLine("s1 ={0}", s1);
        }

        /// <summary>
        /// Операция присвоения
        /// </summary>
        private static void StringAreImmutable2()
        {
            string s2 = "My other string";
            Console.WriteLine("s2: {0}", s2);
            s2 = "New string value";
            Console.WriteLine("new s2: {0}", s2);
        }

        /// <summary>
        /// Обзор типа System.Text.StringBuilder
        /// </summary>
        private static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StirngBuilder:");
            StringBuilder sb = new StringBuilder("****Fantastic Games**** \n");
            sb.Append("Half Live, ");
            sb.Append("Morrowind, ");
            sb.Append("Deu Ex " + "2    , ");
            sb.Append("System Shock, ");
            Console.WriteLine(sb.ToString());
            sb.Replace("2, ", "Invisible War, ");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars ", sb.Length);
            Console.WriteLine("\a");
        }

        /// <summary>
        /// Вызов
        /// </summary>
        static void Main()
        {
            //BasicStringFunctionality();
            //StringConcatenation();
            //MakeSound();
            //UseVerbatimString();
            //StringEquality();
            //StringAreImmutable();
            //StringAreImmutable2();
            FunWithStringBuilder();

            Console.ReadKey();
        }
    }
}
