using car_management_backend.Data.Entitities;
using car_management_backend.Data.Services.Interfaces;
using car_management_backend.DTOs;
using car_management_backend.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace car_management_backend.Controllers
{
    [ApiController]
    [Route("garages")]
    public class GarageController
    {
        private readonly IGarageService _garageService;
        public GarageController(IGarageService garageService)
        {
            this._garageService = garageService;
        }

        [HttpGet("{id}")]
        public GarageDTO GetGarageById(long id)
        {
            return _garageService.GetGarage(id);
        }
        [HttpPut]
        [Route("{id}")]
        public void UpdateGarageById(long id, CreateGarageDTO garage)
        {
            _garageService.UpdateGarage(id, garage);
        }
        [HttpDelete]
        [Route("{id}")]
        public bool DeleteGarageById([FromRoute]long id)
        {
            Console.WriteLine(id);
            return _garageService.DeleteGarage(id);
        }

        [HttpGet]
        [Route("dailyAvailabilityReport")]
        public void DailyAvailabilityReport(
            [FromQuery]long ?garageId,
            [FromQuery]DateTime ?startDate,
            [FromQuery]DateTime ?endDate)
        {

        }

        [HttpGet]
        public IEnumerable<GarageDTO> GetAllGarages([FromQuery]String ?city)
        {
            return _garageService.GetAllGarages(city);
        }

        [HttpPost]
        public CreateGarageDTO CreateGarage(
            [FromBody]GarageDTO garage) 
        {
            GarageDTO d = _garageService.CreateGarage(garage);
            return new CreateGarageDTO
            {
                Capacity = d.Capacity,
                City = d.City,
                Location = d.Location,
                Name = d.Name
            };
        }
    }
}
