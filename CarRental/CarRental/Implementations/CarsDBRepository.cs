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
                Available = (byte)(CarDTO.Available?1:0)
            });
            return RentalContext.Cars.Any(xd => xd.Make == CarDTO.Make && xd.Model == CarDTO.Model);
        }


        public List<Cars> GetCars()
        {
            return RentalContext.Cars.ToList();
        }

        public bool RemoveCar(CarDTO CarDTO)
        {
            var Car = RentalContext.Cars.Where(xd => xd.Make == CarDTO.Make && xd.Model == CarDTO.Model && xd.Year == CarDTO.Year && xd.Color == CarDTO.Color && xd.Rental_Rate == CarDTO.Rental_Rate && xd.Available == (byte)(CarDTO.Available ? 1 : 0)).SingleOrDefault();
            if(Car == null )
            {
                return false;
            }
            RentalContext.Cars.Remove(Car);
            return true;
        }

        public bool UpdateCar(CarDTO CarDTO)
        {
            throw new NotImplementedException();
        }

    }
}
