using CarRental.Models;
using CarRental.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Interfaces
{
    public interface ICarsDbRepository
    {
        public bool AddCar(CarDTO CarDTO);
        public bool UpdateCar(CarDTO CarDTO);
        public bool RemoveCar(CarDTO CarDTO);
        public List<Cars> GetCars();
    }
}
