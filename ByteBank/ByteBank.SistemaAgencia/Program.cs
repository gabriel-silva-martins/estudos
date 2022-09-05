using System;
using ByteBank.SistemaAgencia;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(458, 4885);

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
