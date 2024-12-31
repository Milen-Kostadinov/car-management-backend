using car_management_backend.Data.Entitities;
using car_management_backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace car_management_backend.Data.Services.Interfaces
{
    public interface IGarageRepo
    {
        Garage GetGarage(long id);
        void UpdateGarage(Garage g);
        bool DeleteGarage(long id);
        void CreateGarage(Garage garage);
        IEnumerable<Garage> GetAllGarages(String city);
    }
}
