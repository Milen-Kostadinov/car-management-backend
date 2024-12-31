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
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Car GetCar(long id)
        {
            throw new NotImplementedException();
        }

        public Car UpdateCar(long id)
        {
            throw new NotImplementedException();
        }
    }
}
