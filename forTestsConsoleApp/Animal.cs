using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTestsConsoleApp
{
    class Animal
    {
        //поля характеристики состояний объектов;
        private int mass = 0;
        private int height = 2;

        // методы поведение объектов
        public int GetMass()
        {
            return mass;
        }

        public int GetHeight()
        {
            return height;
        }

        public void Eat()
        {
            ++mass;
            
            height += 2;
    
        }

        public void MakeSound() { }

        public void Sleep() { }

        public void Run() { }

    } 
}

