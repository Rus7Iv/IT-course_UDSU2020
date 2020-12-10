using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Animal: InterfaceRun
    {
        /// <summary>
        /// Base class of all animals
        /// </summary>
        public string _name;
        public string Name;
        public int Weight;
        public int Age;

        int InterfaceRun.Age
        {
            get
            {
                Age = 10;
                return Age;
            }
            set
            {

            }
        }
        int InterfaceRun.Weight
        {
            get
            {
                return Weight;
            }
            set
            {

            }
        }
        public Animal(string name)
        {
            _name = name;
        }
        
        public virtual void Option()
        {

            Console.WriteLine($"{Name} весит {Weight} килограммов и ему {Age} лет");
            Console.WriteLine($"{Name} очень быстро бегает");
        }
        
        public void Live()
        {
            Age++;

        }

        public void Eat()
        {
            Weight++;
        }
    }
}
