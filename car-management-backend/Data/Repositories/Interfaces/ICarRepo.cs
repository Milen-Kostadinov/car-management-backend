using car_management_backend.Data.Entitities;
using car_management_backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace car_management_backend.Data.Services.Interfaces
{
    public interface ICarRepo
    {
        Car GetCar(long id);
        void UpdateCar(Car c);
        bool DeleteCar(long id);
        void CreateCar(Car car);
        IEnumerable<Car> GetAllCars(
            String? carMake,
            long? garageId,
            int? fromYearm,
            int? toYear);
        IEnumerable<Garage> GetGarages(IEnumerable<long> gs);
    }
}
