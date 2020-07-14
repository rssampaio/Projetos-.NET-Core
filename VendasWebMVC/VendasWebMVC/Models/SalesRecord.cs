using System;
using System.ComponentModel.DataAnnotations;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Vendas")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Amount { get; set; }

        [Display(Name = "Situação")]
        public SalesStatus Status { get; set; }

        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
