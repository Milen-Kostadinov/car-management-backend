using car_management_backend.DTOs;

namespace car_management_backend.Services.Interfaces
{
    public interface ICarService
    {
        CarDTO GetCar(long id);
        CarDTO UpdateCar(long id);
        bool DeleteCar(long id);
        List<CarDTO> GetCars(
            String carMake,
            long garageId,
            int fromYearm,
            int toYear);
        CarDTO CreateCar(CarDTO car);

    }
}
