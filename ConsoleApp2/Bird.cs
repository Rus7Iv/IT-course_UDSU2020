using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Bird : Animal, InterfaceAge
    {
        /// <summary>
        /// Class of Bird
        /// </summary>
        public string Vid;
        public Bird(string name) : base(name)
        {
            _name = name;
            Name = "Горец";
            Vid = "Орел ";
            Weight = 66;
            Age = 16;
        }

        public void Liv()
        {
            Age = 20;
        }

        public virtual void War()
        {

            Console.WriteLine($"{Vid} {Name} весит {Weight} килограммов и ему {Age} лет");
            Console.WriteLine($"{Vid} {Name} очень быстрый");
        }
        /// <summary>
        /// Transform Bird characteristics to string
        /// </summary>
        /// <returns>String like "Name: {Vid}{Name}, age: {Age}, weight: {Weight}.";"</returns>
        public override string ToString()
        {
            return $"Имя: {Name}, возраст: {Age}, вес: {Weight}.";
        }
    }
}
