using System;
using System.Collections.Generic;

namespace Secao15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual exercício você quer executar? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (n == 1)
            {
                Exercicio01();
            }
            else
            {
                Exercicio02();
            }
        }

        static void Exercicio01()
        {
            HashSet<int> course = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                course.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                course.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                course.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
            Console.Write("Total students: " + course.Count);
        }

        static void Exercicio02()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
