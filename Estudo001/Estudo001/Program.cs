using System;
using System.Collections.Generic;

namespace Estudo001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> idades = new List<string>();

            //idades.Add(1);
            //idades.Add(5);
            //idades.Add(14);
            //idades.Add(26);

            //idades.Remove(5);

            idades.AdicionarVarios("Gabriel", "Estephane", "Maria", "Francisco");

            for(int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}