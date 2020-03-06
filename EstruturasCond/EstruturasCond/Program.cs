using System;

namespace EstruturasCond
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "2002";
            string infoUser = " ";

            Console.WriteLine("Validação de Senha");
            Console.WriteLine();

            Console.Write("Informe a Senha: ");
            infoUser = Console.ReadLine();

            while (infoUser != senha)
            {

                Console.WriteLine("Senha Inválida !!");
                Console.Write("Pressione <ENTER> para continuar...");
                Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Validação de Senha");
                Console.WriteLine();

                Console.Write("Informe a Senha: ");
                infoUser = Console.ReadLine();

            }

            Console.WriteLine("Senha Correta !!!");
        }
    }
}
