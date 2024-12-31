using car_management_backend.Data.Entitities;
using car_management_backend.Data.Services.Interfaces;
using car_management_backend.DTOs;
using System;
using System.Linq;

namespace car_management_backend.Data.Services
{
    public class GarageRepo : IGarageRepo
    {
        private AppDBContext _dbContext;

        public GarageRepo(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void CreateGarage(Garage garage)
        {
            _dbContext.Garages.Add(garage);
            _dbContext.SaveChanges();
        }

        public bool DeleteGarage(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Garage> GetAllGarages(String city)
        {
            if (city == null) { return _dbContext.Garages.ToList(); }
            return _dbContext.Garages
                .Where(x => x.City.Contains(city))
                .ToList();
        }

        public Garage GetGarage(long id)
        {
            return _dbContext.Garages.Find(id);
        }

        public Garage UpdateGarage(long id)
        {
            throw new NotImplementedException();
        }
    }
}
