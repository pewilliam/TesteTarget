using System;
using System.Collections.Generic;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;

            List<int> list = new List<int>();

            Console.Write("Digite a quantidade de índices: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write("Digite o número que deve ser checado: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.Write(n1 + " ");
                list.Add(n1);

                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }

            Console.WriteLine();

            if (list.Contains(n))
            {
                Console.WriteLine("O número " + n + " existe na sequência!");
            }
            else
            {
                Console.WriteLine("O número " + n + " não existe na sequência.");
            }
        }
    }
}
