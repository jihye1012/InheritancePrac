using System;
using System.Dynamic;

namespace InheritancePrac
{
    internal class Dog : Animal
    {
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }
    }
}