using car_management_backend.DTOs;

namespace car_management_backend.Services.Interfaces
{
    public interface IMaintananceService
    {
        MaintananceDTO GetMaintanance(long id);
        MaintananceDTO UpdateMaintanance(long id);
        bool DeleteMaintanance(long id);
        List<MaintanaceQueryDTO> GetMonthlyRequestsReport(
            long garageId,
            String startMonth,
            String endMonth);
        List<MaintananceDTO> GetMaintanances(
             long carId,
             long garageId,
             DateTime startDate,
             DateTime endDate);
    }
}
