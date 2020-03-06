using System;
using System.Globalization;

namespace ControleProd
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 100.00, 900);

            p.Nome = "TV 4k SAMSUNG";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Quantidade);
        }
    }
}
