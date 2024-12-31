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
            var garage = _dbContext.Garages.FirstOrDefault(x => x.GarageId == id);
            if (garage != null) 
            {
                _dbContext.Garages.Remove(garage);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
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

        public void UpdateGarage(Garage g)
        {
            _dbContext.Garages.Update(g);
            _dbContext.SaveChanges();
        }
    }
}
