using car_management_backend.Data.Entitities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace car_management_backend.Controllers
{
    [ApiController]
    [Route("maintenance")]
    public class MaintanaceController
    {
        [HttpGet]
        [Route("{id}")]
        public void GetMaintanaceById([FromRoute] long id) 
        {
            
        }
        [HttpPut]
        [Route("{id}")]
        public void UpdateMaintanaceById([FromRoute] long id)
        {

        }
        [HttpDelete]
        [Route("{id}")]
        public void DeleteMaintanaceById([FromRoute] long id)
        {

        }

        [HttpGet]
        [Route("monthlyRequestsReport")]
        public void GetMonthlyRequestsReport(
            [FromQuery]long garageId,
            [FromQuery]String startMonth,
            [FromQuery] String endMonth) 
        {
        
        }

        [HttpGet]
        public void GetAllMaintanace(
            [FromQuery] long carId,
            [FromQuery] long garageId,
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        { 
        
        }

        [HttpPost]
        public void CreateMaintance(
            [FromBody]Maintanance maintanance) 
        {

        }

    }
}
