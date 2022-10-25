using System;
using System.Collections.Generic;

namespace Estudo001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            //idades.Add(1);
            //idades.Add(5);
            //idades.Add(14);
            //idades.Add(26);

            //idades.Remove(5);

            idades.AdicionarVarios(1, 4, 44, 26, 17, 20, 38);

            for(int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}