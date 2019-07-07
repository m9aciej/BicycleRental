using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRental.Model
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string Number { get; set; }
        public bool Rent { get; set; }
        public BikeType BikeType { get; set; }

    }
}
