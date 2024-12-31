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

        [HttpGet]
        [Route("{id}")]
        public GarageDTO GetGarageById([FromRoute]long id)
        {
            return _garageService.GetGarage(id);
        }
        [HttpPut]
        [Route("{id}")]
        public void UpdateGarageById([FromRoute] long id)
        {
            Console.WriteLine("dawwdawdawdawdawdadw");

        }
        [HttpDelete]
        [Route("{id}")]
        public void DeleteGarageById([FromRoute] long id)
        {

            Console.WriteLine("dawwdawdawdawdawdadw");
        }

        [HttpGet]
        [Route("dailyAvailabilityReport")]
        public void DailyAvailabilityReport(
            [FromQuery]long garageId,
            [FromQuery]DateTime startDate,
            [FromQuery]DateTime endDate)
        {
            Console.WriteLine("dawwdawdawdawdawdadw");

        }

        [HttpGet]
        public IEnumerable<GarageDTO> GetAllGarages([FromQuery]String ?city)
        {
            return _garageService.GetAllGarages(city);
        }

        [HttpPost]
        public void CreateGarage(
            [FromBody]GarageDTO garage) 
        {
            _garageService.CreateGarage(garage);
        }
    }
}
