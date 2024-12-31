using car_management_backend.DTOs;

namespace car_management_backend.Services.Interfaces
{
    public interface ICarService
    {
        CarDTO GetCar(long id);
        CreateCarDTO UpdateCar(long id, CreateCarDTO c);
        bool DeleteCar(long id);
        IEnumerable<ResponseCarDTO> GetCars(
            String ?carMake,
            long ?garageId,
            int ?fromYearm,
            int ?toYear);
        CreateCarDTO CreateCar(CreateCarDTO car);

    }
}
