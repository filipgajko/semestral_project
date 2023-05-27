using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental;

public class RentalContext : DbContext
{
    public DbSet<Customers> customers { get; set; }
    public DbSet<Locations> Locations { get; set; }
    public DbSet<Rentals> Rentals { get; set; }
    public DbSet<Cars> Cars { get; set; }
    public RentalContext():base("name = YourConnectionStringName")
    {

    }


}
