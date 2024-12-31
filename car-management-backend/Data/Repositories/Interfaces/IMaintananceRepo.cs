using car_management_backend.Data.Entitities;
using car_management_backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace car_management_backend.Data.Services.Interfaces
{
    public interface IMaintananceRepo
    {
        Maintanance GetMaintanance(long id);
        Maintanance UpdateMaintanance(long id);
        bool DeleteMaintanance(long id);
        IEnumerable<Maintanance> GetMaintanances();
        Maintanance CreateMaintanance(Maintanance maintanance);
    }
}
