using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public Seller Seller { get; set; }
        public SaleStatus Status { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, float amount, Seller seller, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
            Status = status;
        }
    }
}
