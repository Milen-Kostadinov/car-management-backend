using car_management_backend.Data.Entitities;
using car_management_backend.Data.Services.Interfaces;

namespace car_management_backend.Data.Repositories
{
    public class CarRepo : ICarRepo
    {
        private readonly AppDBContext _dbContext;
        public CarRepo(AppDBContext dbContext) 
        {
            this._dbContext = dbContext;
        }
        public void CreateCar(Car car)
        {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        public bool DeleteCar(long id)
        {
            var car = _dbContext.Cars.FirstOrDefault(x => x.CarId == id);
            if (car != null)
            {
                _dbContext.Cars.Remove(car);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Car> GetAllCars(
            String? carMake,
            long? garageId,
            int? fromYearm,
            int? toYear)
        {
            if (garageId == null) { garageId = 0; }
            if (carMake == null) { carMake = ""; }
            if (fromYearm == null) { fromYearm = 0; }
            if (toYear == null) {  toYear = 9999; }
            return _dbContext.Cars
                .Where(z => z.ProductionYear >= fromYearm 
                && z.ProductionYear <= toYear 
                && (garageId == 0 || z.GarageIds.Contains((long)garageId)) 
                && z.Make.Contains(carMake));
        }

        public Car GetCar(long id)
        {
            return _dbContext.Cars.Find(id);
        }

        public void UpdateCar(Car c)
        {
            _dbContext.Cars.Update(c);
            _dbContext.SaveChanges();
        }
        public IEnumerable<Garage> GetGarages(IEnumerable<long> garages)
        {
            return _dbContext.Garages.Where(x => garages.Contains(x.GarageId));
        }
    }
}
