using car_management_backend.Data.Entitities;
using car_management_backend.DTOs;
using car_management_backend.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace car_management_backend.Controllers
{
    [Controller]
    [Route("cars")]
    public class CarController
    {
        private readonly ICarService _carService;
        
        public CarController(ICarService carService) 
        {
            this._carService = carService;
        }
        [HttpGet]
        [Route("{id}")]
        public CarDTO GetCarById([FromRoute] long id)
        {
            return _carService.GetCar(id);
        }
        [HttpPut]
        [Route("{id}")]
        public CreateCarDTO UpdateCarById([FromRoute]long id, [FromBody]CreateCarDTO car)
        {
            return _carService.UpdateCar(id, car);
        }

        [HttpDelete]
        [Route("{id}")]
        public bool DeleteCarById([FromRoute]long id)
        {
            return _carService.DeleteCar(id);
        }

        [HttpGet]
        public IEnumerable<ResponseCarDTO> GetAllCars(
            [FromQuery]string ?carMake,
            [FromQuery]long ?garageId,
            [FromQuery]int ?fromYear,
            [FromQuery]int ?toYear)
        {
            return _carService.GetCars(carMake, garageId, fromYear, toYear);
        }

        [HttpPost]
        public CreateCarDTO CreateCar(
            [FromBody]CreateCarDTO car)
        {
            foreach(long id in car.GarageIds) Console.WriteLine(id);
            return _carService.CreateCar(car);
        }
    }
}
