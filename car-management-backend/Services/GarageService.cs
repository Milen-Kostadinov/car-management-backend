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
            return _garageRepo.DeleteGarage(id);
        }

        public IEnumerable<ResponseGarageDTO> GetAllGarages(String city)
        {
            var garages = _garageRepo.GetAllGarages(city);
            return garages.Select(ConvertToResponseDTO).ToList();
        }

        public GarageDTO GetGarage(long id)
        {
            return ConvertToDTO(_garageRepo.GetGarage(id));
        }

        public IEnumerable<GarageQueryDTO> GetGarageReport(long garageId, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public CreateGarageDTO UpdateGarage(long id, CreateGarageDTO g)
        {
            var garage = _garageRepo.GetGarage(id);
            if (garage == null) return null;

            garage.Location = g.Location;
            garage.Name = g.Name;
            garage.City = g.City;
            garage.Capacity = g.Capacity;

            _garageRepo.UpdateGarage(garage);

            return g;
        }
        public GarageDTO ConvertToDTO(Garage garage)
        {
            return new GarageDTO
            {
                Id = garage.GarageId,
                Name = garage.Name,
                Location = garage.Location,
                City = garage.City,
                Capacity = garage.Capacity,
            };
        }
        public ResponseGarageDTO ConvertToResponseDTO(Garage garage)
        {
            return new ResponseGarageDTO
            {
                Id = garage.GarageId,
                Name = garage.Name,
                Location = garage.Location,
                City = garage.City,
                Capacity = garage.Capacity,
            };
        }
    }
}
