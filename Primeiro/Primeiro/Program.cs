using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cáclculos Diversos !!");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1 - Somatório");
            Console.WriteLine("2 - Raio");
            Console.WriteLine("3 - Diferença");

            Console.WriteLine();

            Console.Write("Opção número: ");
            int opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.Clear();
                Somatorio();
            }
            else if (opc == 2)
            {
                Console.Clear();
                ValorCirculo();
            }
            else if (opc == 3)
            { 
                Console.Clear();
                DiferencaNum();
            }
            else
            {
                Console.WriteLine("Opção Inválida !!");
            }

            Console.WriteLine();
            Console.WriteLine("FIM !!");

        }

        static void Somatorio()
        {
            // Declaração de variáveis
            int n1, n2, soma;

            Console.Write("**** SOMATÓRIO ****");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Informe 1o numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Informe 2o numero: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine($"Soma = {soma}");
            Console.WriteLine();

        }

        static void ValorCirculo()
        {
            // Declaração de variáveis
            double n1, pi = 3.14159;

            Console.Write("**** RAIO CIRCULO ****");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Informe o raio: ");
            n1 = double.Parse(Console.ReadLine());

            double raio = pi * Math.Pow(n1, 2);

            Console.WriteLine();
            Console.WriteLine("Raio = " + raio.ToString("F4"));
            Console.WriteLine();

        }

        static void DiferencaNum()
        {
            // Declaração de variáveis
            int n1, n2, n3, n4, calculo;

            Console.Write("**** DIFERENÇA ****");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Informe 1o numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe 2o numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe 3o numero: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Informe 4o numero: ");
            n4 = int.Parse(Console.ReadLine());

            calculo = ((n1 * n2) - (n3 * n4));

            Console.WriteLine();
            Console.WriteLine($"DIFERENCA = {calculo}");

        }
    }
}
