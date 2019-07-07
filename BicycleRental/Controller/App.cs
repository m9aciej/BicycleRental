using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BicycleRental.Model;
using System.Data.Entity;

namespace BicycleRental.Controller
{
    public class App
    {
        public static void RemoveBike(string Num)
        {
            using (var context = new DBConnection())
            {
                var bike = context.Bikes.Where(r => r.Number == Num).FirstOrDefault();
                //context.Bikes.Remove(bike);
                //context.SaveChanges();
                if (bike != null)
                {
                    var rent = context.Rents.Where(r => r.Bike.Number == Num);
                    context.Rents.RemoveRange(rent);
                    context.Bikes.Remove(bike);
                    context.SaveChanges();
                }
            }
        }

        public static void ReturnBike(string Num)
        {
            using (var context = new DBConnection())
            {
                var rent = context.Rents.Include(r => r.Bike).Where(r => r.Bike.Number == Num)
                    .Where(r => r.ReturnDate == null)
                    .FirstOrDefault();
                if (rent != null)
                {
                    rent.Bike.Rent = false;
                    rent.ReturnDate = DateTime.Now;
                    context.SaveChanges();
                }
            }
        }

        public static void RentBike(string Num)
        {
            using (var context = new DBConnection())
            {
                var bike = context.Bikes.Where(el => el.Number == Num)
                    .Where(el => el.Rent != true)
                    .FirstOrDefault();
                if(bike != null) {
                    bike.Rent = true;
                    var rent = new Rent { RentDate = DateTime.Now, Bike = bike };
                    context.Rents.Add(rent);
                    context.SaveChanges();
                }
            }
        }

        public static void MakeBike(string num, BikeType typ)
        {

            //var bikes = new List<Bike> {
            //    new Bike {Number = "001", BikeType = BikeType.Montain},
            //    new Bike {Number = "002", BikeType = BikeType.Montain}
            //};

            //var bike = new Bike();
            //bike.Number = num;
            //bike.BikeType = typ;
            //AddRange - wieksza kolekcja
            var bike = new Bike { Number = num, BikeType = typ };
            using (var context = new DBConnection())
            {
                context.Bikes.Add(bike);
                context.SaveChanges();
            }
        }
    }

}
