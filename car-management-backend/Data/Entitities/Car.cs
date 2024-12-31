using Microsoft.EntityFrameworkCore;

namespace car_management_backend.Data.Entitities
{
    public class Car
    {
        public long CarId { get; set; }
        public String Make { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public String LicensePlate { get; set; }
        public List<long> GarageId { get; set; }
    }
}
