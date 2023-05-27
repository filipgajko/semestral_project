using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models.DTO
{
    public class RentalsDTO
    {
        public int Customer_ID { get; set; }
        public int Car_ID { get; set; }
        public DateTime Rental_Date { get; set; }
        public DateTime Return_Date { get; set; }
        public float Total_Cost { get; set; }
    }
}
