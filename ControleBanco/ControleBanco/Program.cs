using System;

namespace ControleBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria cb = new ContaBancaria();
            double valor = 0;

            Console.Write("Entre com o número da conta: ");
            cb.NroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            cb.Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ?");
            char opc = char.Parse(Console.ReadLine());

            if ( opc == 's' || opc == 'S' )
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
                cb.Deposito(valor);
            }

            Console.WriteLine(cb);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            cb.Deposito(valor);

            Console.WriteLine(cb);
            Console.WriteLine();

            Console.Write("Deseja realizar um saque (S/N) ?");
            char per = char.Parse(Console.ReadLine());

            if ( per == 'S' || per == 's' )
            {
                Console.WriteLine();
                Console.Write("Entre um valor de saque: ");
                valor = double.Parse(Console.ReadLine());
                cb.Saque(valor);
            }

            Console.WriteLine(cb);
            Console.WriteLine();

        }
    }
}
