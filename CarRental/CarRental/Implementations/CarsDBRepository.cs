using CarRental.Interfaces;
using CarRental.Models;
using CarRental.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Implementations
{
    public class CarsDBRepository : ICarsDbRepository
    {
        private readonly RentalContext RentalContext;

        public CarsDBRepository()
        {
            RentalContext = new RentalContext();
        }

        public bool AddCar(CarDTO CarDTO)
        {
            RentalContext.Cars.Add(new Cars()
            {
                Make = CarDTO.Make,
                Model = CarDTO.Model,
                Year = CarDTO.Year,
                Color = CarDTO.Color, 
                Rental_Rate = CarDTO.Rental_Rate,
                Available = CarDTO.Available
            });
            RentalContext.SaveChanges();
            return RentalContext.Cars.Any(xd => xd.Make == CarDTO.Make && xd.Model == CarDTO.Model);
        }


        public List<Cars> GetCars()
        {

            return RentalContext.Cars.ToList();
        }

        public bool RemoveCar(CarDTO CarDTO)
        {
            var Car = RentalContext.Cars.Where(xd => xd.Make == CarDTO.Make && xd.Model == CarDTO.Model && xd.Year == CarDTO.Year && xd.Color == CarDTO.Color && xd.Rental_Rate == CarDTO.Rental_Rate && xd.Available == (CarDTO.Available)).SingleOrDefault();
            if(Car == null )
            {
                return false;
            }
            RentalContext.Cars.Remove(Car);
            RentalContext.SaveChanges();
            return true;
        }

        public bool UpdateCar(CarDTO CarDTO)
        {
            var Car = RentalContext.Cars.Where(xd => xd.Make == CarDTO.Make && xd.Model == CarDTO.Model && xd.Year == CarDTO.Year && xd.Color == CarDTO.Color && xd.Rental_Rate == CarDTO.Rental_Rate && xd.Available == (CarDTO.Available)).SingleOrDefault();
            if (Car == null)
            {
                return false;
            }

            Car.Make = CarDTO.Make;
            Car.Model = CarDTO.Model;
            Car.Year = CarDTO.Year;
            Car.Color = CarDTO.Color;
            Car.Rental_Rate = CarDTO.Rental_Rate;
            Car.Available = (CarDTO.Available);

            RentalContext.SaveChanges();
            return true;
        }

    }
}
