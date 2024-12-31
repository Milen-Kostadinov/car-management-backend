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
        public void GetCarById([FromRoute] long id)
        {

        }
        [HttpPut]
        [Route("{id}")]
        public void UpdateCarById([FromRoute] long id)
        {

        }
        [HttpDelete]
        [Route("{id}")]
        public void DeleteCarById([FromRoute] long id)
        {

        }

        [HttpGet]
        public void GetAllCars(
            [FromQuery]string carMake,
            [FromQuery]long garageId,
            [FromQuery]int fromYearm,
            [FromQuery]int toYear)
        { 
            
        }

        [HttpPost]
        public CarDTO CreateCar(
            [FromBody]CarDTO car)
        {
            _carService.CreateCar(car);
            return car;
        }
    }
}
