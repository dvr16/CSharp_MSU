using System;

namespace ListDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Список Complex:");
            List complexList = new List();
            Complex complex1 = new Complex(12, 1);
            Complex complex2 = new Complex(2, 13);
            complexList.Add(complex1);
            complexList.Add(complex2);
            complexList.Add(new Complex(3, 15));
            complexList.Add(complex1);
            complexList.Add(new Complex(3, 6));
            complexList.Print();

            Complex complex3 = complexList[2];
            Console.WriteLine($"3-элемент списка {complex3}");
            Console.WriteLine("Удалили его");
            complexList.Remove(complex3);
            Console.WriteLine("Список после удаления");
            complexList.Print();

            Console.WriteLine("Удалили complex1 (удалился первый найденный элемент complex1)");
            complexList.Remove(complex1);
            complexList.Print();

            Console.WriteLine("Удалили new Complex(3, 6) (ничего не удалилось, ссылки разные)");
            complexList.Remove(new Complex(3, 6));
            complexList.Print();

            Console.ReadLine();
        }
    }
}

