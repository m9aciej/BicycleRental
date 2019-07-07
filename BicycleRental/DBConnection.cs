using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using BicycleRental.Model;

namespace BicycleRental
{

    public class DBConnection : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}
