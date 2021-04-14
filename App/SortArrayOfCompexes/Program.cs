using System;

// Сортировка массива произвольного класса (Complex)

namespace SortArrayOfCompexes
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            Complex[] complexes = new Complex[10];

            for (int i = 0; i < complexes.Length; i++)
            {
                complexes[i] = (new Complex(random.Next(100), random.Next(100)));
            }

            Console.WriteLine("До сортировки:");
            for (int i = 0; i < complexes.Length; i++)
            {
                Console.WriteLine(complexes[i]);
            }

            // Поскольку класс Complex реализует интерфейс IComparable<T>,
            // метод Sort знает как сравнивать два экземпляра класса Complex и поэтому может сортировать
            Array.Sort(complexes);

            Console.WriteLine("После сортировки:");
            for (int i = 0; i < complexes.Length; i++)
            {
                Console.WriteLine(complexes[i]);
            }

            Console.ReadKey();
        }
    }

    class Complex : IComparable<Complex>
    {
        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public double Re { get; set; }
        public double Im { get; set; }

        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }

        // Реализация интерфейса IComparable<T>
        public int CompareTo(Complex other)
        { // для примера, будем считать, что комплексные числа сравниваются по действительной части
            if (Re > other.Re) return 1;
            if (Re < other.Re) return -1;
            return 0;
            // Альтернативный вариант реализации
            //return Re.CompareTo(other.Re);
        }
    }
}
