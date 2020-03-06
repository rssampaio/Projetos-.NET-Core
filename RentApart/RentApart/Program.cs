using System;

namespace RentApart
{
    class Program
    {
        static void Main(string[] args)
        {
            int nrocontrato = 0;
            Apartamento[] ap = new Apartamento[10];

            Console.Write("Aluga-se Apartamentos");
            Console.WriteLine();

            Console.Write("Quantos quartos serão alugados (0-10) ?: ");
            int qtdequartos = int.Parse(Console.ReadLine());

            if (qtdequartos > 0)
            {
                for (int i = 0; i < qtdequartos; i++)
                {
                    // Gera numero de contrato
                    nrocontrato += 1;

                    Console.Clear();
                    Console.WriteLine("Contrato Nro: " + nrocontrato.ToString());
                    Console.Write("Nome: ");
                    string locatario = Console.ReadLine();
                    Console.Write("e-mail: ");
                    string email = Console.ReadLine();
                    Console.Write("Quarto: ");
                    int quarto = int.Parse(Console.ReadLine());

                    ap[quarto] = new Apartamento
                    (
                        nrocontrato,
                        locatario,
                        email
                    );
                }

                Console.Clear();
                Console.WriteLine("Lista de Contratos");

                for (int i = 0; i < 10; i++)
                {
                    if (ap[i] != null)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Contrato Nro: " + ap[i].NroContrato.ToString());
                        Console.WriteLine("Quarto: " + i.ToString());
                        Console.WriteLine("Nome: " + ap[i].Locatario);
                        Console.Write("e-mail: " + ap[i].Email);
                        Console.WriteLine();
                    }
                }
            }
            else
                Console.Write("Nenhum quarto foi alugado !");
        }
    }
}
