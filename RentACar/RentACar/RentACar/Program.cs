using System;
using System.Globalization;
using RentACar.Entities;
using RentACar.Services;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Aluguel");
            Console.Write("Modelo Veiculo: ");
            string model = Console.ReadLine();
            Console.Write("Data Retirada ( dd/MM/aaaa HH:mm ): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data Entrega ( dd/MM/aaaa HH:mm ): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Preço por Hora: ");
            double VlrHour = double.Parse(Console.ReadLine());

            Console.Write("Preço por Dia: ");
            double VlrDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalServices rentalServices = new RentalServices(VlrHour, VlrDay, new BrazilTaxService());

            rentalServices.ProcessInvoive(carRental);

            Console.WriteLine();
            Console.WriteLine("PEDIDO");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
