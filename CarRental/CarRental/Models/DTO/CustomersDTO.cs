using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models.DTO
{
    public class CustomersDTO
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public int Location_ID { get; set; }
        public string Phone_Number { get; set; }
    }
}
