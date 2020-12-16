using System;
using System.Collections.Generic;
using System.Text;

namespace Exam // Воспитатель
{
    class Caregiver : Score
    {
        public string Name; // Имя воспитателя
        public int Age; // Возраст воспитателя
        public Caregiver_Point[] Points = { };

        public Caregiver(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public int[] All_Points()
        {
            int[] s = { };
            for(int i = 0; i < Points.Length; i++)
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
        public string Point_Level()
        {
            string s = "";
            if (this.Sum_Points() >= 8)
                s = "Средний";
            if (this.Sum_Points() >= 15)
                s = "Выше среднего";
            if (this.Sum_Points() >= 18)
                s = "Высокий";
            return s;
        }
        public void Add_Point(Point i)
        {
            if (i is Caregiver_Point)
            {
                Caregiver_Point a = i as Caregiver_Point;
                Array.Resize(ref Points, Points.Length + 1);
                Points[Points.Length-1] = a;
            }
        }

        public override string ToString() // Характеристика воспитателя
        {
            return $"{this.Name}, воспитатель, {this.Age} лет";
        }
    }
}
