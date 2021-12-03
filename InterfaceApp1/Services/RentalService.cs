using System;
using InterfaceApp1.Entities;


namespace InterfaceApp1.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private ITaxService _TaxService; // espera um serviço de imposto qualquer

        //Inversão de controle por injeção de dependência
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish - carRental.Start;
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _TaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
