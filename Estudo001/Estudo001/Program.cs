using System;
using System.Collections.Generic;

namespace Estudo001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            nomes.AdicionarVarios("Gabriel", "Estephane", "Maria", "Francisco");

            for(int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            List<int> idades = new List<int>();
            idades.AdicionarVarios(14, 25, 17, 20, 35);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}