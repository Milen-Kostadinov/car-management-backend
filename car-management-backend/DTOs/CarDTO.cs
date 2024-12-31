using car_management_backend.Data.Entitities;

namespace car_management_backend.DTOs
{
    public class CarDTO
    {
        /*public long CarId { get; set; }
        public List<Garage> Garages { get; set; }
        public List<long> GarageId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public String LicensePlate { get; set; }*/

        public long CarId { get; set; }
        public String Make { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public String LicensePlate { get; set; }
        public List<long> GarageId { get; set; }
    }
}
