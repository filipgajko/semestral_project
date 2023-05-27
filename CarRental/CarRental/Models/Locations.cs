using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Locations
    {
        [Key]
        public int Location_ID { get; set; }
        public string Location_Name { get; set; }
        public string Address { get; set; }
        

    }
}
