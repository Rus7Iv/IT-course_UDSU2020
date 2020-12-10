using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    class ConsoleApp2
    {

        static void Main(string[] args)
        {

            var Tigr = new Tiger("Tigril");

            var Karp = new Fish("Karp");
            var Mediv = new Bird("Mediv");
            Animal[] an = new Animal[] { Tigr, Karp, Mediv };
            Console.WriteLine("     Добро пожаловать в наш зоопарк! ");
            Mediv.Liv();
            Tigr.Eat();
            Karp.Live();
            for (int i = 0; i < an.Length; i++)
            {
                Console.WriteLine(an[i].ToString());

            }
            Console.WriteLine("     После применения интерфейсов ");

            Mediv.War();
            Tigr.Option();
            Karp.Fisher();

            for (int i = 0; i < an.Length; i++)
            {
                Console.WriteLine(an[i].ToString());

            } 
        }

    }
}
