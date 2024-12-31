using car_management_backend.DTOs;
using car_management_backend.Services.Interfaces;

namespace car_management_backend.Services
{
    public class MaintananceService : IMaintananceService
    {
        public bool DeleteMaintanance(long id)
        {
            throw new NotImplementedException();
        }

        public MaintananceDTO GetMaintanance(long id)
        {
            throw new NotImplementedException();
        }

        public List<MaintananceDTO> GetMaintanances(long carId, long garageId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public List<MaintanaceQueryDTO> GetMonthlyRequestsReport(long garageId, string startMonth, string endMonth)
        {
            throw new NotImplementedException();
        }

        public MaintananceDTO UpdateMaintanance(long id)
        {
            throw new NotImplementedException();
        }
    }
}
