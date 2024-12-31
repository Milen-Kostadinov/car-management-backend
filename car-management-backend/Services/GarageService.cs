using car_management_backend.Data.Entitities;
using car_management_backend.Data.Services;
using car_management_backend.Data.Services.Interfaces;
using car_management_backend.DTOs;
using car_management_backend.Services.Interfaces;

namespace car_management_backend.Services
{
    public class GarageService : IGarageService
    {
        private readonly IGarageRepo _garageRepo;
        public GarageService(IGarageRepo garageRepo)
        {
            _garageRepo = garageRepo;
        }

        public GarageDTO CreateGarage(GarageDTO garage)
        {
            Garage newGarage = new Garage
            { 
                GarageId = 0,
                Capacity = garage.Capacity,
                City = garage.City,
                Location = garage.Location,
                Name = garage.Name  
            };
            _garageRepo.CreateGarage(newGarage);
            return garage;
        }

        public bool DeleteGarage(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GarageDTO> GetAllGarages(String city)
        {
            var garages = _garageRepo.GetAllGarages(city);
            return garages.Select(ConvertToDTO).ToList();
        }

        public GarageDTO GetGarage(long id)
        {
            return ConvertToDTO(_garageRepo.GetGarage(id));
        }

        public IEnumerable<GarageQueryDTO> GetGarageReport(long garageId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public GarageDTO UpdateGarage(long id)
        {
            throw new NotImplementedException();
        }
        public GarageDTO ConvertToDTO(Garage garage)
        {
            return new GarageDTO
            {
                GarageId = garage.GarageId,
                Capacity = garage.Capacity,
                City = garage.City,
                Location = garage.Location,
                Name = garage.Name
            };
        }
    }
}
