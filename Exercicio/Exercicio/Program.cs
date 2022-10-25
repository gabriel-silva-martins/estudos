using System.Globalization;
using Exercicio.Entitites;
using System;
using System.Collections.Generic;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Entre o número de pagadores de taxas: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Pagador de taxa #{i}: ");
                Console.Write("Empresa ou Pessoa (e/p): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Ganho anual: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'p')
                {
                    Console.Write("Gastos com saúde: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(nome, anualIncome, health));
                } else if(ch == 'e')
                {
                    Console.Write("Quantidade de funcionários: ");
                    int qtd = int.Parse(Console.ReadLine());
                    list.Add(new Company(nome, anualIncome, qtd));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAGADORES DE TAXAS: ");

            double soma = 0.0;

            foreach(TaxPayer obj in list)
            {
                double tax = obj.Tax();
                Console.WriteLine(obj.Name + ": R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                soma += tax;
            }

            Console.WriteLine();
            Console.WriteLine("Valor total em taxas: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
