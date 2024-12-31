using car_management_backend.DTOs;

namespace car_management_backend.Services.Interfaces
{
    public interface IGarageService
    {
        GarageDTO GetGarage(long id);
        GarageDTO UpdateGarage(long id);
        bool DeleteGarage(long id);
        IEnumerable<GarageQueryDTO> GetGarageReport(
            long garageId,
            DateTime startDate,
            DateTime endDate);
        IEnumerable<GarageDTO> GetAllGarages(String city);
        GarageDTO CreateGarage(GarageDTO garage);
    }
}
