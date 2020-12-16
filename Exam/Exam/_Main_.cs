/* Реализовать архитектуру ачивок в детском саду

Из классов я должна получить ответы на вопросы: 
Сколько наград выдано за период.
Сколько получил ачивок воспитатель или ребенок.

Ребенок и воспитатели могут получать награды.
Должен быть один метод, который добавляет награду в массив ребенка или воспитателя.
Должна быть проверка что ребенок получает детский награды, а взрослый взрослые.
Свойство должно возвращать статус воспитателя. Бронзовый, золотой, платиновый в зависимости от того сколько у него наград.

Реализовать заполнение награждения через цикл. в котором значения берутся рандомно через Random.Next()

    Автор: Иванов Р.
    Дата: 16.12.20  */

using System;

namespace Exam // Зачётная работа
{
    class _Main_
    {
        static void Main(string[] args)
        {
            Caregiver person1 = new Caregiver("Роман Сергеевич", 30); // Воспитатель
            Child person2 = new Child("Дима", 7); // Ребёнок
            Console.WriteLine("     Добро пожаловать в детский сад \"Ручеёк\"!");
            Random rnd = new Random((int)DateTime.Now.Ticks);
            Console.WriteLine(person1.ToString()); // Вывод характеристики воспитателя
            Console.WriteLine(person2.ToString()); // Вывод характеристики ребёнка
            for (int i = 0; i < 6; i++) 
            {
                int i1 = rnd.Next(1, 5); // награды воспитателя
                int i2 = rnd.Next(1, 5); // награды ребёнка
                Caregiver_Point j1 = new Caregiver_Point(i1);
                Child_Score j2 = new Child_Score(i2);
                person1.Add_Point(j1);
                person2.Add_Point(j2);
            }
            //===============================
            //Награды воспитателя
            Console.WriteLine();
            int[] s1 = person1.All_Points();
            Console.Write("Награды воспитателя: ");
            Console.Write("( ");
            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[i]);
                Console.Write(' ');
            }
            Console.WriteLine(")");
            Console.Write("Число наград: ");
            Console.WriteLine(person1.Sum_Points());
            Console.WriteLine($"Ранг воспитателя: {person1.Point_Level()}");

            //===============================
            // Награды ребёнка
            int[] s2 = person2.All_Points();
            Console.WriteLine();
            Console.Write("Награды ребёнка: ");
            Console.Write("( ");
            for (int i = 0; i < s2.Length; i++)
            {
                Console.Write(s2[i]);
                Console.Write(' ');
            }
            Console.WriteLine(")");
            Console.Write("Сумма наград ");
            Console.WriteLine(person2.Sum_Points());
        }
    }
}
