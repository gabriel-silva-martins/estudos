using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo001
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(this List<int> lista, params int[] itens)
        {
            foreach(int item in itens)
            {
                lista.Add(item);
            }
        }
    }
}
