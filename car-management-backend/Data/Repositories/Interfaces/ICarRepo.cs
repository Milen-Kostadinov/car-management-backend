using car_management_backend.Data.Entitities;
using car_management_backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace car_management_backend.Data.Services.Interfaces
{
    public interface ICarRepo
    {
        Car GetCar(long id);
        Car UpdateCar(long id);
        bool DeleteCar(long id);
        void CreateCar(Car car);
        IEnumerable<Car> GetAllCars();
    }
}
