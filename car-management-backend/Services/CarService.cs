using car_management_backend.Data.Entitities;
using car_management_backend.Data.Services;
using car_management_backend.Data.Services.Interfaces;
using car_management_backend.DTOs;
using car_management_backend.Services.Interfaces;

namespace car_management_backend.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepo _carRepo;
        public CarService(ICarRepo carRepo, IGarageRepo _garageRepo)
        {
            this._carRepo = carRepo;
        }
        public CreateCarDTO CreateCar(CreateCarDTO car)
        {
            var newCar = new Car
            {
                CarId = 0,
                GarageIds = car.GarageIds,
                LicensePlate = car.LicensePlate,
                Make = car.Make,
                Model = car.Model,
                ProductionYear = car.ProductionYear
            };
            _carRepo.CreateCar(newCar);
            return new CreateCarDTO
            {
                GarageIds = car.GarageIds,
                LicensePlate = car.LicensePlate,
                Make = car.Make,
                Model = car.Model,
                ProductionYear = car.ProductionYear
            };
        }

        public bool DeleteCar(long id)
        {
            return _carRepo.DeleteCar(id);
        }

        public CarDTO GetCar(long id)
        {
            Car car = _carRepo.GetCar(id);
            return new CarDTO 
            { 
                CarId = car.CarId,
                GarageId = (List<long>)car.GarageIds,
                LicensePlate = car.LicensePlate,
                Make = car.Make,
                Model = car.Model,
                ProductionYear = car.ProductionYear
            };
        }

        public IEnumerable<ResponseCarDTO> GetCars(string? carMake, long? garageId, int? fromYearm, int? toYear)
        {
            var cars = _carRepo.GetAllCars(carMake, garageId, fromYearm, toYear);
            var temptemp = new List<Car>();
            foreach (var car in cars) { temptemp.Add(car); }
            var temp = new List<ResponseCarDTO>();
            foreach (var car in temptemp) { temp.Add(ConvertToDTO(car)); }
            return temp;
        }

        public CreateCarDTO UpdateCar(long id, CreateCarDTO c)
        {
            var car = _carRepo.GetCar(id);
            if (car == null) return null;

            car.LicensePlate = c.LicensePlate;
            car.ProductionYear = c.ProductionYear;
            car.Model = c.Model;
            car.GarageIds = c.GarageIds;

            _carRepo.UpdateCar(car);

            return c;
        }
        public ResponseCarDTO ConvertToDTO(Car c)
        {
            IEnumerable<Garage> garages = _carRepo.GetGarages(c.GarageIds);
            List<ResponseGarageDTO> newOnes = new();
            foreach (Garage garage in garages)
            {
                newOnes.Add(ConvertGaragesToDTO(garage));
            }
            return new ResponseCarDTO
            {

                ProductionYear = c.ProductionYear,
                CarId = c.CarId,
                Garages = newOnes,
                LicensePlate = c.LicensePlate,
                Make = c.Make,
                Model = c.Model,
            };
        }
        public ResponseGarageDTO ConvertGaragesToDTO(Garage garage)
        {
            return new ResponseGarageDTO
            {
                Name = garage.Name,
                Location = garage.Location,
                Capacity = garage.Capacity,
                City = garage.City,
                Id = garage.GarageId
            };
        }
    }
}
