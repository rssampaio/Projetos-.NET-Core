using System;

namespace ExercOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa pes1, pes2;

            pes1 = new Pessoa();
            pes2 = new Pessoa();

            for ( int x=1; x<=2; x++ )
            { 

                Console.WriteLine("Cadastro de Pessoa");
                Console.WriteLine();

                if ( x == 1) 
                { 
                    Console.Write("Nome 1: ");
                    pes1.Nome = Console.ReadLine();
                    Console.Write("Idade 1: ");
                    pes1.Idade = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write("Nome 2: ");
                    pes2.Nome = Console.ReadLine();
                    Console.Write("Idade 2: ");
                    pes2.Idade = int.Parse(Console.ReadLine());
                }

                Console.Clear();
            }

            string velha = "Pessoa mais velha é: ";

            if ( pes1.Idade > pes2.Idade)
            {
                Console.WriteLine("Nome : " + pes1.Nome);
                Console.WriteLine("Idade : " + pes1.Idade.ToString());

                Console.WriteLine();
                Console.WriteLine(velha + pes1.Nome);
            }
            else
            {
                Console.WriteLine("Nome : " + pes2.Nome);
                Console.WriteLine("Idade : " + pes2.Idade.ToString());

                Console.WriteLine();
                Console.WriteLine(velha + pes2.Nome);
            }

        }
    }
}
