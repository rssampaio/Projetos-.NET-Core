using RentACar.Entities;
using System;

namespace RentACar.Services
{
    class RentalServices
    {
        public double PricePerOur { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;
        public RentalServices(double pricePerOur, double pricePerDay, ITaxService taxservice)
        {
            PricePerOur = pricePerOur;
            PricePerDay = pricePerDay;
            _taxService = taxservice;
        }

        public void ProcessInvoive(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerOur * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
