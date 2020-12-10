using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp2
{
    public class Fish : Animal
    {
        /// <summary>
        /// Class of Fish
        /// </summary>
        public string Color;
        public Fish(string name) : base(name)
        {
            _name = name;
            Name = "Карп";
            Weight = 16;
            Age = 6;
            Color = "Зеркальный";
        }
        public virtual void Fisher()
        {

            Console.WriteLine($"{Color} {Name} весит {Weight} килограммов и ему {Age} лет");
            Console.WriteLine($"{Color} {Name} довольно редкий, но вкусный");
        }
        /// <summary>
        /// Transform Fish characteristics to string
        /// </summary>
        /// <returns>String like "Name:{Color} {Name}, age: {Age}, weight: {Weight}";"</returns>
        public override string ToString()
        {
            return $"Имя: {Name}, возраст: {Age}, вес: {Weight}.";
        }


    }
}
