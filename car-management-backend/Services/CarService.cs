using car_management_backend.Data.Entitities;
using car_management_backend.Data.Services.Interfaces;
using car_management_backend.DTOs;
using car_management_backend.Services.Interfaces;

namespace car_management_backend.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepo _carRepo;
        public CarService(ICarRepo carRepo) 
        {
            this._carRepo = carRepo;    
        }
        public CarDTO CreateCar(CarDTO car)
        {
            Console.WriteLine(car.CarId);
            var newCar = new Car
            {
                CarId = 0,
                GarageId = car.GarageId,
                LicensePlate = car.LicensePlate,
                Make = car.Make,
                Model = car.Model,
                ProductionYear = car.ProductionYear
            };
            _carRepo.CreateCar(newCar);
            return car;
        }

        public bool DeleteCar(long id)
        {
            throw new NotImplementedException();
        }

        public CarDTO GetCar(long id)
        {
            throw new NotImplementedException();
        }

        public List<CarDTO> GetCars(string carMake, long garageId, int fromYearm, int toYear)
        {
            throw new NotImplementedException();
        }

        public CarDTO UpdateCar(long id)
        {
            throw new NotImplementedException();
        }
    }
}
