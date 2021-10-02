using System;
using System.Collections.Generic;
using System.IO;

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
            Dictionary<string, int> votos = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split(',');

                            if (votos.ContainsKey(line[0]))
                            {
                                int qtde = votos[line[0]];
                                qtde += int.Parse(line[1]);

                                votos[line[0]] = qtde;
                            }
                            else
                            {
                                votos[line[0]] = int.Parse(line[1]);
                            }
                        }
                    }
                }

                Console.WriteLine();

                foreach (KeyValuePair<string, int> item in votos)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
