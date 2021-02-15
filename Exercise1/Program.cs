using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            String name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2}", name, age, grade.ToString("F"));

        }
    }
}
