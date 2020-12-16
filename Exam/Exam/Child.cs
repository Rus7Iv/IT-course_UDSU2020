using System;
using System.Collections.Generic;
using System.Text;

namespace Exam // Ребёнок
{
    class Child : Score
    {
        public string Name; // Имя ребёнка
        public int Age; // Возраст ребёнка
        public  Child_Score[] Points = { } ;

        public Child(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int[] All_Points()
        {
            int[] s = { };
            for (int i = 0; i < Points.Length; i++)
            {
                Array.Resize(ref s, s.Length + 1);
                s[i] = Points[i].Number_;
            }
            return s;
        }
        public int Sum_Points()
        {
            int sum = 0;
            for (int i = 0; i < Points.Length; i++)
            {
                sum += Points[i].Number_;
            }
            return sum;
        }
        public void Add_Point(Point i)
        {
            if (i is Child_Score)
            {
                Child_Score a = i as Child_Score;
                Array.Resize(ref Points, Points.Length + 1);
                Points[Points.Length-1] = a;
            }
        }

        public override string ToString() // Характеристика ребёнка
        {
            return $"{this.Name}, ребёнок, {this.Age} лет";
        }

    }
}
